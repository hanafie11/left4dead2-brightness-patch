/*
 * Created by SharpDevelop.
 * User: Hanafie11
 * Date: 20/01/2023
 * Time: 15:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace han_l4dbfix.Classes {

	public class clsFunction : IDisposable{
		private string targetPath = Application.StartupPath + "\\left4dead2\\cfg\\Video.txt";
		
		public void Dispose () {/*Release Some Memories*/}
		public void goToUrl (string url) {
			try {	
				Process.Start(url);
			} catch (Exception e) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private string[] readFile (string filePath) {
			try {
				 return File.ReadAllLines(filePath);			 
			}catch(IOException e) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return new string[1];
			}
		}
	}
}
