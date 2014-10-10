namespace Control_Library
{
    partial class OathDialog
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
            this.oath = new Control_Library.Oath();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.Size = new System.Drawing.Size(104, 93);
            // 
            // oath
            // 
            this.oath.BackColor = System.Drawing.Color.Transparent;
            this.oath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oath.Location = new System.Drawing.Point(0, 37);
            this.oath.Name = "oath";
            this.oath.Size = new System.Drawing.Size(319, 167);
            this.oath.TabIndex = 0;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RaulGaray_Hw1.Properties.Resources.Preferences_Background;
            this.ClientSize = new System.Drawing.Size(319, 232);
            this.Controls.Add(this.oath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OathDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Oath Dialog";
            this.Controls.SetChildIndex(this.middlePanel, 0);
            this.Controls.SetChildIndex(this.oath, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Oath oath;
    }
}