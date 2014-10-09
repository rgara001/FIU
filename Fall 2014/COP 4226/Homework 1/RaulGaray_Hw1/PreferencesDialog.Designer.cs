namespace RaulGaray_Hw1
{
    partial class PreferencesDialog
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
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.ellipcticRatioTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.rectHeigthLabel = new System.Windows.Forms.Label();
            this.ellipticRatioLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.rectRatioLabel = new System.Windows.Forms.Label();
            this.rectRatioTextBox = new System.Windows.Forms.TextBox();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.rectRatioLabel);
            this.middlePanel.Controls.Add(this.rectRatioTextBox);
            this.middlePanel.Controls.Add(this.cancelButton);
            this.middlePanel.Controls.Add(this.applyButton);
            this.middlePanel.Controls.Add(this.okButton);
            this.middlePanel.Controls.Add(this.ellipticRatioLabel);
            this.middlePanel.Controls.Add(this.rectHeigthLabel);
            this.middlePanel.Controls.Add(this.WidthLabel);
            this.middlePanel.Controls.Add(this.heightTextBox);
            this.middlePanel.Controls.Add(this.ellipcticRatioTextBox);
            this.middlePanel.Controls.Add(this.widthTextBox);
            this.middlePanel.Size = new System.Drawing.Size(337, 205);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.widthTextBox.Location = new System.Drawing.Point(48, 18);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(40, 20);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumeric_Validating);
            // 
            // ellipcticRatioTextBox
            // 
            this.ellipcticRatioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ellipcticRatioTextBox.Location = new System.Drawing.Point(48, 48);
            this.ellipcticRatioTextBox.Name = "ellipcticRatioTextBox";
            this.ellipcticRatioTextBox.Size = new System.Drawing.Size(40, 20);
            this.ellipcticRatioTextBox.TabIndex = 1;
            this.ellipcticRatioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ellipcticRatioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumeric_Validating);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.heightTextBox.Location = new System.Drawing.Point(48, 78);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(40, 20);
            this.heightTextBox.TabIndex = 2;
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.heightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumeric_Validating);
            // 
            // WidthLabel
            // 
            this.WidthLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(94, 21);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(94, 13);
            this.WidthLabel.TabIndex = 3;
            this.WidthLabel.Text = "Elliptic Child Width";
            // 
            // rectHeigthLabel
            // 
            this.rectHeigthLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rectHeigthLabel.AutoSize = true;
            this.rectHeigthLabel.Location = new System.Drawing.Point(94, 81);
            this.rectHeigthLabel.Name = "rectHeigthLabel";
            this.rectHeigthLabel.Size = new System.Drawing.Size(125, 13);
            this.rectHeigthLabel.TabIndex = 4;
            this.rectHeigthLabel.Text = "Rectangular Child Height";
            // 
            // ellipticRatioLabel
            // 
            this.ellipticRatioLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ellipticRatioLabel.AutoSize = true;
            this.ellipticRatioLabel.Location = new System.Drawing.Point(94, 51);
            this.ellipticRatioLabel.Name = "ellipticRatioLabel";
            this.ellipticRatioLabel.Size = new System.Drawing.Size(130, 13);
            this.ellipticRatioLabel.TabIndex = 5;
            this.ellipticRatioLabel.Text = "Elliptic Width-Height Ratio";
            this.ellipticRatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(48, 172);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(210, 172);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(129, 172);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // rectRatioLabel
            // 
            this.rectRatioLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rectRatioLabel.AutoSize = true;
            this.rectRatioLabel.Location = new System.Drawing.Point(94, 111);
            this.rectRatioLabel.Name = "rectRatioLabel";
            this.rectRatioLabel.Size = new System.Drawing.Size(158, 13);
            this.rectRatioLabel.TabIndex = 10;
            this.rectRatioLabel.Text = "Rectangular Width-Height Ratio";
            this.rectRatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rectRatioTextBox
            // 
            this.rectRatioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rectRatioTextBox.Location = new System.Drawing.Point(48, 108);
            this.rectRatioTextBox.Name = "rectRatioTextBox";
            this.rectRatioTextBox.Size = new System.Drawing.Size(40, 20);
            this.rectRatioTextBox.TabIndex = 9;
            this.rectRatioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rectRatioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumeric_Validating);
            // 
            // PreferencesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RaulGaray_Hw1.Properties.Resources.Preferences_Background;
            this.ClientSize = new System.Drawing.Size(337, 292);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesDialog";
            this.Text = "Preferences";
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ellipticRatioLabel;
        private System.Windows.Forms.Label rectHeigthLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox ellipcticRatioTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label rectRatioLabel;
        private System.Windows.Forms.TextBox rectRatioTextBox;
    }
}