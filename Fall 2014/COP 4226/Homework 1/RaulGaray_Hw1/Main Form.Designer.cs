namespace RaulGaray_Hw1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesModallyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MainFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openEllipticChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRectangularChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePreferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadPreferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPreferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.oathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainContextMenu.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.mainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContextMenu
            // 
            this.MainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModallyToolStripMenuItem1,
            this.zipToolStripMenuItem,
            this.savePreferencesToolStripMenuItem,
            this.reloadPreferencesToolStripMenuItem,
            this.resetPreferencesToolStripMenuItem});
            this.MainContextMenu.Name = "contextMenuStrip1";
            this.MainContextMenu.Size = new System.Drawing.Size(230, 114);
            // 
            // openPreferencesModallyToolStripMenuItem1
            // 
            this.openPreferencesModallyToolStripMenuItem1.Name = "openPreferencesModallyToolStripMenuItem1";
            this.openPreferencesModallyToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.openPreferencesModallyToolStripMenuItem1.Text = "Open Preferences Modally";
            this.openPreferencesModallyToolStripMenuItem1.Click += new System.EventHandler(this.openPreferencesModally_Click);
            // 
            // zipToolStripMenuItem
            // 
            this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
            this.zipToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.zipToolStripMenuItem.Text = "Open Preferences Modelessly";
            this.zipToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModelessly_Click);
            // 
            // savePreferencesToolStripMenuItem
            // 
            this.savePreferencesToolStripMenuItem.Name = "savePreferencesToolStripMenuItem";
            this.savePreferencesToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.savePreferencesToolStripMenuItem.Text = "Save Preferences";
            // 
            // reloadPreferencesToolStripMenuItem
            // 
            this.reloadPreferencesToolStripMenuItem.Name = "reloadPreferencesToolStripMenuItem";
            this.reloadPreferencesToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.reloadPreferencesToolStripMenuItem.Text = "Reload Preferences";
            // 
            // resetPreferencesToolStripMenuItem
            // 
            this.resetPreferencesToolStripMenuItem.Name = "resetPreferencesToolStripMenuItem";
            this.resetPreferencesToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.resetPreferencesToolStripMenuItem.Text = "Reset Preferences";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 442);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(496, 22);
            this.MainStatusStrip.TabIndex = 2;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFileMenu,
            this.preferencesToolStripMenuItem,
            this.MainHelpMenu});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(496, 24);
            this.mainFormMenuStrip.TabIndex = 5;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // MainFileMenu
            // 
            this.MainFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEllipticChildToolStripMenuItem,
            this.openRectangularChildToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.MainFileMenu.Name = "MainFileMenu";
            this.MainFileMenu.Size = new System.Drawing.Size(37, 20);
            this.MainFileMenu.Text = "File";
            // 
            // openEllipticChildToolStripMenuItem
            // 
            this.openEllipticChildToolStripMenuItem.Name = "openEllipticChildToolStripMenuItem";
            this.openEllipticChildToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.openEllipticChildToolStripMenuItem.Text = "Open Elliptic Child";
            this.openEllipticChildToolStripMenuItem.Click += new System.EventHandler(this.openEllipticChild_Click);
            // 
            // openRectangularChildToolStripMenuItem
            // 
            this.openRectangularChildToolStripMenuItem.Name = "openRectangularChildToolStripMenuItem";
            this.openRectangularChildToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.openRectangularChildToolStripMenuItem.Text = "Open Rectangular Child";
            this.openRectangularChildToolStripMenuItem.Click += new System.EventHandler(this.openRectChild_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplication_Clicked);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModallyToolStripMenuItem,
            this.openPreferencesModelesslyToolStripMenuItem,
            this.savePreferencesToolStripMenuItem1,
            this.reloadPreferencesToolStripMenuItem1,
            this.resetPreferencesToolStripMenuItem1});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // openPreferencesModallyToolStripMenuItem
            // 
            this.openPreferencesModallyToolStripMenuItem.Name = "openPreferencesModallyToolStripMenuItem";
            this.openPreferencesModallyToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openPreferencesModallyToolStripMenuItem.Text = "Open Preferences Modally";
            this.openPreferencesModallyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModally_Click);
            // 
            // openPreferencesModelesslyToolStripMenuItem
            // 
            this.openPreferencesModelesslyToolStripMenuItem.Name = "openPreferencesModelesslyToolStripMenuItem";
            this.openPreferencesModelesslyToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openPreferencesModelesslyToolStripMenuItem.Text = "Open Preferences Modelessly";
            this.openPreferencesModelesslyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModelessly_Click);
            // 
            // savePreferencesToolStripMenuItem1
            // 
            this.savePreferencesToolStripMenuItem1.Name = "savePreferencesToolStripMenuItem1";
            this.savePreferencesToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.savePreferencesToolStripMenuItem1.Text = "Save Preferences";
            this.savePreferencesToolStripMenuItem1.Click += new System.EventHandler(this.savePreferences_Click);
            // 
            // reloadPreferencesToolStripMenuItem1
            // 
            this.reloadPreferencesToolStripMenuItem1.Name = "reloadPreferencesToolStripMenuItem1";
            this.reloadPreferencesToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.reloadPreferencesToolStripMenuItem1.Text = "Reload Preferences";
            this.reloadPreferencesToolStripMenuItem1.Click += new System.EventHandler(this.reloadPreferences_Clicked);
            // 
            // resetPreferencesToolStripMenuItem1
            // 
            this.resetPreferencesToolStripMenuItem1.Name = "resetPreferencesToolStripMenuItem1";
            this.resetPreferencesToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.resetPreferencesToolStripMenuItem1.Text = "Reset Preferences";
            this.resetPreferencesToolStripMenuItem1.Click += new System.EventHandler(this.resetPreferences_Clicked);
            // 
            // MainHelpMenu
            // 
            this.MainHelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oathToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainHelpMenu.Name = "MainHelpMenu";
            this.MainHelpMenu.Size = new System.Drawing.Size(44, 20);
            this.MainHelpMenu.Text = "Help";
            // 
            // oathToolStripMenuItem
            // 
            this.oathToolStripMenuItem.Name = "oathToolStripMenuItem";
            this.oathToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.oathToolStripMenuItem.Text = "Oath";
            this.oathToolStripMenuItem.Click += new System.EventHandler(this.oathToolStripItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 464);
            this.ContextMenuStrip = this.MainContextMenu;
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.mainFormMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raul Garay - Hw 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.MdiChildActivate += new System.EventHandler(this.statusBar_Activate);
            this.MainContextMenu.ResumeLayout(false);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Control_Library.BaseDialogForm form = new Control_Library.BaseDialogForm();
        private System.Windows.Forms.ContextMenuStrip MainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem zipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadPreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPreferencesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModallyToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MainFileMenu;
        private System.Windows.Forms.ToolStripMenuItem openEllipticChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRectangularChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem oathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModelesslyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePreferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reloadPreferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetPreferencesToolStripMenuItem1;

    }
}

