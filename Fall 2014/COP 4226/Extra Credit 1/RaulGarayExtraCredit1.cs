using System;
using System.Windows.Forms;

	class Window : Form
	{
		private String myName;
		private Panel panel1;
		private Label panel1Label;
		private Panel panel2;
		private Label panel2Label;
		private TextBox panel2TextBox;
		private Button panel2Button;

		public Window()
		{
			this.Text = "Raul's first Program!";
			this.myName = "Raul Garay";
			this.Size = new System.Drawing.Size(500,500);

			//Bullet Point 2
			this.panel1 = new Panel();
			configurePanel1(myName);
			this.Controls.Add(this.panel1);

			//Bullet Point 3
			this.panel2 = new Panel();
			configurePanel2();
			this.Controls.Add(this.panel2);
		}

		public Window(String text, String myName)
		{
			this.Text = text;
			this.myName = myName;
			this.Size = new System.Drawing.Size(500,500);

			//Bullet Point 2
			this.panel1 = new Panel();
			configurePanel1(myName);
			this.Controls.Add(this.panel1);

			//Bullet Point 3
			this.panel2 = new Panel();
			configurePanel2();
			this.Controls.Add(this.panel2);
		}

		private void configurePanel1(String labelName)
		{
			this.panel1.BackColor = System.Drawing.Color.Red;
			this.panel1.Dock = DockStyle.Bottom;	//System.Windows.Forms.DockStyle
			this.panel1.Size = new System.Drawing.Size(50,50);

			panel1Label = new Label();
			panel1Label.Text = myName;
			panel1.Controls.Add(panel1Label);
		}

		private void configurePanel2()
		{
			this.panel2.BackColor = System.Drawing.Color.Blue;
			this.panel2.Dock = DockStyle.Fill;	//System.Windows.Forms.DockStyle

			panel2Label = new Label();
			panel2Label.Text = "Comment";
			panel2Label.Top = 100;
			panel2Label.Left = 20;
			panel2.Controls.Add(panel2Label);

			panel2TextBox = new TextBox();
			panel2TextBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
			panel2TextBox.Location = new System.Drawing.Point(120, 100);
			panel2TextBox.Size = new System.Drawing.Size(40, 20);
			panel2.Controls.Add(panel2TextBox);

			panel2Button = new Button();
			panel2Button.Anchor = AnchorStyles.Right;
			panel2Button.Top = 200;
			panel2Button.Left = panel2TextBox.Width + 40;
			panel2Button.Text = "Click me!";
			panel2Button.Click += new EventHandler(button_click);
			panel2.Controls.Add(panel2Button);
		}

		private void button_click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello. The text you typed was: \"" + this.panel2TextBox.Text + "\"" );
		}
	}


	class ExtraCredit1
	{
		static void Main(string[] args)
		{
			Window form;
			if(args.Length < 2)
			{
				MessageBox.Show("whattup1");
				form = new Window();
			}
			else
			{
				MessageBox.Show("whattup2");
				form = new Window(args[0], args[1]);
			}

			Application.Run(form);
		}
	}