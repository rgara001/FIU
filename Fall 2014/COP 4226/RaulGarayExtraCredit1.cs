using System;
using System.Windows.Forms;

	class Window : Form
	{
		private String myName;
		private Panel panel1;

		public Window(String text, String myName)
		{
			this.Text = text;
			this.myName = myName;
			this.Size = new System.Drawing.Size(500,500);

			//Bullet Point 2
			this.panel1 = new Panel();
			configurePanel1(myName);
			this.Controls.Add(this.panel1);

		}

		public String getName()
		{
			return this.myName;
		}

		private void configurePanel1(String myName)
		{
			this.panel1.BackColor = System.Drawing.Color.Red;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Size = new System.Drawing.Size(50,50);
			Label panel1Label = new Label();
			panel1Label.Name = myName;
			panel1.Controls.Add(panel1Label);
		}
	}

	class ExtraCredit1
	{
		static void Main()
		{
			Window form = new Window("this is the title", "raul");
			String sample = form.getName();
			Application.Run(form);
		}
	}