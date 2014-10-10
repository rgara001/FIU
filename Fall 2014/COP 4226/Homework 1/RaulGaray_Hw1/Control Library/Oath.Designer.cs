namespace Control_Library
{
    partial class Oath
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oath));
            this.oathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oathLabel
            // 
            this.oathLabel.BackColor = System.Drawing.Color.Transparent;
            this.oathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.oathLabel.Location = new System.Drawing.Point(0, 0);
            this.oathLabel.Name = "oathLabel";
            this.oathLabel.Size = new System.Drawing.Size(498, 112);
            this.oathLabel.TabIndex = 0;
            this.oathLabel.Text = resources.GetString("oathLabel.Text");
            this.oathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oathLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Oath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.oathLabel);
            this.Name = "Oath";
            this.Size = new System.Drawing.Size(498, 112);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label oathLabel;
    }
}
