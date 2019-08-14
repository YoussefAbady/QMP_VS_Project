namespace Resala_HR
{
    partial class F_home
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
            this.components = new System.ComponentModel.Container();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.اعداداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعداداتالمستخدمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعداداتالبرنامجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اقتراحاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.B_AddQafela = new System.Windows.Forms.Button();
            this.L_Name = new System.Windows.Forms.Label();
            this.L_Role = new System.Windows.Forms.Label();
            this.TABC_Main = new System.Windows.Forms.TabControl();
            this.TABP_Main = new System.Windows.Forms.TabPage();
            this.TABP_QfHistory = new System.Windows.Forms.TabPage();
            this.LV_QfHist = new System.Windows.Forms.ListView();
            this.LV_COL_QfName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_COL_QfDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_COL_QfMemAttenNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_COL_QfVolAtten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.L_Br = new System.Windows.Forms.Label();
            this.CMS.SuspendLayout();
            this.TABC_Main.SuspendLayout();
            this.TABP_Main.SuspendLayout();
            this.TABP_QfHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اعداداتToolStripMenuItem,
            this.تسجيلخروجToolStripMenuItem,
            this.خروجToolStripMenuItem,
            this.اقتراحاتToolStripMenuItem});
            this.CMS.Name = "contextMenuStrip1";
            this.CMS.Size = new System.Drawing.Size(137, 92);
            this.CMS.Text = "اذهب إالي";
            // 
            // اعداداتToolStripMenuItem
            // 
            this.اعداداتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اعداداتالمستخدمToolStripMenuItem,
            this.اعداداتالبرنامجToolStripMenuItem});
            this.اعداداتToolStripMenuItem.Name = "اعداداتToolStripMenuItem";
            this.اعداداتToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.اعداداتToolStripMenuItem.Text = "اعدادات";
            // 
            // اعداداتالمستخدمToolStripMenuItem
            // 
            this.اعداداتالمستخدمToolStripMenuItem.Name = "اعداداتالمستخدمToolStripMenuItem";
            this.اعداداتالمستخدمToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.اعداداتالمستخدمToolStripMenuItem.Text = "اعدادات المستخدم";
            // 
            // اعداداتالبرنامجToolStripMenuItem
            // 
            this.اعداداتالبرنامجToolStripMenuItem.Name = "اعداداتالبرنامجToolStripMenuItem";
            this.اعداداتالبرنامجToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.اعداداتالبرنامجToolStripMenuItem.Text = "اعدادات البرنامج";
            // 
            // تسجيلخروجToolStripMenuItem
            // 
            this.تسجيلخروجToolStripMenuItem.Name = "تسجيلخروجToolStripMenuItem";
            this.تسجيلخروجToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.تسجيلخروجToolStripMenuItem.Text = "تسجيل خروج ";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // اقتراحاتToolStripMenuItem
            // 
            this.اقتراحاتToolStripMenuItem.Name = "اقتراحاتToolStripMenuItem";
            this.اقتراحاتToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.اقتراحاتToolStripMenuItem.Text = "اقتراحات";
            // 
            // B_AddQafela
            // 
            this.B_AddQafela.Location = new System.Drawing.Point(6, 6);
            this.B_AddQafela.Name = "B_AddQafela";
            this.B_AddQafela.Size = new System.Drawing.Size(75, 23);
            this.B_AddQafela.TabIndex = 1;
            this.B_AddQafela.Text = "أضف قافلة ";
            this.B_AddQafela.UseVisualStyleBackColor = true;
            this.B_AddQafela.Click += new System.EventHandler(this.button1_Click);
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(649, 6);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(39, 13);
            this.L_Name.TabIndex = 2;
            this.L_Name.Text = "الاسم : ";
            // 
            // L_Role
            // 
            this.L_Role.AutoSize = true;
            this.L_Role.Location = new System.Drawing.Point(644, 43);
            this.L_Role.Name = "L_Role";
            this.L_Role.Size = new System.Drawing.Size(44, 13);
            this.L_Role.TabIndex = 4;
            this.L_Role.Text = "المركز : ";
            // 
            // TABC_Main
            // 
            this.TABC_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABC_Main.Controls.Add(this.TABP_Main);
            this.TABC_Main.Controls.Add(this.TABP_QfHistory);
            this.TABC_Main.Location = new System.Drawing.Point(4, 12);
            this.TABC_Main.Name = "TABC_Main";
            this.TABC_Main.RightToLeftLayout = true;
            this.TABC_Main.SelectedIndex = 0;
            this.TABC_Main.Size = new System.Drawing.Size(719, 306);
            this.TABC_Main.TabIndex = 9;
            // 
            // TABP_Main
            // 
            this.TABP_Main.Controls.Add(this.L_Br);
            this.TABP_Main.Controls.Add(this.B_AddQafela);
            this.TABP_Main.Controls.Add(this.L_Role);
            this.TABP_Main.Controls.Add(this.L_Name);
            this.TABP_Main.Location = new System.Drawing.Point(4, 22);
            this.TABP_Main.Name = "TABP_Main";
            this.TABP_Main.Padding = new System.Windows.Forms.Padding(3);
            this.TABP_Main.Size = new System.Drawing.Size(711, 280);
            this.TABP_Main.TabIndex = 0;
            this.TABP_Main.Text = "الرئيسية";
            this.TABP_Main.UseVisualStyleBackColor = true;
            // 
            // TABP_QfHistory
            // 
            this.TABP_QfHistory.Controls.Add(this.LV_QfHist);
            this.TABP_QfHistory.Location = new System.Drawing.Point(4, 22);
            this.TABP_QfHistory.Name = "TABP_QfHistory";
            this.TABP_QfHistory.Padding = new System.Windows.Forms.Padding(3);
            this.TABP_QfHistory.Size = new System.Drawing.Size(711, 280);
            this.TABP_QfHistory.TabIndex = 1;
            this.TABP_QfHistory.Text = "سجل القوافل";
            this.TABP_QfHistory.UseVisualStyleBackColor = true;
            // 
            // LV_QfHist
            // 
            this.LV_QfHist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_QfHist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LV_COL_QfName,
            this.LV_COL_QfDate,
            this.LV_COL_QfMemAttenNum,
            this.LV_COL_QfVolAtten});
            this.LV_QfHist.Location = new System.Drawing.Point(3, 24);
            this.LV_QfHist.Name = "LV_QfHist";
            this.LV_QfHist.RightToLeftLayout = true;
            this.LV_QfHist.Size = new System.Drawing.Size(704, 260);
            this.LV_QfHist.TabIndex = 0;
            this.LV_QfHist.UseCompatibleStateImageBehavior = false;
            this.LV_QfHist.View = System.Windows.Forms.View.Details;
            // 
            // LV_COL_QfName
            // 
            this.LV_COL_QfName.Text = "اسم القافلة";
            this.LV_COL_QfName.Width = 186;
            // 
            // LV_COL_QfDate
            // 
            this.LV_COL_QfDate.Text = "تاريخ القافلة ";
            this.LV_COL_QfDate.Width = 126;
            // 
            // LV_COL_QfMemAttenNum
            // 
            this.LV_COL_QfMemAttenNum.Text = "عدد المسئولين";
            this.LV_COL_QfMemAttenNum.Width = 177;
            // 
            // LV_COL_QfVolAtten
            // 
            this.LV_COL_QfVolAtten.Text = "عدد المتطوعين";
            this.LV_COL_QfVolAtten.Width = 81;
            // 
            // L_Br
            // 
            this.L_Br.AutoSize = true;
            this.L_Br.Location = new System.Drawing.Point(649, 24);
            this.L_Br.Name = "L_Br";
            this.L_Br.Size = new System.Drawing.Size(39, 13);
            this.L_Br.TabIndex = 5;
            this.L_Br.Text = "الفرع : ";
            // 
            // F_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 346);
            this.Controls.Add(this.TABC_Main);
            this.Name = "F_home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "قوافل داخلية - فرع ";
            this.CMS.ResumeLayout(false);
            this.TABC_Main.ResumeLayout(false);
            this.TABP_Main.ResumeLayout(false);
            this.TABP_Main.PerformLayout();
            this.TABP_QfHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem اعداداتToolStripMenuItem;
        private System.Windows.Forms.Button B_AddQafela;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label L_Role;
        private System.Windows.Forms.ToolStripMenuItem اعداداتالمستخدمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اعداداتالبرنامجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلخروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اقتراحاتToolStripMenuItem;
        private System.Windows.Forms.TabControl TABC_Main;
        private System.Windows.Forms.TabPage TABP_Main;
        private System.Windows.Forms.TabPage TABP_QfHistory;
        private System.Windows.Forms.ListView LV_QfHist;
        private System.Windows.Forms.ColumnHeader LV_COL_QfName;
        private System.Windows.Forms.ColumnHeader LV_COL_QfDate;
        private System.Windows.Forms.ColumnHeader LV_COL_QfMemAttenNum;
        private System.Windows.Forms.ColumnHeader LV_COL_QfVolAtten;
        private System.Windows.Forms.Label L_Br;
    }
}