/*
 * Created by SharpDevelop.
 * Author: Alexander Lübbe
 * Date: 05.02.2018
 * Time: 21:54
 */
using System;
using System.Windows.Forms;
using System.Threading;

namespace MSL_Bot
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
