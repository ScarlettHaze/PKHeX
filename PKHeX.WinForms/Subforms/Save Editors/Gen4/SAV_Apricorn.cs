using System;
using System.Windows.Forms;
using PKHeX.Core;

namespace PKHeX.WinForms;

public partial class SAV_Apricorn : Form
{
    public SAV_Apricorn(SAV4HGSS sav)
    {
        InitializeComponent();
        WinFormsUtil.TranslateInterface(this, Main.CurrentLanguage);
        SAV = (SAV4HGSS)(Origin = sav).Clone();

        Setup();
    }

    private readonly SAV4HGSS Origin;
    private readonly SAV4HGSS SAV;
    private const int Count = 7;
    private const int ItemNameBase = 485; // Red Apricorn

    private static ReadOnlySpan<byte> ItemNameOffset =>
    [
        0, // 485: Red
        2, // 487: Yellow - out of order
        1, // 486: Blue - out of order
        3, // 488: Green
        4, // 489: Pink
        5, // 490: White
        6, // 491: Black
    ];

    private readonly ComboBox[] CB_Stock = new ComboBox[ApricornJuice4.HopperSlotCount];
    private readonly NumericUpDown[] NUD_Batch = new NumericUpDown[ApricornJuice4.TasteSlotCount];

    private static readonly string[] HopperColorNames = ["Red", "Yellow", "Blue", "Green", "Pink", "White", "Black", "(Empty)"];

    private void Setup()
    {
        dgv.Rows.Clear();
        dgv.Columns.Clear();

        DataGridViewColumn dgvApricorn = new DataGridViewTextBoxColumn();
        {
            dgvApricorn.HeaderText = "Slot";
            dgvApricorn.DisplayIndex = 0;
            dgvApricorn.Width = 135;
            dgvApricorn.ReadOnly = true;
            dgvApricorn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        DataGridViewTextBoxColumn dgvCount = new()
        {
            DisplayIndex = 1,
            Width = 45,
        };
        dgv.Columns.Add(dgvApricorn);
        dgv.Columns.Add(dgvCount);

        dgv.Rows.Add(Count);
        var itemNames = GameInfo.Strings.itemlist;
        for (int i = 0; i < Count; i++)
        {
            var itemId = ItemNameBase + ItemNameOffset[i];
            dgv.Rows[i].Cells[0].Value = itemNames[itemId];
        }
        LoadCount();
        LoadKurtDeposit();

        SetupHopperRows(FLP_Stock, CB_Stock);
        SetupJuiceRows(FLP_Batch, NUD_Batch, ApricornJuice4.MaxTaste);
        LoadJuice();
    }

    private static void SetupHopperRows(FlowLayoutPanel host, ComboBox[] slots)
    {
        host.Controls.Clear();
        for (int i = 0; i < slots.Length; i++)
        {
            var row = new Panel { Size = new System.Drawing.Size(host.Width - 4, 24), Margin = new Padding(0, 0, 0, 2) };
            var label = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 4),
                Text = $"Slot {i + 1}:",
            };
            var cb = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new System.Drawing.Point(90, 0),
                Size = new System.Drawing.Size(90, 23),
            };
            cb.Items.AddRange(HopperColorNames);
            row.Controls.Add(label);
            row.Controls.Add(cb);
            host.Controls.Add(row);
            slots[i] = cb;
        }
    }

    private static void SetupJuiceRows(FlowLayoutPanel host, NumericUpDown[] slots, byte max)
    {
        host.Controls.Clear();
        for (int i = 0; i < slots.Length; i++)
        {
            var flavor = (ApricornJuiceFlavor4)i;
            var row = new Panel { Size = new System.Drawing.Size(host.Width - 4, 24), Margin = new Padding(0, 0, 0, 2) };
            var label = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(0, 4),
                Text = $"{flavor}:",
            };
            var nud = new NumericUpDown
            {
                Location = new System.Drawing.Point(90, 0),
                Size = new System.Drawing.Size(70, 23),
                Maximum = max,
            };
            row.Controls.Add(label);
            row.Controls.Add(nud);
            host.Controls.Add(row);
            slots[i] = nud;
        }
    }

    private void LoadCount()
    {
        for (int i = 0; i < Count; i++)
            dgv.Rows[i].Cells[1].Value = SAV.GetApricornCount(i).ToString();
    }

    private void LoadKurtDeposit()
    {
        NUD_KurtCount.Value = Math.Clamp((decimal)SAV.ApricornKurtDepositCount, NUD_KurtCount.Minimum, NUD_KurtCount.Maximum);
        var color = SAV.ApricornKurtDepositColor;
        CB_KurtColor.SelectedIndex = Enum.IsDefined(color) ? (int)color : 0;
    }

    private void LoadJuice()
    {
        var juice = SAV.ApricornJuice;
        NUD_JuiceRest.Value = juice.JuiceRest;
        CHK_HasStock.Checked = juice.HasStock;
        for (int i = 0; i < ApricornJuice4.HopperSlotCount; i++)
            CB_Stock[i].SelectedIndex = juice.GetHopperColor(i);
        for (int i = 0; i < ApricornJuice4.TasteSlotCount; i++)
            NUD_Batch[i].Value = juice.GetJuiceTaste(i);
        NUD_StepsUntilDone.Value = juice.StepsUntilDone;
        NUD_MildnessCount.Value = juice.MildnessCount;
        NUD_BrewStartStepCount.Value = juice.BrewStartStepCount;
        var startup = juice.StartupMessage;
        CB_StartupFlag.SelectedIndex = Enum.IsDefined(startup) ? (int)startup : 0;
    }

    private void B_Cancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void B_All_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < Count; i++)
            SAV.SetApricornCount(i, 99);
        LoadCount();
    }

    private void B_None_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < Count; i++)
            SAV.SetApricornCount(i, 0);
        LoadCount();
    }

    private void B_Save_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < Count; i++)
        {
            var cells = dgv.Rows[i].Cells;
            var count = int.TryParse(cells[1].Value?.ToString() ?? "0", out var val) ? val : 0;
            SAV.SetApricornCount(i, Math.Min(byte.MaxValue, count));
        }
        SAV.ApricornKurtDepositCount = (byte)NUD_KurtCount.Value;
        SAV.ApricornKurtDepositColor = (Apricorn4Color)CB_KurtColor.SelectedIndex;

        var juice = SAV.ApricornJuice;
        juice.JuiceRest = (byte)NUD_JuiceRest.Value;
        juice.HasStock = CHK_HasStock.Checked;
        for (int i = 0; i < ApricornJuice4.HopperSlotCount; i++)
            juice.SetHopperColor(i, (byte)CB_Stock[i].SelectedIndex);
        for (int i = 0; i < ApricornJuice4.TasteSlotCount; i++)
            juice.SetJuiceTaste(i, (byte)NUD_Batch[i].Value);
        juice.StepsUntilDone = (uint)NUD_StepsUntilDone.Value;
        juice.MildnessCount = (uint)NUD_MildnessCount.Value;
        juice.BrewStartStepCount = (uint)NUD_BrewStartStepCount.Value;
        juice.StartupMessage = (ApricornJuiceStartupMessage4)CB_StartupFlag.SelectedIndex;

        Origin.CopyChangesFrom(SAV);
        Close();
    }
}
