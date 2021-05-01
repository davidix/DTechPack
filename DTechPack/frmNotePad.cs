
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace DTechPack
{
	/// <summary>
	/// Description of frmNotePad.
	/// </summary>
	public partial class frmNotePad : Form
	{
		public frmNotePad()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmNotePadLoad(object sender, EventArgs e)
		{
			Process p = Process.Start("notepad.exe");
			 Thread.Sleep(500);
			p.WaitForInputIdle();
			SetParent(p.MainWindowHandle, panel1.Handle);	
		}
		
		  [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
	}
}
