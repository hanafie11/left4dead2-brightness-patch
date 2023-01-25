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
				return new string[1]; // kembalikan array kosong
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
			// Cek Apakah textPatch ada di dalam baris Video.txt
			string[] txtLines = readFile(targetPath);
			short arrlen = (short)txtLines.Length;
			if ( arrlen == 1 ) return; // cek apakah isi file video.txt tidak kosong
			
			log.Clear();
			log.AppendText("[CHECKING FILE]");
			
			foreach(string line in txtLines) {
				if(line.Contains(textPatch)) { // Jika ada keluar dari sub
					log.AppendText(" Patch is not needed yet." + Environment.NewLine);
					return;
				}
			}
			
			log.AppendText(" OK" + Environment.NewLine);
			// Jika tidak ada lakukan backup file dulu, lalu inject textPatch kedalam file Video.txt
			log.AppendText("[CREATING BACKUP]");
			log.AppendText(backupTarget() ? " Succeed!" : " Failed!");
			log.AppendText(Environment.NewLine);
			
			log.AppendText("[PATCHING]");
			try {
				txtLines.SetValue(textPatch + " }", arrlen -1);
				File.WriteAllLines(targetPath, txtLines);
				log.AppendText(" Succeed!" + Environment.NewLine);
			} catch (Exception e) {
				log.AppendText(" Failed!" + Environment.NewLine);
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
