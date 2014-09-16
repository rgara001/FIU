using System;
using System.Windows.Forms;
using System.Drawing;

	//just a comment
	class Window : Form
	{
		private String myName;

		public Window(String arg1, String arg2)
		{
			this.Text = arg1;
			this.myName = arg2;
			this.Size = new Size(500,500);
		}

		public String getName()
		{
			return this.myName;
		}
	}

	class EC
	{
		static void Main()
		{
			Window form = new Window("this is the title", "raul");
			String sample = form.getName();
			Application.Run(form);
		}
	}