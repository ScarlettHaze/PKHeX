using PKHeX.WinForms.Controls;

namespace PKHeX.WinForms
{
    partial class SAV_Safari4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            L_Layout = new System.Windows.Forms.Label();
            CB_Layout = new System.Windows.Forms.ComboBox();
            TC_Main = new System.Windows.Forms.TabControl();
            Tab_Layout = new System.Windows.Forms.TabPage();
            DGV_Blocks = new DoubleBufferedDataGridView();
            GB_Objects = new System.Windows.Forms.GroupBox();
            DGV_Objects = new DoubleBufferedDataGridView();
            B_ObjectAdd = new System.Windows.Forms.Button();
            B_ObjectRemove = new System.Windows.Forms.Button();
            Tab_Growth = new System.Windows.Forms.TabPage();
            DGV_Days = new DoubleBufferedDataGridView();
            B_DaysMax = new System.Windows.Forms.Button();
            B_DaysClear = new System.Windows.Forms.Button();
            L_ObjectLevel = new System.Windows.Forms.Label();
            NUD_ObjectLevel = new System.Windows.Forms.NumericUpDown();
            L_Delay = new System.Windows.Forms.Label();
            NUD_Delay = new System.Windows.Forms.NumericUpDown();
            L_EventKey = new System.Windows.Forms.Label();
            NUD_EventKey = new System.Windows.Forms.NumericUpDown();
            L_GameLayout = new System.Windows.Forms.Label();
            CB_GameLayout = new System.Windows.Forms.ComboBox();
            Tab_Friend = new System.Windows.Forms.TabPage();
            CHK_FriendValid = new System.Windows.Forms.CheckBox();
            L_FriendName = new System.Windows.Forms.Label();
            TB_FriendName = new System.Windows.Forms.TextBox();
            L_FriendID = new System.Windows.Forms.Label();
            TB_FriendID = new System.Windows.Forms.TextBox();
            L_FriendGender = new System.Windows.Forms.Label();
            CB_FriendGender = new System.Windows.Forms.ComboBox();
            L_FriendMeta = new System.Windows.Forms.Label();
            B_FriendClear = new System.Windows.Forms.Button();
            B_Save = new System.Windows.Forms.Button();
            B_Cancel = new System.Windows.Forms.Button();
            TC_Main.SuspendLayout();
            Tab_Layout.SuspendLayout();
            GB_Objects.SuspendLayout();
            Tab_Growth.SuspendLayout();
            Tab_Friend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Blocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Objects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Days).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_ObjectLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Delay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_EventKey).BeginInit();
            SuspendLayout();
            // 
            // L_Layout
            // 
            L_Layout.AutoSize = true;
            L_Layout.Location = new System.Drawing.Point(14, 15);
            L_Layout.Name = "L_Layout";
            L_Layout.Size = new System.Drawing.Size(46, 15);
            L_Layout.TabIndex = 0;
            L_Layout.Text = "Layout:";
            // 
            // CB_Layout
            // 
            CB_Layout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_Layout.FormattingEnabled = true;
            CB_Layout.Location = new System.Drawing.Point(66, 11);
            CB_Layout.Name = "CB_Layout";
            CB_Layout.Size = new System.Drawing.Size(120, 23);
            CB_Layout.TabIndex = 1;
            CB_Layout.SelectedIndexChanged += CB_Layout_SelectedIndexChanged;
            // 
            // TC_Main
            // 
            TC_Main.Controls.Add(Tab_Layout);
            TC_Main.Controls.Add(Tab_Growth);
            TC_Main.Controls.Add(Tab_Friend);
            TC_Main.Location = new System.Drawing.Point(14, 42);
            TC_Main.Name = "TC_Main";
            TC_Main.SelectedIndex = 0;
            TC_Main.Size = new System.Drawing.Size(578, 300);
            TC_Main.TabIndex = 2;
            // 
            // Tab_Layout
            // 
            Tab_Layout.Controls.Add(DGV_Blocks);
            Tab_Layout.Controls.Add(GB_Objects);
            Tab_Layout.Location = new System.Drawing.Point(4, 24);
            Tab_Layout.Name = "Tab_Layout";
            Tab_Layout.Padding = new System.Windows.Forms.Padding(3);
            Tab_Layout.Size = new System.Drawing.Size(570, 272);
            Tab_Layout.TabIndex = 0;
            Tab_Layout.Text = "Layout";
            Tab_Layout.UseVisualStyleBackColor = true;
            // 
            // DGV_Blocks
            // 
            DGV_Blocks.AllowUserToAddRows = false;
            DGV_Blocks.AllowUserToDeleteRows = false;
            DGV_Blocks.AllowUserToResizeColumns = false;
            DGV_Blocks.AllowUserToResizeRows = false;
            DGV_Blocks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            DGV_Blocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Blocks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            DGV_Blocks.Location = new System.Drawing.Point(6, 6);
            DGV_Blocks.MultiSelect = false;
            DGV_Blocks.Name = "DGV_Blocks";
            DGV_Blocks.RowHeadersVisible = false;
            DGV_Blocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DGV_Blocks.ShowEditingIcon = false;
            DGV_Blocks.Size = new System.Drawing.Size(240, 258);
            DGV_Blocks.TabIndex = 0;
            DGV_Blocks.SelectionChanged += DGV_Blocks_SelectionChanged;
            // 
            // GB_Objects
            // 
            GB_Objects.Controls.Add(DGV_Objects);
            GB_Objects.Controls.Add(B_ObjectAdd);
            GB_Objects.Controls.Add(B_ObjectRemove);
            GB_Objects.Location = new System.Drawing.Point(252, 6);
            GB_Objects.Name = "GB_Objects";
            GB_Objects.Size = new System.Drawing.Size(312, 258);
            GB_Objects.TabIndex = 1;
            GB_Objects.TabStop = false;
            GB_Objects.Text = "Objects";
            // 
            // DGV_Objects
            // 
            DGV_Objects.AllowUserToAddRows = false;
            DGV_Objects.AllowUserToDeleteRows = false;
            DGV_Objects.AllowUserToResizeColumns = false;
            DGV_Objects.AllowUserToResizeRows = false;
            DGV_Objects.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            DGV_Objects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Objects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            DGV_Objects.Location = new System.Drawing.Point(6, 22);
            DGV_Objects.MultiSelect = false;
            DGV_Objects.Name = "DGV_Objects";
            DGV_Objects.RowHeadersVisible = false;
            DGV_Objects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            DGV_Objects.ShowEditingIcon = false;
            DGV_Objects.Size = new System.Drawing.Size(300, 196);
            DGV_Objects.TabIndex = 0;
            // 
            // B_ObjectAdd
            // 
            B_ObjectAdd.Location = new System.Drawing.Point(6, 224);
            B_ObjectAdd.Name = "B_ObjectAdd";
            B_ObjectAdd.Size = new System.Drawing.Size(88, 27);
            B_ObjectAdd.TabIndex = 1;
            B_ObjectAdd.Text = "Add";
            B_ObjectAdd.UseVisualStyleBackColor = true;
            B_ObjectAdd.Click += B_ObjectAdd_Click;
            // 
            // B_ObjectRemove
            // 
            B_ObjectRemove.Location = new System.Drawing.Point(102, 224);
            B_ObjectRemove.Name = "B_ObjectRemove";
            B_ObjectRemove.Size = new System.Drawing.Size(88, 27);
            B_ObjectRemove.TabIndex = 2;
            B_ObjectRemove.Text = "Remove";
            B_ObjectRemove.UseVisualStyleBackColor = true;
            B_ObjectRemove.Click += B_ObjectRemove_Click;
            // 
            // Tab_Growth
            // 
            Tab_Growth.Controls.Add(DGV_Days);
            Tab_Growth.Controls.Add(B_DaysMax);
            Tab_Growth.Controls.Add(B_DaysClear);
            Tab_Growth.Controls.Add(L_ObjectLevel);
            Tab_Growth.Controls.Add(NUD_ObjectLevel);
            Tab_Growth.Controls.Add(L_Delay);
            Tab_Growth.Controls.Add(NUD_Delay);
            Tab_Growth.Controls.Add(L_EventKey);
            Tab_Growth.Controls.Add(NUD_EventKey);
            Tab_Growth.Controls.Add(L_GameLayout);
            Tab_Growth.Controls.Add(CB_GameLayout);
            Tab_Growth.Location = new System.Drawing.Point(4, 24);
            Tab_Growth.Name = "Tab_Growth";
            Tab_Growth.Padding = new System.Windows.Forms.Padding(3);
            Tab_Growth.Size = new System.Drawing.Size(570, 272);
            Tab_Growth.TabIndex = 1;
            Tab_Growth.Text = "Growth";
            Tab_Growth.UseVisualStyleBackColor = true;
            // 
            // DGV_Days
            // 
            DGV_Days.AllowUserToAddRows = false;
            DGV_Days.AllowUserToDeleteRows = false;
            DGV_Days.AllowUserToResizeColumns = false;
            DGV_Days.AllowUserToResizeRows = false;
            DGV_Days.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            DGV_Days.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Days.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            DGV_Days.Location = new System.Drawing.Point(6, 6);
            DGV_Days.MultiSelect = false;
            DGV_Days.Name = "DGV_Days";
            DGV_Days.RowHeadersVisible = false;
            DGV_Days.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            DGV_Days.ShowEditingIcon = false;
            DGV_Days.Size = new System.Drawing.Size(200, 220);
            DGV_Days.TabIndex = 0;
            // 
            // B_DaysMax
            // 
            B_DaysMax.Location = new System.Drawing.Point(6, 232);
            B_DaysMax.Name = "B_DaysMax";
            B_DaysMax.Size = new System.Drawing.Size(96, 27);
            B_DaysMax.TabIndex = 1;
            B_DaysMax.Text = "Max All";
            B_DaysMax.UseVisualStyleBackColor = true;
            B_DaysMax.Click += B_DaysMax_Click;
            // 
            // B_DaysClear
            // 
            B_DaysClear.Location = new System.Drawing.Point(110, 232);
            B_DaysClear.Name = "B_DaysClear";
            B_DaysClear.Size = new System.Drawing.Size(96, 27);
            B_DaysClear.TabIndex = 2;
            B_DaysClear.Text = "Clear All";
            B_DaysClear.UseVisualStyleBackColor = true;
            B_DaysClear.Click += B_DaysClear_Click;
            // 
            // L_ObjectLevel
            // 
            L_ObjectLevel.AutoSize = true;
            L_ObjectLevel.Location = new System.Drawing.Point(222, 14);
            L_ObjectLevel.Name = "L_ObjectLevel";
            L_ObjectLevel.Size = new System.Drawing.Size(76, 15);
            L_ObjectLevel.TabIndex = 3;
            L_ObjectLevel.Text = "Object Level:";
            // 
            // NUD_ObjectLevel
            // 
            NUD_ObjectLevel.Location = new System.Drawing.Point(340, 10);
            NUD_ObjectLevel.Maximum = new decimal(new int[] { 63, 0, 0, 0 });
            NUD_ObjectLevel.Name = "NUD_ObjectLevel";
            NUD_ObjectLevel.Size = new System.Drawing.Size(96, 23);
            NUD_ObjectLevel.TabIndex = 4;
            // 
            // L_Delay
            // 
            L_Delay.AutoSize = true;
            L_Delay.Location = new System.Drawing.Point(222, 46);
            L_Delay.Name = "L_Delay";
            L_Delay.Size = new System.Drawing.Size(106, 15);
            L_Delay.TabIndex = 5;
            L_Delay.Text = "Level Up Delay:";
            // 
            // NUD_Delay
            // 
            NUD_Delay.Location = new System.Drawing.Point(340, 42);
            NUD_Delay.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NUD_Delay.Name = "NUD_Delay";
            NUD_Delay.Size = new System.Drawing.Size(96, 23);
            NUD_Delay.TabIndex = 6;
            // 
            // L_EventKey
            // 
            L_EventKey.AutoSize = true;
            L_EventKey.Location = new System.Drawing.Point(222, 78);
            L_EventKey.Name = "L_EventKey";
            L_EventKey.Size = new System.Drawing.Size(112, 15);
            L_EventKey.TabIndex = 7;
            L_EventKey.Text = "Event Key (min):";
            // 
            // NUD_EventKey
            // 
            NUD_EventKey.Location = new System.Drawing.Point(340, 74);
            NUD_EventKey.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            NUD_EventKey.Name = "NUD_EventKey";
            NUD_EventKey.Size = new System.Drawing.Size(96, 23);
            NUD_EventKey.TabIndex = 8;
            // 
            // L_GameLayout
            // 
            L_GameLayout.AutoSize = true;
            L_GameLayout.Location = new System.Drawing.Point(222, 110);
            L_GameLayout.Name = "L_GameLayout";
            L_GameLayout.Size = new System.Drawing.Size(86, 15);
            L_GameLayout.TabIndex = 9;
            L_GameLayout.Text = "Active Layout:";
            // 
            // CB_GameLayout
            // 
            CB_GameLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_GameLayout.FormattingEnabled = true;
            CB_GameLayout.Location = new System.Drawing.Point(340, 106);
            CB_GameLayout.Name = "CB_GameLayout";
            CB_GameLayout.Size = new System.Drawing.Size(96, 23);
            CB_GameLayout.TabIndex = 10;
            // 
            // Tab_Friend
            // 
            Tab_Friend.Controls.Add(CHK_FriendValid);
            Tab_Friend.Controls.Add(L_FriendName);
            Tab_Friend.Controls.Add(TB_FriendName);
            Tab_Friend.Controls.Add(L_FriendID);
            Tab_Friend.Controls.Add(TB_FriendID);
            Tab_Friend.Controls.Add(L_FriendGender);
            Tab_Friend.Controls.Add(CB_FriendGender);
            Tab_Friend.Controls.Add(L_FriendMeta);
            Tab_Friend.Controls.Add(B_FriendClear);
            Tab_Friend.Location = new System.Drawing.Point(4, 24);
            Tab_Friend.Name = "Tab_Friend";
            Tab_Friend.Padding = new System.Windows.Forms.Padding(3);
            Tab_Friend.Size = new System.Drawing.Size(570, 272);
            Tab_Friend.TabIndex = 2;
            Tab_Friend.Text = "Friend";
            Tab_Friend.UseVisualStyleBackColor = true;
            // 
            // CHK_FriendValid
            // 
            CHK_FriendValid.AutoSize = true;
            CHK_FriendValid.Location = new System.Drawing.Point(18, 18);
            CHK_FriendValid.Name = "CHK_FriendValid";
            CHK_FriendValid.Size = new System.Drawing.Size(112, 19);
            CHK_FriendValid.TabIndex = 0;
            CHK_FriendValid.Text = "Data Valid";
            CHK_FriendValid.UseVisualStyleBackColor = true;
            // 
            // L_FriendName
            // 
            L_FriendName.AutoSize = true;
            L_FriendName.Location = new System.Drawing.Point(18, 52);
            L_FriendName.Name = "L_FriendName";
            L_FriendName.Size = new System.Drawing.Size(42, 15);
            L_FriendName.TabIndex = 1;
            L_FriendName.Text = "Name:";
            // 
            // TB_FriendName
            // 
            TB_FriendName.Location = new System.Drawing.Point(120, 48);
            TB_FriendName.MaxLength = 7;
            TB_FriendName.Name = "TB_FriendName";
            TB_FriendName.Size = new System.Drawing.Size(140, 23);
            TB_FriendName.TabIndex = 2;
            // 
            // L_FriendID
            // 
            L_FriendID.AutoSize = true;
            L_FriendID.Location = new System.Drawing.Point(18, 84);
            L_FriendID.Name = "L_FriendID";
            L_FriendID.Size = new System.Drawing.Size(21, 15);
            L_FriendID.TabIndex = 3;
            L_FriendID.Text = "ID:";
            // 
            // TB_FriendID
            // 
            TB_FriendID.Location = new System.Drawing.Point(120, 80);
            TB_FriendID.MaxLength = 10;
            TB_FriendID.Name = "TB_FriendID";
            TB_FriendID.Size = new System.Drawing.Size(140, 23);
            TB_FriendID.TabIndex = 4;
            // 
            // L_FriendGender
            // 
            L_FriendGender.AutoSize = true;
            L_FriendGender.Location = new System.Drawing.Point(18, 116);
            L_FriendGender.Name = "L_FriendGender";
            L_FriendGender.Size = new System.Drawing.Size(51, 15);
            L_FriendGender.TabIndex = 5;
            L_FriendGender.Text = "Gender:";
            // 
            // CB_FriendGender
            // 
            CB_FriendGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_FriendGender.FormattingEnabled = true;
            CB_FriendGender.Location = new System.Drawing.Point(120, 112);
            CB_FriendGender.Name = "CB_FriendGender";
            CB_FriendGender.Size = new System.Drawing.Size(140, 23);
            CB_FriendGender.TabIndex = 6;
            // 
            // L_FriendMeta
            // 
            L_FriendMeta.AutoSize = true;
            L_FriendMeta.Location = new System.Drawing.Point(18, 156);
            L_FriendMeta.Name = "L_FriendMeta";
            L_FriendMeta.Size = new System.Drawing.Size(0, 15);
            L_FriendMeta.TabIndex = 7;
            // 
            // B_FriendClear
            // 
            B_FriendClear.Location = new System.Drawing.Point(18, 188);
            B_FriendClear.Name = "B_FriendClear";
            B_FriendClear.Size = new System.Drawing.Size(140, 27);
            B_FriendClear.TabIndex = 8;
            B_FriendClear.Text = "Clear Friend Data";
            B_FriendClear.UseVisualStyleBackColor = true;
            B_FriendClear.Click += B_FriendClear_Click;
            // 
            // B_Save
            // 
            B_Save.Location = new System.Drawing.Point(479, 350);
            B_Save.Name = "B_Save";
            B_Save.Size = new System.Drawing.Size(113, 27);
            B_Save.TabIndex = 3;
            B_Save.Text = "Save";
            B_Save.UseVisualStyleBackColor = true;
            B_Save.Click += B_Save_Click;
            // 
            // B_Cancel
            // 
            B_Cancel.Location = new System.Drawing.Point(359, 350);
            B_Cancel.Name = "B_Cancel";
            B_Cancel.Size = new System.Drawing.Size(113, 27);
            B_Cancel.TabIndex = 4;
            B_Cancel.Text = "Cancel";
            B_Cancel.UseVisualStyleBackColor = true;
            B_Cancel.Click += B_Cancel_Click;
            // 
            // SAV_Safari4
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            ClientSize = new System.Drawing.Size(606, 390);
            Controls.Add(B_Cancel);
            Controls.Add(B_Save);
            Controls.Add(TC_Main);
            Controls.Add(CB_Layout);
            Controls.Add(L_Layout);
            Icon = Properties.Resources.Icon;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SAV_Safari4";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Safari Zone Editor";
            TC_Main.ResumeLayout(false);
            Tab_Layout.ResumeLayout(false);
            GB_Objects.ResumeLayout(false);
            Tab_Growth.ResumeLayout(false);
            Tab_Growth.PerformLayout();
            Tab_Friend.ResumeLayout(false);
            Tab_Friend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Blocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Objects).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Days).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_ObjectLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Delay).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_EventKey).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label L_Layout;
        private System.Windows.Forms.ComboBox CB_Layout;
        private System.Windows.Forms.TabControl TC_Main;
        private System.Windows.Forms.TabPage Tab_Layout;
        private DoubleBufferedDataGridView DGV_Blocks;
        private System.Windows.Forms.GroupBox GB_Objects;
        private DoubleBufferedDataGridView DGV_Objects;
        private System.Windows.Forms.Button B_ObjectAdd;
        private System.Windows.Forms.Button B_ObjectRemove;
        private System.Windows.Forms.TabPage Tab_Growth;
        private DoubleBufferedDataGridView DGV_Days;
        private System.Windows.Forms.Button B_DaysMax;
        private System.Windows.Forms.Button B_DaysClear;
        private System.Windows.Forms.Label L_ObjectLevel;
        private System.Windows.Forms.NumericUpDown NUD_ObjectLevel;
        private System.Windows.Forms.Label L_Delay;
        private System.Windows.Forms.NumericUpDown NUD_Delay;
        private System.Windows.Forms.Label L_EventKey;
        private System.Windows.Forms.NumericUpDown NUD_EventKey;
        private System.Windows.Forms.Label L_GameLayout;
        private System.Windows.Forms.ComboBox CB_GameLayout;
        private System.Windows.Forms.TabPage Tab_Friend;
        private System.Windows.Forms.CheckBox CHK_FriendValid;
        private System.Windows.Forms.Label L_FriendName;
        private System.Windows.Forms.TextBox TB_FriendName;
        private System.Windows.Forms.Label L_FriendID;
        private System.Windows.Forms.TextBox TB_FriendID;
        private System.Windows.Forms.Label L_FriendGender;
        private System.Windows.Forms.ComboBox CB_FriendGender;
        private System.Windows.Forms.Label L_FriendMeta;
        private System.Windows.Forms.Button B_FriendClear;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Cancel;
    }
}
