using PKHeX.WinForms.Controls;

namespace PKHeX.WinForms
{
    partial class SAV_Apricorn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TC_Main = new System.Windows.Forms.TabControl();
            Tab_Pouch = new System.Windows.Forms.TabPage();
            dgv = new DoubleBufferedDataGridView();
            GB_Kurt = new System.Windows.Forms.GroupBox();
            L_KurtCount = new System.Windows.Forms.Label();
            NUD_KurtCount = new System.Windows.Forms.NumericUpDown();
            L_KurtColor = new System.Windows.Forms.Label();
            CB_KurtColor = new System.Windows.Forms.ComboBox();
            B_All = new System.Windows.Forms.Button();
            B_None = new System.Windows.Forms.Button();
            Tab_Juice = new System.Windows.Forms.TabPage();
            L_JuiceRest = new System.Windows.Forms.Label();
            NUD_JuiceRest = new System.Windows.Forms.NumericUpDown();
            CHK_HasStock = new System.Windows.Forms.CheckBox();
            GB_Stock = new System.Windows.Forms.GroupBox();
            FLP_Stock = new System.Windows.Forms.FlowLayoutPanel();
            GB_Batch = new System.Windows.Forms.GroupBox();
            FLP_Batch = new System.Windows.Forms.FlowLayoutPanel();
            L_StepsUntilDone = new System.Windows.Forms.Label();
            NUD_StepsUntilDone = new System.Windows.Forms.NumericUpDown();
            L_MildnessCount = new System.Windows.Forms.Label();
            NUD_MildnessCount = new System.Windows.Forms.NumericUpDown();
            L_BrewStartStepCount = new System.Windows.Forms.Label();
            NUD_BrewStartStepCount = new System.Windows.Forms.NumericUpDown();
            L_StartupFlag = new System.Windows.Forms.Label();
            CB_StartupFlag = new System.Windows.Forms.ComboBox();
            B_Save = new System.Windows.Forms.Button();
            B_Cancel = new System.Windows.Forms.Button();
            TC_Main.SuspendLayout();
            Tab_Pouch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            GB_Kurt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_KurtCount).BeginInit();
            Tab_Juice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_JuiceRest).BeginInit();
            GB_Stock.SuspendLayout();
            GB_Batch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_StepsUntilDone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_MildnessCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_BrewStartStepCount).BeginInit();
            SuspendLayout();
            //
            // TC_Main
            //
            TC_Main.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TC_Main.Controls.Add(Tab_Pouch);
            TC_Main.Controls.Add(Tab_Juice);
            TC_Main.Location = new System.Drawing.Point(12, 12);
            TC_Main.Name = "TC_Main";
            TC_Main.SelectedIndex = 0;
            TC_Main.Size = new System.Drawing.Size(296, 516);
            TC_Main.TabIndex = 0;
            //
            // Tab_Pouch
            //
            Tab_Pouch.Controls.Add(dgv);
            Tab_Pouch.Controls.Add(GB_Kurt);
            Tab_Pouch.Controls.Add(B_All);
            Tab_Pouch.Controls.Add(B_None);
            Tab_Pouch.Location = new System.Drawing.Point(4, 24);
            Tab_Pouch.Name = "Tab_Pouch";
            Tab_Pouch.Padding = new System.Windows.Forms.Padding(3);
            Tab_Pouch.Size = new System.Drawing.Size(288, 488);
            Tab_Pouch.TabIndex = 0;
            Tab_Pouch.Text = "Pouch";
            Tab_Pouch.UseVisualStyleBackColor = true;
            //
            // dgv
            //
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ColumnHeadersVisible = false;
            dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            dgv.Location = new System.Drawing.Point(6, 38);
            dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dgv.ShowEditingIcon = false;
            dgv.Size = new System.Drawing.Size(276, 196);
            dgv.TabIndex = 11;
            //
            // GB_Kurt
            //
            GB_Kurt.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            GB_Kurt.Controls.Add(L_KurtCount);
            GB_Kurt.Controls.Add(NUD_KurtCount);
            GB_Kurt.Controls.Add(L_KurtColor);
            GB_Kurt.Controls.Add(CB_KurtColor);
            GB_Kurt.Location = new System.Drawing.Point(6, 240);
            GB_Kurt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GB_Kurt.Name = "GB_Kurt";
            GB_Kurt.Size = new System.Drawing.Size(276, 68);
            GB_Kurt.TabIndex = 17;
            GB_Kurt.TabStop = false;
            GB_Kurt.Text = "Deposited with Kurt";
            //
            // L_KurtCount
            //
            L_KurtCount.AutoSize = true;
            L_KurtCount.Location = new System.Drawing.Point(10, 25);
            L_KurtCount.Name = "L_KurtCount";
            L_KurtCount.Size = new System.Drawing.Size(40, 15);
            L_KurtCount.TabIndex = 0;
            L_KurtCount.Text = "Count:";
            //
            // NUD_KurtCount
            //
            NUD_KurtCount.Location = new System.Drawing.Point(56, 23);
            NUD_KurtCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NUD_KurtCount.Name = "NUD_KurtCount";
            NUD_KurtCount.Size = new System.Drawing.Size(50, 23);
            NUD_KurtCount.TabIndex = 1;
            //
            // L_KurtColor
            //
            L_KurtColor.AutoSize = true;
            L_KurtColor.Location = new System.Drawing.Point(118, 25);
            L_KurtColor.Name = "L_KurtColor";
            L_KurtColor.Size = new System.Drawing.Size(40, 15);
            L_KurtColor.TabIndex = 2;
            L_KurtColor.Text = "Color:";
            //
            // CB_KurtColor
            //
            CB_KurtColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_KurtColor.FormattingEnabled = true;
            CB_KurtColor.Items.AddRange(new object[] { "Red", "Yellow", "Blue", "Green", "Pink", "White", "Black" });
            CB_KurtColor.Location = new System.Drawing.Point(160, 23);
            CB_KurtColor.Name = "CB_KurtColor";
            CB_KurtColor.Size = new System.Drawing.Size(63, 23);
            CB_KurtColor.TabIndex = 3;
            //
            // B_All
            //
            B_All.Location = new System.Drawing.Point(6, 6);
            B_All.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_All.Name = "B_All";
            B_All.Size = new System.Drawing.Size(133, 27);
            B_All.TabIndex = 14;
            B_All.Text = "All";
            B_All.UseVisualStyleBackColor = true;
            B_All.Click += B_All_Click;
            //
            // B_None
            //
            B_None.Location = new System.Drawing.Point(149, 6);
            B_None.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_None.Name = "B_None";
            B_None.Size = new System.Drawing.Size(133, 27);
            B_None.TabIndex = 16;
            B_None.Text = "None";
            B_None.UseVisualStyleBackColor = true;
            B_None.Click += B_None_Click;
            //
            // Tab_Juice
            //
            Tab_Juice.Controls.Add(L_JuiceRest);
            Tab_Juice.Controls.Add(NUD_JuiceRest);
            Tab_Juice.Controls.Add(CHK_HasStock);
            Tab_Juice.Controls.Add(GB_Stock);
            Tab_Juice.Controls.Add(GB_Batch);
            Tab_Juice.Controls.Add(L_StepsUntilDone);
            Tab_Juice.Controls.Add(NUD_StepsUntilDone);
            Tab_Juice.Controls.Add(L_MildnessCount);
            Tab_Juice.Controls.Add(NUD_MildnessCount);
            Tab_Juice.Controls.Add(L_BrewStartStepCount);
            Tab_Juice.Controls.Add(NUD_BrewStartStepCount);
            Tab_Juice.Controls.Add(L_StartupFlag);
            Tab_Juice.Controls.Add(CB_StartupFlag);
            Tab_Juice.Location = new System.Drawing.Point(4, 24);
            Tab_Juice.Name = "Tab_Juice";
            Tab_Juice.Padding = new System.Windows.Forms.Padding(3);
            Tab_Juice.Size = new System.Drawing.Size(288, 488);
            Tab_Juice.TabIndex = 1;
            Tab_Juice.Text = "Juice";
            Tab_Juice.UseVisualStyleBackColor = true;
            //
            // L_JuiceRest
            //
            L_JuiceRest.AutoSize = true;
            L_JuiceRest.Location = new System.Drawing.Point(6, 10);
            L_JuiceRest.Name = "L_JuiceRest";
            L_JuiceRest.Size = new System.Drawing.Size(110, 15);
            L_JuiceRest.TabIndex = 0;
            L_JuiceRest.Text = "Servings Left:";
            //
            // NUD_JuiceRest
            //
            NUD_JuiceRest.Location = new System.Drawing.Point(150, 8);
            NUD_JuiceRest.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NUD_JuiceRest.Name = "NUD_JuiceRest";
            NUD_JuiceRest.Size = new System.Drawing.Size(70, 23);
            NUD_JuiceRest.TabIndex = 1;
            //
            // CHK_HasStock
            //
            CHK_HasStock.AutoSize = true;
            CHK_HasStock.Location = new System.Drawing.Point(6, 37);
            CHK_HasStock.Name = "CHK_HasStock";
            CHK_HasStock.Size = new System.Drawing.Size(130, 19);
            CHK_HasStock.TabIndex = 2;
            CHK_HasStock.Text = "Has Stocked Juice";
            CHK_HasStock.UseVisualStyleBackColor = true;
            //
            // GB_Stock
            //
            GB_Stock.Controls.Add(FLP_Stock);
            GB_Stock.Location = new System.Drawing.Point(6, 62);
            GB_Stock.Name = "GB_Stock";
            GB_Stock.Size = new System.Drawing.Size(276, 150);
            GB_Stock.TabIndex = 3;
            GB_Stock.TabStop = false;
            GB_Stock.Text = "Stock (bottled juices)";
            //
            // FLP_Stock
            //
            FLP_Stock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            FLP_Stock.Location = new System.Drawing.Point(6, 20);
            FLP_Stock.Name = "FLP_Stock";
            FLP_Stock.Size = new System.Drawing.Size(264, 124);
            FLP_Stock.TabIndex = 0;
            FLP_Stock.WrapContents = false;
            //
            // GB_Batch
            //
            GB_Batch.Controls.Add(FLP_Batch);
            GB_Batch.Location = new System.Drawing.Point(6, 218);
            GB_Batch.Name = "GB_Batch";
            GB_Batch.Size = new System.Drawing.Size(276, 150);
            GB_Batch.TabIndex = 4;
            GB_Batch.TabStop = false;
            GB_Batch.Text = "Current Batch (taste, 0-63)";
            //
            // FLP_Batch
            //
            FLP_Batch.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            FLP_Batch.Location = new System.Drawing.Point(6, 20);
            FLP_Batch.Name = "FLP_Batch";
            FLP_Batch.Size = new System.Drawing.Size(264, 124);
            FLP_Batch.TabIndex = 0;
            FLP_Batch.WrapContents = false;
            //
            // L_StepsUntilDone
            //
            L_StepsUntilDone.AutoSize = true;
            L_StepsUntilDone.Location = new System.Drawing.Point(6, 376);
            L_StepsUntilDone.Name = "L_StepsUntilDone";
            L_StepsUntilDone.Size = new System.Drawing.Size(140, 15);
            L_StepsUntilDone.TabIndex = 5;
            L_StepsUntilDone.Text = "Steps Until Done:";
            //
            // NUD_StepsUntilDone
            //
            NUD_StepsUntilDone.Location = new System.Drawing.Point(150, 373);
            NUD_StepsUntilDone.Maximum = new decimal(new int[] { 1073741823, 0, 0, 0 });
            NUD_StepsUntilDone.Name = "NUD_StepsUntilDone";
            NUD_StepsUntilDone.Size = new System.Drawing.Size(120, 23);
            NUD_StepsUntilDone.TabIndex = 6;
            //
            // L_MildnessCount
            //
            L_MildnessCount.AutoSize = true;
            L_MildnessCount.Location = new System.Drawing.Point(6, 402);
            L_MildnessCount.Name = "L_MildnessCount";
            L_MildnessCount.Size = new System.Drawing.Size(140, 15);
            L_MildnessCount.TabIndex = 7;
            L_MildnessCount.Text = "Mildness Count:";
            //
            // NUD_MildnessCount
            //
            NUD_MildnessCount.Location = new System.Drawing.Point(150, 399);
            NUD_MildnessCount.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            NUD_MildnessCount.Name = "NUD_MildnessCount";
            NUD_MildnessCount.Size = new System.Drawing.Size(120, 23);
            NUD_MildnessCount.TabIndex = 8;
            //
            // L_BrewStartStepCount
            //
            L_BrewStartStepCount.AutoSize = true;
            L_BrewStartStepCount.Location = new System.Drawing.Point(6, 428);
            L_BrewStartStepCount.Name = "L_BrewStartStepCount";
            L_BrewStartStepCount.Size = new System.Drawing.Size(140, 15);
            L_BrewStartStepCount.TabIndex = 9;
            L_BrewStartStepCount.Text = "Brew Start Steps:";
            //
            // NUD_BrewStartStepCount
            //
            NUD_BrewStartStepCount.Location = new System.Drawing.Point(150, 425);
            NUD_BrewStartStepCount.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            NUD_BrewStartStepCount.Name = "NUD_BrewStartStepCount";
            NUD_BrewStartStepCount.Size = new System.Drawing.Size(120, 23);
            NUD_BrewStartStepCount.TabIndex = 10;
            //
            // L_StartupFlag
            //
            L_StartupFlag.AutoSize = true;
            L_StartupFlag.Location = new System.Drawing.Point(6, 454);
            L_StartupFlag.Name = "L_StartupFlag";
            L_StartupFlag.Size = new System.Drawing.Size(140, 15);
            L_StartupFlag.TabIndex = 11;
            L_StartupFlag.Text = "Startup Message Flag:";
            //
            // CB_StartupFlag
            //
            CB_StartupFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB_StartupFlag.FormattingEnabled = true;
            CB_StartupFlag.Items.AddRange(new object[] { "First Time", "None", "New", "Update" });
            CB_StartupFlag.Location = new System.Drawing.Point(150, 451);
            CB_StartupFlag.Name = "CB_StartupFlag";
            CB_StartupFlag.Size = new System.Drawing.Size(120, 23);
            CB_StartupFlag.TabIndex = 12;
            //
            // B_Save
            //
            B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            B_Save.Location = new System.Drawing.Point(155, 536);
            B_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_Save.Name = "B_Save";
            B_Save.Size = new System.Drawing.Size(113, 27);
            B_Save.TabIndex = 12;
            B_Save.Text = "Save";
            B_Save.UseVisualStyleBackColor = true;
            B_Save.Click += B_Save_Click;
            //
            // B_Cancel
            //
            B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            B_Cancel.Location = new System.Drawing.Point(34, 536);
            B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_Cancel.Name = "B_Cancel";
            B_Cancel.Size = new System.Drawing.Size(113, 27);
            B_Cancel.TabIndex = 13;
            B_Cancel.Text = "Cancel";
            B_Cancel.UseVisualStyleBackColor = true;
            B_Cancel.Click += B_Cancel_Click;
            //
            // SAV_Apricorn
            //
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            ClientSize = new System.Drawing.Size(320, 576);
            Controls.Add(B_Cancel);
            Controls.Add(B_Save);
            Controls.Add(TC_Main);
            Icon = Properties.Resources.Icon;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(336, 1121);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(336, 602);
            Name = "SAV_Apricorn";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Apricorn Editor";
            TC_Main.ResumeLayout(false);
            Tab_Pouch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            GB_Kurt.ResumeLayout(false);
            GB_Kurt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_KurtCount).EndInit();
            Tab_Juice.ResumeLayout(false);
            Tab_Juice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_JuiceRest).EndInit();
            GB_Stock.ResumeLayout(false);
            GB_Batch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NUD_StepsUntilDone).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_MildnessCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_BrewStartStepCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl TC_Main;
        private System.Windows.Forms.TabPage Tab_Pouch;
        private DoubleBufferedDataGridView dgv;
        private System.Windows.Forms.GroupBox GB_Kurt;
        private System.Windows.Forms.Label L_KurtCount;
        private System.Windows.Forms.NumericUpDown NUD_KurtCount;
        private System.Windows.Forms.Label L_KurtColor;
        private System.Windows.Forms.ComboBox CB_KurtColor;
        private System.Windows.Forms.Button B_All;
        private System.Windows.Forms.Button B_None;
        private System.Windows.Forms.TabPage Tab_Juice;
        private System.Windows.Forms.Label L_JuiceRest;
        private System.Windows.Forms.NumericUpDown NUD_JuiceRest;
        private System.Windows.Forms.CheckBox CHK_HasStock;
        private System.Windows.Forms.GroupBox GB_Stock;
        private System.Windows.Forms.FlowLayoutPanel FLP_Stock;
        private System.Windows.Forms.GroupBox GB_Batch;
        private System.Windows.Forms.FlowLayoutPanel FLP_Batch;
        private System.Windows.Forms.Label L_StepsUntilDone;
        private System.Windows.Forms.NumericUpDown NUD_StepsUntilDone;
        private System.Windows.Forms.Label L_MildnessCount;
        private System.Windows.Forms.NumericUpDown NUD_MildnessCount;
        private System.Windows.Forms.Label L_BrewStartStepCount;
        private System.Windows.Forms.NumericUpDown NUD_BrewStartStepCount;
        private System.Windows.Forms.Label L_StartupFlag;
        private System.Windows.Forms.ComboBox CB_StartupFlag;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Cancel;
    }
}
