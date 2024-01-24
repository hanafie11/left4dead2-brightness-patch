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
using System.Text.RegularExpressions;

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
		
		public bool isConfigFileLocked(Label lblLockStat)
		{
			try {
				FileInfo finfo = new FileInfo(targetPath);
				if (!finfo.Exists) return false;
				
				if (finfo.IsReadOnly == true) {
					lblLockStat.Text = "> Unlock Video.txt File";
					return true;
				} else if (finfo.IsReadOnly == false) {
					lblLockStat.Text = "> Lock Video.txt File";
					return false;
				} else {
					return false;
				}
				
			} catch (Exception e) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		
		public void patchTarget(TextBox log, Label lblLockStat)
		{
			string[] txtLines = readFile(targetPath); // Array For video.txt contents
			short arrlen = (short)txtLines.Length;
			
			if (arrlen == 0 || arrlen > 24) {
				log.Text = "[ERROR] The file is empty, missing or it's content is too long." + Environment.NewLine;
				return;
			}
			
			log.Clear();
			log.AppendText("[CHECKING FILE]");
			
			if (!txtLines[arrlen-1].Contains("}")) {
				log.AppendText(" File content structure is wrong " + Environment.NewLine);
				return;
			}
			
			const string reduceMultiSpace = @"[ ]{2,}";
			var textPatchReduced = Regex.Replace(textPatch.Replace("\t", " "), reduceMultiSpace, " "); // Remove multiple spaces
			string lineText;
			foreach (string line in txtLines) {
				lineText = Regex.Replace(line.Replace("\t", " "), reduceMultiSpace, " ");
				if (lineText.Contains(textPatchReduced)) {
					log.AppendText(" Patch is not needed yet." + Environment.NewLine);
					return;
				}
			}
			
			if (isConfigFileLocked(lblLockStat) == true) {
				log.AppendText(" FILE PROTECTED!, UNLOCKING . . ., ");
				lockOrUnlock(lblLockStat, false);
			}
			
			log.AppendText(" OK" + Environment.NewLine);
			
			log.AppendText("[CREATING BACKUP]");
			log.AppendText(backupTarget() ? " Succeed!" : " Failed!");
			log.AppendText(Environment.NewLine);
			
			log.AppendText("[PATCHING]");
			try {
				txtLines[arrlen - 1] = txtLines[arrlen - 1].Replace('}', ' '); // remove last line
				txtLines[arrlen - 1] += "\t" + textPatch + Environment.NewLine + "}"; // Add patch code
				//txtLines.SetValue(textPatch + " }", arrlen - 1);
				File.WriteAllLines(targetPath, txtLines); // write into video.txt
				log.AppendText(" Succeed!" + Environment.NewLine);
				
				DialogResult lockConfirm = MessageBox.Show("Do You Want To Lock Video.txt From Any Changes?", "Set File To Readonly Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				
				if (lockConfirm == DialogResult.Yes) {
					FileInfo fInfo = new FileInfo(targetPath);
					if (!fInfo.IsReadOnly) {
						fInfo.IsReadOnly = true;
						log.AppendText("[INFO] File Video.txt has been Locked!" + Environment.NewLine);
					}
				}
				
				isConfigFileLocked(lblLockStat);
				
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
		
		public void restoreBackup(Label lblLockStat)
		{
			try {
				if (File.Exists(backupPath)) {
					
					if(isConfigFileLocked(lblLockStat) == true) lockOrUnlock(lblLockStat, false);
					
					File.Delete(targetPath);
					File.Copy(backupPath, targetPath);
					MessageBox.Show("File video.txt has been successfully recovered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					MessageBox.Show("Backup file doesn't exist!", "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
					isConfigFileLocked(lblLockStat);
				}
			} catch (UnauthorizedAccessException) {
				startInAdmin(Application.ExecutablePath);
			} catch (Exception e) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void openVideotxt()
		{
			goToUrl(targetPath);
		}
		
		public void lockOrUnlock(Label lblLockStat, bool showMessage)
		{
			try {
				FileInfo fInfo = new FileInfo(targetPath);
				if (isConfigFileLocked(lblLockStat) == true) {
					fInfo.IsReadOnly = false;
					if(showMessage == true)
						MessageBox.Show("File video.txt has been Unlocked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					fInfo.IsReadOnly = true;
					if(showMessage == true)
						MessageBox.Show("File video.txt has been Locked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				
				isConfigFileLocked(lblLockStat);
			} catch (Exception e) {
				MessageBox.Show(e.Message, "Oops Something Went Wrong" + isConfigFileLocked(lblLockStat), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
