/*
 * Created by SharpDevelop.
 * Author: Alexander Lübbe
 * Date: 05.02.2018
 * Time: 21:54
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MSL_Bot
{
	/// <summary>
	/// Description of MainForm.
	/// 
	/// </summary>
	public partial class MainForm : Form
	{
		
		private NotifyIcon notifyIcon;
		private ContextMenu notificationMenu;
		
		public MainForm()
		{
			notifyIcon = new NotifyIcon();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");
			notifyIcon.Text = "MSL-Bot by Sa'Kagé";
			notificationMenu = new ContextMenu(InitializeMenu());
			// TODO: Check why task icon is not showing
			notifyIcon.Visible = true;
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		private MenuItem[] InitializeMenu()
		{
			MenuItem[] menu = new MenuItem[] {
				new MenuItem("About", menuAboutClick),
				new MenuItem("Exit", menuExitClick)
			};
			return menu;
		}
		
		private void menuAboutClick(object sender, EventArgs e)
		{
			MessageBox.Show("About This Application");
		}
		
		private void menuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void IconDoubleClick(object sender, EventArgs e)
		{
			MessageBox.Show("The icon was double clicked");
		}
		
		void StartButtonClick(object sender, EventArgs e)
		{
			// TODO: Implement StartButtonClick
		}
		
		void ExportLogBtnClick(object sender, EventArgs e)
		{
			// TODO: Implement ExportLogBtnClick
		}
		
		// TODO: Add method for adding log messages
	}
}
