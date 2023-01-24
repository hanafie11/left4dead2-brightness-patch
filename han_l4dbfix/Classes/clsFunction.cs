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

	public class clsFunction : IDisposable {
		private string targetPath = Application.StartupPath + "\\left4dead2\\cfg\\video.txt",
			backupPath = Application.StartupPath + "\\left4dead2\\cfg\\video.bak.txt",
			textPatch = "\"setting.mat_tonemapping_occlusion_use_stencil\"		\"1\"";
		
		public void Dispose ( ) {/*Release Some Memories*/
		}
		public void goToUrl (string url) {
			try {	
				Process.Start(url);
			} catch ( Exception e ) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private string[] readFile (string filePath) {
			try {
				return File.ReadAllLines(filePath);			 
			} catch ( Exception e ) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return new string[1];
			}
		}
		
		private bool backupTarget ( ) {
			try {
				if ( File.Exists(backupPath) ) { // Jika file backup ada, hapus yang lama
					File.Delete(backupPath);
				}
				
				File.Copy(targetPath, backupPath);
				return true;
			} catch ( Exception e ) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		
		public void patchTarget (TextBox log) {
			log.Clear();
			// Cek Apakah textPatch ada di dalam baris Video.txt
			
			// Jika ada keluar dari sub
			
			// Jika tidak ada lakukan backup file dulu, lalu inject textPatch kedalam file Video.txt
			log.AppendText("[CREATING BACKUP]" + Environment.NewLine);
			log.AppendText(backupTarget() ? "[>] Backup Successfully" : "[>] Backup Failed" + Environment.NewLine);
		}
		
		public void restoreBackup ( ) {
			try {
				if ( File.Exists(backupPath) ) { // check apakah file backup ada
					File.Delete(targetPath); // hapus file video.txt yang terbaru
					File.Copy(backupPath, targetPath); // copy dan rename file backup menjadi video.txt
					MessageBox.Show("File video.txt has been successfully recovered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					MessageBox.Show("Backup file doesn't exist!", "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} catch ( Exception e ) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
