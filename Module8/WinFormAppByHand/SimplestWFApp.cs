using System;
using System.Windows.Forms;

namespace SimpleWFApp
{
    class Program
    {
        static void Main() 
        {
            Application.Run(new MainWindow("Amina's Win Form", 400, 400));
        }
    }
	
    class MainWindow : Form 
    {
        // Members for a simple menu system.
		private MenuStrip mnuMainMenu = new MenuStrip();
		private ToolStripMenuItem mnuFile = new ToolStripMenuItem();
		private ToolStripMenuItem mnuFileExit = new ToolStripMenuItem();

		public MainWindow(string title, int height, int width)
		{
			// Set various properties from our parent classes.
			Text = title;
			Width = width;
			Height = height;

			// Inherited method to center the form on the screen.
			CenterToScreen();
			
			// Method to create our menu system.
			BuildMenuSystem();
		}
		private void BuildMenuSystem()
		{
			// Add the File menu item to the main menu.
			mnuFile.Text = "&File";
			mnuMainMenu.Items.Add(mnuFile);

			// Now add the Exit menu to the File menu.
			mnuFileExit.Text = "E&xit";
			mnuFile.DropDownItems.Add(mnuFileExit);
			mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);

			// Finally, set the menu for this Form.
			Controls.Add(this.mnuMainMenu);
			MainMenuStrip = this.mnuMainMenu;
		}

		// Handler for the File | Exit event.
		private void mnuFileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
    }
}