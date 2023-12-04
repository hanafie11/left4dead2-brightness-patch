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

namespace han_l4dbfix.Classes
{

	public class clsFunction : IDisposable
	{
		private string targetPath = Application.StartupPath + "\\left4dead2\\cfg\\video.txt",
			backupPath = Application.StartupPath + "\\left4dead2\\cfg\\video.bak.txt",
			textPatch = "\"setting.mat_tonemapping_occlusion_use_stencil\"		\"1\"";
		
		public void Dispose()
		{/*Release Some Memories*/
		}
		public void goToUrl(string url)
		{
			try {
				var process = new Process(); //
				process.StartInfo.FileName = url;				
				process.Start();
				process.Dispose();
			} catch (Exception e) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
			
		private void startInAdmin(string filepath)
		{
			DialogResult confirmRestart = MessageBox.Show("Administrator Privileges Required, do you want to start this tool in Admin Mode?",
				                              "Accesss Denied", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			
			if (confirmRestart == DialogResult.Yes) {
				try {
					var process = new Process();
					process.StartInfo.FileName = filepath;
					process.StartInfo.UseShellExecute = true;
					process.StartInfo.Verb = "runas";
					process.Start();
					process.Dispose();
					
					Application.Exit();
				} catch (Exception e) {
					MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		private string[] readFile(string filePath)
		{
			try {
				return File.ReadAllLines(filePath);			 
			} catch (Exception e) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return new string[0]; 
			}
		}
		
		private bool backupTarget()
		{
			try {
				if (File.Exists(backupPath)) {
					File.Delete(backupPath);
				}
				
				File.Copy(targetPath, backupPath);
				return true;
			} catch (Exception e) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		
		public void patchTarget(TextBox log)
		{
			string[] txtLines = readFile(targetPath); // Array For video.txt contents
			short arrlen = (short)txtLines.Length;
			
			if (arrlen == 0 || arrlen > 24) {
				log.Text = "[ERROR] The file content is empty, missing or too long." + Environment.NewLine;
				return; 
			}				
			
			log.Clear();
			log.AppendText("[CHECKING FILE]");
			
			foreach (string line in txtLines) {
				if (line.Contains(textPatch)) { 
					log.AppendText(" Patch is not needed yet." + Environment.NewLine);
					return;
				}
			}
			
			log.AppendText(" OK" + Environment.NewLine);
			
			log.AppendText("[CREATING BACKUP]");
			log.AppendText(backupTarget() ? " Succeed!" : " Failed!");
			log.AppendText(Environment.NewLine);
			
			log.AppendText("[PATCHING]");
			try {
				txtLines[arrlen - 1] = txtLines[arrlen - 1].Replace('}', ' '); // remove last line
				txtLines[arrlen - 1] += Environment.NewLine + "\t" + textPatch + Environment.NewLine + "}"; // Add patch code
				//txtLines.SetValue(textPatch + " }", arrlen - 1);
				File.WriteAllLines(targetPath, txtLines); // write into video.txt
				log.AppendText(" Succeed!" + Environment.NewLine);
			} catch (UnauthorizedAccessException) {
				startInAdmin(Application.ExecutablePath);
				log.AppendText(" Failed!" + Environment.NewLine + Environment.NewLine + "ACCESS DENIED - Try to run this tool as Administrator");
				return;
			} catch (Exception e) {
				log.AppendText(" Failed!" + Environment.NewLine);
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		
		public void restoreBackup()
		{
			try {
				if (File.Exists(backupPath)) { 
					File.Delete(targetPath); 
					File.Copy(backupPath, targetPath); 
					MessageBox.Show("File video.txt has been successfully recovered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					MessageBox.Show("Backup file doesn't exist!", "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} catch (UnauthorizedAccessException) {
				startInAdmin(Application.ExecutablePath);
			} catch (Exception e) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void openVideotxt() {
			goToUrl(targetPath);
		}
	}
}
