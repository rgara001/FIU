namespace Control_Library
{
    partial class BaseWindowsForm
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
            this.baseContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseContextMenu.SuspendLayout();
            this.baseMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseContextMenu
            // 
            this.baseContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.baseContextMenu.Name = "baseContextMenu";
            this.baseContextMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.color_Click);
            // 
            // baseMenuStrip
            // 
            this.baseMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fdfToolStripMenuItem});
            this.baseMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.baseMenuStrip.Name = "baseMenuStrip";
            this.baseMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.baseMenuStrip.TabIndex = 4;
            this.baseMenuStrip.Text = "menuStrip1";
            this.baseMenuStrip.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeChildToolStripMenuItem});
            this.fileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeChildToolStripMenuItem
            // 
            this.closeChildToolStripMenuItem.Name = "closeChildToolStripMenuItem";
            this.closeChildToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeChildToolStripMenuItem.Text = "Close Child";
            this.closeChildToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fdfToolStripMenuItem
            // 
            this.fdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem});
            this.fdfToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fdfToolStripMenuItem.Name = "fdfToolStripMenuItem";
            this.fdfToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fdfToolStripMenuItem.Text = "Preferences";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.color_Click);
            // 
            // BaseWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ContextMenuStrip = this.baseContextMenu;
            this.Controls.Add(this.baseMenuStrip);
            this.Name = "BaseWindowsForm";
            this.Text = "BaseWindowsForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseUp);
            this.baseContextMenu.ResumeLayout(false);
            this.baseMenuStrip.ResumeLayout(false);
            this.baseMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip baseContextMenu;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.MenuStrip baseMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
    }
}