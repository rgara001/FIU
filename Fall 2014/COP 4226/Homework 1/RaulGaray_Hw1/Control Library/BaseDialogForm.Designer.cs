namespace Control_Library
{
    partial class BaseDialogForm
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
            this.full_Name1 = new Control_Library.Full_Name();
            this.course1 = new Control_Library.Course();
            this.SuspendLayout();
            // 
            // full_Name1
            // 
            this.full_Name1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.full_Name1.BackColor = System.Drawing.Color.Transparent;
            this.full_Name1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.full_Name1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.full_Name1.Location = new System.Drawing.Point(0, 233);
            this.full_Name1.Name = "full_Name1";
            this.full_Name1.Size = new System.Drawing.Size(284, 28);
            this.full_Name1.TabIndex = 0;
            // 
            // course1
            // 
            this.course1.BackColor = System.Drawing.Color.Transparent;
            this.course1.Dock = System.Windows.Forms.DockStyle.Top;
            this.course1.Location = new System.Drawing.Point(0, 0);
            this.course1.Name = "course1";
            this.course1.Size = new System.Drawing.Size(284, 37);
            this.course1.TabIndex = 1;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.course1);
            this.Controls.Add(this.full_Name1);
            this.Name = "BaseDialogForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Full_Name full_Name1;
        private Course course1;

    }
}