namespace RaulGaray_Hw1
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.aboutText = new System.Windows.Forms.Label();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.aboutText);
            // 
            // aboutText
            // 
            this.aboutText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutText.Location = new System.Drawing.Point(0, 0);
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(284, 196);
            this.aboutText.TabIndex = 0;
            this.aboutText.Text = resources.GetString("aboutText.Text");
            this.aboutText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RaulGaray_Hw1.Properties.Resources.Preferences_Background;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AboutDialog";
            this.middlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aboutText;
    }
}