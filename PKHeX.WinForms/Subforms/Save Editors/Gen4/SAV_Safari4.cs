using System;
using System.Globalization;
using System.Windows.Forms;
using PKHeX.Core;

namespace PKHeX.WinForms;

public partial class SAV_Safari4 : Form
{
    public SAV_Safari4(SAV4HGSS sav)
    {
        InitializeComponent();
        WinFormsUtil.TranslateInterface(this, Main.CurrentLanguage);
        SAV = (SAV4HGSS)(Origin = sav).Clone();
        Safari = SAV.Safari;

        SetupBlocks();
        SetupObjects();
        SetupDays();
        SetupCombos();

        Loading = false;
        CB_Layout.SelectedIndex = 0; // triggers LoadLayout
        LoadSettings();
        LoadFriend();
    }

    private readonly SAV4HGSS Origin;
    private readonly SAV4HGSS SAV;
    private readonly Safari4 Safari;

    private bool Loading = true;
    private int LayoutIndex;
    private int BlockIndex = -1;

    /// <summary>
    /// Map areas by name.
    /// </summary>
    private static readonly string[] AreaNames =
    [
        "Plains", "Meadow", "Savannah", "Peak", "Rocky Beach",
        "Wetland", "Forest", "Swamp", "Marshland", "Wasteland",
        "Mountain", "Desert",
    ];

    private static string GetAreaName(int index) => (uint)index < AreaNames.Length
        ? AreaNames[index]
        : $"(Unused {index})";

    /// <summary>
    /// Placeable Safari Zone objects in ID order starting at 0.
    /// </summary>
    private static readonly string[] ObjectNames =
    [
        "None",
        "Shrub", "Red Flower", "White Flower", "Tree", "Tree Stump", "Branch",
        "Small Rock", "Large Rock", "Mossy Rock",
        "Puddle", "Fountain", "Watering Hole",
        "Bench",
        "Short Fence (Horizontal)", "Short Fence (Vertical)",
        "Long Fence (Horizontal)", "Long Fence (Vertical)",
        "Signboard", "Statue", "Flag", "Street Lamp",
        "Guidepost (Right)", "Guidepost (Left)",
        "Trash Can",
    ];

    private static string GetObjectName(int id) => (uint)id < ObjectNames.Length
        ? ObjectNames[id]
        : $"(Unknown {id})";

    private static byte ParseObjectID(object? value)
    {
        var text = value?.ToString();
        if (text is null)
            return 0;

        var known = Array.IndexOf(ObjectNames, text);
        if (known >= 0)
            return (byte)known;

        var digits = text.Trim();
        if (digits.StartsWith('(') && digits.EndsWith(')'))
            digits = digits[1..^1];
        var spaceIndex = digits.LastIndexOf(' ');
        if (spaceIndex >= 0)
            digits = digits[(spaceIndex + 1)..];

        return byte.TryParse(digits, out var result) ? result : (byte)0;
    }

    #region Setup

    private void SetupCombos()
    {
        CB_Layout.Items.Clear();
        CB_Layout.Items.Add("Player's");
        CB_Layout.Items.Add("Friend's");

        CB_GameLayout.Items.Clear();
        CB_GameLayout.Items.Add("Player's");
        CB_GameLayout.Items.Add("Friend's");

        CB_FriendGender.Items.Clear();
        CB_FriendGender.Items.Add("Male");
        CB_FriendGender.Items.Add("Female");
    }

    private void SetupBlocks()
    {
        DGV_Blocks.Rows.Clear();
        DGV_Blocks.Columns.Clear();

        DataGridViewTextBoxColumn slot = new()
        {
            HeaderText = "Slot",
            Width = 50,
            ReadOnly = true,
        };
        DataGridViewComboBoxColumn area = new()
        {
            HeaderText = "Area",
            Width = 120,
            FlatStyle = FlatStyle.Flat,
            DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
        };
        for (int i = 0; i < SafariLayout4.MapCount; i++)
            area.Items.Add(GetAreaName(i));

        DataGridViewTextBoxColumn count = new()
        {
            HeaderText = "Objects",
            Width = 60,
            ReadOnly = true,
        };

        DGV_Blocks.Columns.Add(slot);
        DGV_Blocks.Columns.Add(area);
        DGV_Blocks.Columns.Add(count);
        DGV_Blocks.Rows.Add(SafariLayout4.BlockCount);

        for (int i = 0; i < SafariLayout4.BlockCount; i++)
            DGV_Blocks.Rows[i].Cells[0].Value = (i + 1).ToString();
    }

    private void SetupObjects()
    {
        DGV_Objects.Rows.Clear();
        DGV_Objects.Columns.Clear();

        DataGridViewComboBoxColumn id = new()
        {
            HeaderText = "ID",
            Width = 150,
            FlatStyle = FlatStyle.Flat,
            DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
        };
        foreach (var name in ObjectNames)
            id.Items.Add(name);
        DGV_Objects.Columns.Add(id);

        foreach (var header in (ReadOnlySpan<string>)["X", "Y", "Z"])
        {
            DGV_Objects.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = header,
                Width = 45,
            });
        }
    }

    private void SetupDays()
    {
        DGV_Days.Rows.Clear();
        DGV_Days.Columns.Clear();

        DGV_Days.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Area",
            Width = 120,
            ReadOnly = true,
        });
        DGV_Days.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Days",
            Width = 55,
        });

        DGV_Days.Rows.Add(SafariLayout4.MapCount);
        for (int i = 0; i < SafariLayout4.MapCount; i++)
            DGV_Days.Rows[i].Cells[0].Value = GetAreaName(i);
    }

    #endregion

    #region Load

    private void LoadLayout()
    {
        Loading = true;
        var layout = Safari.GetLayout(LayoutIndex);

        for (int i = 0; i < SafariLayout4.BlockCount; i++)
        {
            var block = layout.GetBlock(i);
            var cells = DGV_Blocks.Rows[i].Cells;
            var map = (int)block.MapID;
            cells[1].Value = GetAreaName(map < SafariLayout4.MapCount ? map : 0);
            cells[2].Value = block.ObjectCount.ToString();
        }

        var levels = layout.MapLevels;
        for (int i = 0; i < SafariLayout4.MapCount; i++)
            DGV_Days.Rows[i].Cells[1].Value = levels[i].ToString();

        Loading = false;
        BlockIndex = -1;
        LoadObjects(0);
    }

    private void LoadObjects(int index)
    {
        if (BlockIndex == index)
            return;

        SaveObjects();
        BlockIndex = index;

        Loading = true;
        var block = Safari.GetLayout(LayoutIndex).GetBlock(index);
        DGV_Objects.Rows.Clear();

        var count = Math.Min(block.ObjectCount, (byte)SafariBlock4.ObjectCountMax);
        if (count != 0)
            DGV_Objects.Rows.Add(count);

        for (int i = 0; i < count; i++)
        {
            var obj = block.GetObject(i);
            var cells = DGV_Objects.Rows[i].Cells;
            cells[0].Value = GetObjectName(obj.ID);
            cells[1].Value = obj.X.ToString();
            cells[2].Value = obj.Y.ToString();
            cells[3].Value = obj.Z.ToString();
        }

        GB_Objects.Text = $"Objects - Area {index + 1} ({count}/{SafariBlock4.ObjectCountMax})";
        Loading = false;
    }

    private void LoadSettings()
    {
        Loading = true;
        NUD_ObjectLevel.Maximum = Safari4.MaxObjectLevel;
        NUD_ObjectLevel.Value = Safari.ObjectLevel;
        NUD_Delay.Value = Safari.LevelUpDelayCount;
        NUD_EventKey.Value = Safari.EventKeyTime;
        CB_GameLayout.SelectedIndex = Math.Min(Safari.GameLayout, (byte)1);
        Loading = false;
    }

    private void LoadFriend()
    {
        Loading = true;
        var manager = Safari.Manager;
        manager.Language = (byte)SAV.Language;

        CHK_FriendValid.Checked = manager.IsValid;
        TB_FriendName.Text = manager.Name;
        TB_FriendID.Text = manager.ID32.ToString(CultureInfo.InvariantCulture);
        CB_FriendGender.SelectedIndex = Math.Min(manager.Gender, (byte)1);
        L_FriendMeta.Text = $"Received: {manager.CheckTime}   RTC offset: {manager.RTCOffset}";
        Loading = false;
    }

    #endregion

    #region Save

    private void SaveObjects()
    {
        if (BlockIndex < 0)
            return;

        var block = Safari.GetLayout(LayoutIndex).GetBlock(BlockIndex);
        byte written = 0;

        for (int i = 0; i < DGV_Objects.Rows.Count && written < SafariBlock4.ObjectCountMax; i++)
        {
            var cells = DGV_Objects.Rows[i].Cells;
            if (cells[0].Value is null)
                continue;

            var obj = block.GetObject(written);
            obj.ID = ParseObjectID(cells[0].Value);
            obj.X = ParseByte(cells[1].Value);
            obj.Y = ParseByte(cells[2].Value);
            obj.Z = ParseByte(cells[3].Value);
            written++;
        }

        // Entries past the count must stay zeroed; the game only reads obj[0..count).
        for (int i = written; i < SafariBlock4.ObjectCountMax; i++)
        {
            var obj = block.GetObject(i);
            obj.ID = obj.X = obj.Y = obj.Z = 0;
        }

        block.ObjectCount = written;

        if (!Loading)
            DGV_Blocks.Rows[BlockIndex].Cells[2].Value = written.ToString();
    }

    private void SaveLayout()
    {
        SaveObjects();
        var layout = Safari.GetLayout(LayoutIndex);

        for (int i = 0; i < SafariLayout4.BlockCount; i++)
        {
            var value = DGV_Blocks.Rows[i].Cells[1].Value?.ToString();
            var index = Array.IndexOf(AreaNames, value);
            if (index >= 0)
                layout.GetBlock(i).MapID = (SafariMap4)index;
        }

        var levels = layout.MapLevels;
        for (int i = 0; i < SafariLayout4.MapCount; i++)
            levels[i] = ParseByte(DGV_Days.Rows[i].Cells[1].Value);
    }

    private void SaveSettings()
    {
        Safari.ObjectLevel = (byte)NUD_ObjectLevel.Value;
        Safari.LevelUpDelayCount = (byte)NUD_Delay.Value;
        Safari.EventKeyTime = (ushort)NUD_EventKey.Value;
        Safari.GameLayout = (byte)Math.Max(0, CB_GameLayout.SelectedIndex);
    }

    private void SaveFriend()
    {
        var manager = Safari.Manager;
        manager.Language = (byte)SAV.Language;
        manager.IsValid = CHK_FriendValid.Checked;
        manager.Name = TB_FriendName.Text;
        manager.ID32 = uint.TryParse(TB_FriendID.Text, out var id) ? id : 0;
        manager.Gender = (byte)Math.Max(0, CB_FriendGender.SelectedIndex);
    }

    private static byte ParseByte(object? value)
    {
        var text = value?.ToString();
        if (!byte.TryParse(text, out var result))
            return 0;
        return result;
    }

    #endregion

    #region Events

    private void CB_Layout_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Loading)
            return;

        SaveLayout();
        LayoutIndex = Math.Max(0, CB_Layout.SelectedIndex);
        LoadLayout();
    }

    private void DGV_Blocks_SelectionChanged(object sender, EventArgs e)
    {
        if (Loading)
            return;

        var row = DGV_Blocks.CurrentRow;
        if (row is not null)
            LoadObjects(row.Index);
    }

    private void B_ObjectAdd_Click(object sender, EventArgs e)
    {
        if (DGV_Objects.Rows.Count >= SafariBlock4.ObjectCountMax)
            return;

        var index = DGV_Objects.Rows.Add();
        var cells = DGV_Objects.Rows[index].Cells;
        cells[0].Value = ObjectNames[1]; // default to a real object, not "None"
        for (int i = 1; i < cells.Count; i++)
            cells[i].Value = "0";
    }

    private void B_ObjectRemove_Click(object sender, EventArgs e)
    {
        var row = DGV_Objects.CurrentRow;
        if (row is not null)
            DGV_Objects.Rows.RemoveAt(row.Index);
    }

    private void B_DaysMax_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < SafariLayout4.MapCount; i++)
            DGV_Days.Rows[i].Cells[1].Value = byte.MaxValue.ToString();
    }

    private void B_DaysClear_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < SafariLayout4.MapCount; i++)
            DGV_Days.Rows[i].Cells[1].Value = "0";
    }

    private void B_FriendClear_Click(object sender, EventArgs e)
    {
        var manager = Safari.Manager;
        manager.Raw.Span.Clear();
        LoadFriend();
    }

    private void B_Cancel_Click(object sender, EventArgs e) => Close();

    private void B_Save_Click(object sender, EventArgs e)
    {
        SaveLayout();
        SaveSettings();
        SaveFriend();

        Origin.CopyChangesFrom(SAV);
        Close();
    }

    #endregion
}
