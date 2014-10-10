namespace RaulGaray_Hw1
{
    partial class LoginDialog
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
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.SkipLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Yes
            // 
            this.Yes.Location = new System.Drawing.Point(54, 112);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(75, 23);
            this.Yes.TabIndex = 0;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(164, 112);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(75, 23);
            this.No.TabIndex = 1;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.noButton_Clicked);
            // 
            // SkipLoginCheckBox
            // 
            this.SkipLoginCheckBox.AutoSize = true;
            this.SkipLoginCheckBox.Location = new System.Drawing.Point(54, 75);
            this.SkipLoginCheckBox.Name = "SkipLoginCheckBox";
            this.SkipLoginCheckBox.Size = new System.Drawing.Size(160, 17);
            this.SkipLoginCheckBox.TabIndex = 2;
            this.SkipLoginCheckBox.Text = "Skip this screen in the future";
            this.SkipLoginCheckBox.UseVisualStyleBackColor = true;
            this.SkipLoginCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Checked);
            // 
            // LoginMessageLabel
            // 
            this.LoginMessageLabel.AutoSize = true;
            this.LoginMessageLabel.Location = new System.Drawing.Point(21, 35);
            this.LoginMessageLabel.Name = "LoginMessageLabel";
            this.LoginMessageLabel.Size = new System.Drawing.Size(262, 13);
            this.LoginMessageLabel.TabIndex = 3;
            this.LoginMessageLabel.Text = "Are you prepared to run the greatest program...EVER?";
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 163);
            this.Controls.Add(this.LoginMessageLabel);
            this.Controls.Add(this.SkipLoginCheckBox);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Name = "LoginDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.CheckBox SkipLoginCheckBox;
        private System.Windows.Forms.Label LoginMessageLabel;
    }
}