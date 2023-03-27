namespace MultiplePdfPrinter
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ListViewMain = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.ComboBoxPrinterList = new System.Windows.Forms.ComboBox();
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.StripMenuItemAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_TopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewMain
            // 
            this.ListViewMain.AllowDrop = true;
            this.ListViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewMain.FullRowSelect = true;
            this.ListViewMain.HideSelection = false;
            this.ListViewMain.Location = new System.Drawing.Point(0, 35);
            this.ListViewMain.Name = "ListViewMain";
            this.ListViewMain.Size = new System.Drawing.Size(1148, 622);
            this.ListViewMain.TabIndex = 0;
            this.ListViewMain.UseCompatibleStateImageBehavior = false;
            this.ListViewMain.View = System.Windows.Forms.View.Details;
            this.ListViewMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListViewMain_DragDrop);
            this.ListViewMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListViewMain_DragEnter);
            this.ListViewMain.DoubleClick += new System.EventHandler(this.ListViewMain_DoubleClick);
            this.ListViewMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewMain_KeyDown);
            this.ListViewMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListViewMain_KeyPress);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "文件大小";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "时间";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "状态";
            this.columnHeader4.Width = 120;
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPrint.Location = new System.Drawing.Point(921, 663);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(215, 39);
            this.ButtonPrint.TabIndex = 1;
            this.ButtonPrint.Text = "打印";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // ComboBoxPrinterList
            // 
            this.ComboBoxPrinterList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPrinterList.FormattingEnabled = true;
            this.ComboBoxPrinterList.Location = new System.Drawing.Point(12, 663);
            this.ComboBoxPrinterList.Name = "ComboBoxPrinterList";
            this.ComboBoxPrinterList.Size = new System.Drawing.Size(903, 39);
            this.ComboBoxPrinterList.TabIndex = 2;
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItemAction,
            this.StripMenuItemOption});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Size = new System.Drawing.Size(1148, 32);
            this.MenuStripMain.TabIndex = 3;
            // 
            // StripMenuItemAction
            // 
            this.StripMenuItemAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Clear,
            this.ToolStripMenuItem_Refresh});
            this.StripMenuItemAction.Name = "StripMenuItemAction";
            this.StripMenuItemAction.Size = new System.Drawing.Size(92, 28);
            this.StripMenuItemAction.Text = "操作 (&A)";
            // 
            // ToolStripMenuItem_Clear
            // 
            this.ToolStripMenuItem_Clear.Name = "ToolStripMenuItem_Clear";
            this.ToolStripMenuItem_Clear.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_Clear.Size = new System.Drawing.Size(265, 34);
            this.ToolStripMenuItem_Clear.Text = "清空列表 (&C)";
            this.ToolStripMenuItem_Clear.Click += new System.EventHandler(this.ToolStripMenuItem_Clear_Click);
            // 
            // ToolStripMenuItem_Refresh
            // 
            this.ToolStripMenuItem_Refresh.Name = "ToolStripMenuItem_Refresh";
            this.ToolStripMenuItem_Refresh.Size = new System.Drawing.Size(265, 34);
            this.ToolStripMenuItem_Refresh.Text = "刷新打印机列表 (&R)";
            this.ToolStripMenuItem_Refresh.Click += new System.EventHandler(this.ToolStripMenuItem_Refresh_Click);
            // 
            // StripMenuItemOption
            // 
            this.StripMenuItemOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_TopMost,
            this.ToolStripMenuItem_Language,
            this.ToolStripMenuItem_About});
            this.StripMenuItemOption.Name = "StripMenuItemOption";
            this.StripMenuItemOption.Size = new System.Drawing.Size(94, 28);
            this.StripMenuItemOption.Text = "选项 (&O)";
            // 
            // ToolStripMenuItem_TopMost
            // 
            this.ToolStripMenuItem_TopMost.Name = "ToolStripMenuItem_TopMost";
            this.ToolStripMenuItem_TopMost.Size = new System.Drawing.Size(270, 34);
            this.ToolStripMenuItem_TopMost.Text = "窗口置顶 (&T)";
            this.ToolStripMenuItem_TopMost.Click += new System.EventHandler(this.ToolStripMenuItem_TopMost_Click);
            // 
            // ToolStripMenuItem_Language
            // 
            this.ToolStripMenuItem_Language.Name = "ToolStripMenuItem_Language";
            this.ToolStripMenuItem_Language.Size = new System.Drawing.Size(270, 34);
            this.ToolStripMenuItem_Language.Text = "语言 (&L)";
            // 
            // ToolStripMenuItem_About
            // 
            this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
            this.ToolStripMenuItem_About.Size = new System.Drawing.Size(270, 34);
            this.ToolStripMenuItem_About.Text = "关于 (&A)";
            this.ToolStripMenuItem_About.Click += new System.EventHandler(this.ToolStripMenuItem_About_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 714);
            this.Controls.Add(this.ComboBoxPrinterList);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.ListViewMain);
            this.Controls.Add(this.MenuStripMain);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.HelpButton = true;
            this.MainMenuStrip = this.MenuStripMain;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF批量打印";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormMain_HelpButtonClicked);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewMain;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.ComboBox ComboBoxPrinterList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemAction;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemOption;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Clear;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Refresh;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TopMost;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Language;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_About;
    }
}

