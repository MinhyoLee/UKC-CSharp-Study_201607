using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace PerfMon
{
	/// <summary>
	/// Summary description for MDIMain.
	/// </summary>
	public class MDIMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MdiClient mdiClient1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        
		public MDIMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
        
        #region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.mdiClient1 = new System.Windows.Forms.MdiClient();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.SuspendLayout();
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.Text = "&Options";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "&New PerfMon";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "&Exit";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// mdiClient1
			// 
			this.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mdiClient1.Name = "mdiClient1";
			this.mdiClient1.TabIndex = 0;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// MDIMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 625);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.mdiClient1});
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "MDIMain";
			this.Text = "MDIMain";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MDIMain_Load);
			this.ResumeLayout(false);
            
		}
        #endregion
        
        
        
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MDIMain());
		}
        
		//Menu Item (New PerfMon)
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			NewPerfMon();
            
		}
		//Create a new instance of the DisplayForm (for a new machine watch)
		private void NewPerfMon()
		{
			PerfMon.DisplayForm mf = new DisplayForm();
			mf.MdiParent=this;
			mf.Visible=true;
            
            
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.Close();
			Environment.Exit(0);
		}
        //Open four instances of the DisplayForm
		private void MDIMain_Load(object sender, System.EventArgs e)
		{
			for(int i = 0; i< 4; i++)
				NewPerfMon();
			ArrangeChildren();
		}
        //Arrange MDI children
		public void ArrangeChildren()
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
            
		}
        
	}
}
