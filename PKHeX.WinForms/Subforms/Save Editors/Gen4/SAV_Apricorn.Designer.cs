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
            dgv = new DoubleBufferedDataGridView();
            B_Save = new System.Windows.Forms.Button();
            B_Cancel = new System.Windows.Forms.Button();
            B_All = new System.Windows.Forms.Button();
            B_None = new System.Windows.Forms.Button();
            GB_Kurt = new System.Windows.Forms.GroupBox();
            L_KurtCount = new System.Windows.Forms.Label();
            NUD_KurtCount = new System.Windows.Forms.NumericUpDown();
            L_KurtColor = new System.Windows.Forms.Label();
            CB_KurtColor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            GB_Kurt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_KurtCount).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ColumnHeadersVisible = false;
            dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            dgv.Location = new System.Drawing.Point(14, 50);
            dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dgv.ShowEditingIcon = false;
            dgv.Size = new System.Drawing.Size(233, 215);
            dgv.TabIndex = 11;
            // 
            // B_Save
            // 
            B_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            B_Save.Location = new System.Drawing.Point(134, 347);
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
            B_Cancel.Location = new System.Drawing.Point(14, 347);
            B_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_Cancel.Name = "B_Cancel";
            B_Cancel.Size = new System.Drawing.Size(113, 27);
            B_Cancel.TabIndex = 13;
            B_Cancel.Text = "Cancel";
            B_Cancel.UseVisualStyleBackColor = true;
            B_Cancel.Click += B_Cancel_Click;
            // 
            // B_All
            // 
            B_All.Location = new System.Drawing.Point(14, 16);
            B_All.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_All.Name = "B_All";
            B_All.Size = new System.Drawing.Size(113, 27);
            B_All.TabIndex = 14;
            B_All.Text = "All";
            B_All.UseVisualStyleBackColor = true;
            B_All.Click += B_All_Click;
            // 
            // B_None
            // 
            B_None.Location = new System.Drawing.Point(134, 16);
            B_None.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            B_None.Name = "B_None";
            B_None.Size = new System.Drawing.Size(113, 27);
            B_None.TabIndex = 16;
            B_None.Text = "None";
            B_None.UseVisualStyleBackColor = true;
            B_None.Click += B_None_Click;
            // 
            // GB_Kurt
            // 
            GB_Kurt.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            GB_Kurt.Controls.Add(L_KurtCount);
            GB_Kurt.Controls.Add(NUD_KurtCount);
            GB_Kurt.Controls.Add(L_KurtColor);
            GB_Kurt.Controls.Add(CB_KurtColor);
            GB_Kurt.Location = new System.Drawing.Point(14, 271);
            GB_Kurt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GB_Kurt.Name = "GB_Kurt";
            GB_Kurt.Size = new System.Drawing.Size(233, 68);
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
            // SAV_Apricorn
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            ClientSize = new System.Drawing.Size(261, 390);
            Controls.Add(GB_Kurt);
            Controls.Add(B_None);
            Controls.Add(B_All);
            Controls.Add(B_Cancel);
            Controls.Add(B_Save);
            Controls.Add(dgv);
            Icon = Properties.Resources.Icon;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(277, 935);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(277, 416);
            Name = "SAV_Apricorn";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Apricorn Editor";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            GB_Kurt.ResumeLayout(false);
            GB_Kurt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_KurtCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DoubleBufferedDataGridView dgv;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.Button B_All;
        private System.Windows.Forms.Button B_None;
        private System.Windows.Forms.GroupBox GB_Kurt;
        private System.Windows.Forms.Label L_KurtCount;
        private System.Windows.Forms.NumericUpDown NUD_KurtCount;
        private System.Windows.Forms.Label L_KurtColor;
        private System.Windows.Forms.ComboBox CB_KurtColor;
    }
}
