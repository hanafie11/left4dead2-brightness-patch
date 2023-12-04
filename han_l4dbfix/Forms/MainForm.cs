/*
 * Created by SharpDevelop.
 * User: Hanafie11
 * Date: 04/11/2022
 * Time: 18:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using han_l4dbfix.Classes;

namespace han_l4dbfix
{
	public partial class MainForm : Form
	{
		private clsFunction Func;
		public MainForm()
		{
			InitializeComponent();
			Func = new clsFunction(); // Instansiasi Objek Func
			
			txtLog.Select(0, 0);
		}
		
		// Make Form Draggable
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (e.Button == MouseButtons.Left) {
				this.Capture = false;
				Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
				this.WndProc(ref msg);
			}
		}
		
		void BtnQuitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnPatchMouseEnter(object sender, EventArgs e)
		{
			btnPatch.BackColor = Color.DarkGreen;
		}
		
		void BtnPatchMouseLeave(object sender, EventArgs e)
		{
			btnPatch.BackColor = Color.Transparent;
		}
		
		void BtnQuitMouseEnter(object sender, EventArgs e)
		{
			btnQuit.BackColor = Color.DarkGreen;
		}
		
		void BtnQuitMouseLeave(object sender, EventArgs e)
		{
			btnQuit.BackColor = Color.Transparent;
		}
		
		void LblCloseClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnPatchClick(object sender, EventArgs e)
		{
			Func.patchTarget(txtLog);
			Func.Dispose();
		}
		
		void LblVisitChnlClick(object sender, EventArgs e)
		{
			Func.goToUrl("https://www.youtube.com/@Hanafie11");
			Func.Dispose();
		}
		
		void BtnSubscribeClick(object sender, EventArgs e)
		{
			Func.goToUrl("https://www.youtube.com/@Hanafie11?sub_confirmation=1");
			Func.Dispose();
		}
		void LblRestoreClick(object sender, EventArgs e)
		{
			Func.restoreBackup();
			Func.Dispose();
		}

		void BtnOpenVideotxtClick(object sender, EventArgs e)
		{
			Func.openVideotxt();
		}
		void BtnOpenVideotxtMouseEnter(object sender, EventArgs e)
		{
			btnOpenVideotxt.BackColor = Color.DarkGreen;
		}
		void BtnOpenVideotxtMouseLeave(object sender, EventArgs e)
		{
			btnOpenVideotxt.BackColor = Color.Transparent;
		}
		void LblTutorialClick(object sender, EventArgs e)
		{
			Func.goToUrl("https://youtu.be/BAEfTVF02I8?si=xc0e-jyhhP67JilS");
			Func.Dispose();
		}
	}
}
