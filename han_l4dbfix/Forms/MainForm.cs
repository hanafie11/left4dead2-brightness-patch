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

namespace han_l4dbfix {
	public partial class MainForm : Form {
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage (IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture ( );
		
		private clsFunction Func;
		public MainForm() {
			InitializeComponent();
			Func = new clsFunction(); // Instansiasi Objek Func
			
			txtLog.Select(0, 0);
		}
		
		void BtnQuitClick (object sender, EventArgs e) {
			Application.Exit();
		}
		
		void BtnPatchMouseEnter (object sender, EventArgs e) {
			btnPatch.BackColor = Color.DarkGreen;
		}
		
		void BtnPatchMouseLeave (object sender, EventArgs e) {
			btnPatch.BackColor = Color.Transparent;
		}
		
		void BtnQuitMouseEnter (object sender, EventArgs e) {
			btnQuit.BackColor = Color.DarkGreen;
		}
		
		void BtnQuitMouseLeave (object sender, EventArgs e) {
			btnQuit.BackColor = Color.Transparent;
		}
		
		void LblCloseClick (object sender, EventArgs e) {
			Application.Exit();
		}
		
		void MainFormMouseDown (object sender, MouseEventArgs e) {
			if ( e.Button == MouseButtons.Left ) {
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		
		void BtnPatchClick (object sender, EventArgs e) {

		}
		
		void LblVisitChnlClick (object sender, EventArgs e) {
			Func.goToUrl("https://www.youtube.com/@Hanafie11");
			Func.Dispose();
		}
		
		void BtnSubscribeClick (object sender, EventArgs e) {
			Func.goToUrl("https://www.youtube.com/@Hanafie11?sub_confirmation=1");
			Func.Dispose();
		}

	}
}
