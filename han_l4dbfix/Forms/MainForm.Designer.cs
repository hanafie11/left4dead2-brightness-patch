/*
 * Created by SharpDevelop.
 * User: Superuser
 * Date: 04/11/2022
 * Time: 18:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace han_l4dbfix
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Button btnPatch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		protected System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSubscribe;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblRestore;
		private System.Windows.Forms.Label lblVisitChnl;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnQuit = new System.Windows.Forms.Button();
			this.btnPatch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblVisitChnl = new System.Windows.Forms.Label();
			this.lblRestore = new System.Windows.Forms.Label();
			this.btnSubscribe = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnQuit
			// 
			this.btnQuit.BackColor = System.Drawing.Color.Transparent;
			this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuit.ForeColor = System.Drawing.Color.LawnGreen;
			this.btnQuit.Location = new System.Drawing.Point(377, 15);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(85, 35);
			this.btnQuit.TabIndex = 0;
			this.btnQuit.Text = "Quit";
			this.btnQuit.UseVisualStyleBackColor = false;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
			this.btnQuit.MouseEnter += new System.EventHandler(this.BtnQuitMouseEnter);
			this.btnQuit.MouseLeave += new System.EventHandler(this.BtnQuitMouseLeave);
			// 
			// btnPatch
			// 
			this.btnPatch.BackColor = System.Drawing.Color.Transparent;
			this.btnPatch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPatch.ForeColor = System.Drawing.Color.LawnGreen;
			this.btnPatch.Location = new System.Drawing.Point(286, 15);
			this.btnPatch.Name = "btnPatch";
			this.btnPatch.Size = new System.Drawing.Size(85, 35);
			this.btnPatch.TabIndex = 1;
			this.btnPatch.Text = "Patch Now";
			this.btnPatch.UseVisualStyleBackColor = false;
			this.btnPatch.Click += new System.EventHandler(this.BtnPatchClick);
			this.btnPatch.MouseEnter += new System.EventHandler(this.BtnPatchMouseEnter);
			this.btnPatch.MouseLeave += new System.EventHandler(this.BtnPatchMouseLeave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LawnGreen;
			this.label1.Location = new System.Drawing.Point(80, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(394, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Left 4 Dead 2 - Brightness Patch";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.LawnGreen;
			this.label2.Location = new System.Drawing.Point(82, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Version 1.0 | By. Hanafie11";
			// 
			// txtLog
			// 
			this.txtLog.BackColor = System.Drawing.Color.Black;
			this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLog.ForeColor = System.Drawing.Color.LawnGreen;
			this.txtLog.Location = new System.Drawing.Point(12, 81);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.Size = new System.Drawing.Size(468, 117);
			this.txtLog.TabIndex = 4;
			this.txtLog.Text = "[>] Hello There!\r\n[>] ONLY DOWNLOAD THIS PROGRAM FROM THE ORIGINAL SOURCE\r\n[>] Cl" +
	"ose your Left 4 Dead 2 if it\'s open\r\n[>] Click \'Patch Now\' Button To Begin";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblVisitChnl);
			this.groupBox1.Controls.Add(this.lblRestore);
			this.groupBox1.Controls.Add(this.btnSubscribe);
			this.groupBox1.Controls.Add(this.btnPatch);
			this.groupBox1.Controls.Add(this.btnQuit);
			this.groupBox1.Location = new System.Drawing.Point(12, 204);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(468, 59);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// lblVisitChnl
			// 
			this.lblVisitChnl.AutoSize = true;
			this.lblVisitChnl.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblVisitChnl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVisitChnl.ForeColor = System.Drawing.Color.SeaShell;
			this.lblVisitChnl.Location = new System.Drawing.Point(13, 37);
			this.lblVisitChnl.Name = "lblVisitChnl";
			this.lblVisitChnl.Size = new System.Drawing.Size(119, 14);
			this.lblVisitChnl.TabIndex = 8;
			this.lblVisitChnl.Text = "Visit My Channel";
			this.lblVisitChnl.Click += new System.EventHandler(this.LblVisitChnlClick);
			// 
			// lblRestore
			// 
			this.lblRestore.AutoSize = true;
			this.lblRestore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblRestore.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRestore.ForeColor = System.Drawing.Color.LightCoral;
			this.lblRestore.Location = new System.Drawing.Point(13, 16);
			this.lblRestore.Name = "lblRestore";
			this.lblRestore.Size = new System.Drawing.Size(168, 14);
			this.lblRestore.TabIndex = 7;
			this.lblRestore.Text = "Restore Previous Backup";
			this.lblRestore.Click += new System.EventHandler(this.LblRestoreClick);
			// 
			// btnSubscribe
			// 
			this.btnSubscribe.BackColor = System.Drawing.Color.Maroon;
			this.btnSubscribe.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSubscribe.ForeColor = System.Drawing.SystemColors.Control;
			this.btnSubscribe.Location = new System.Drawing.Point(195, 15);
			this.btnSubscribe.Name = "btnSubscribe";
			this.btnSubscribe.Size = new System.Drawing.Size(85, 35);
			this.btnSubscribe.TabIndex = 6;
			this.btnSubscribe.Text = "Subscibe!";
			this.toolTip1.SetToolTip(this.btnSubscribe, "Subscribe to my Youtube Channel, Hanafie11");
			this.btnSubscribe.UseVisualStyleBackColor = false;
			this.btnSubscribe.Click += new System.EventHandler(this.BtnSubscribeClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(12, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(493, 280);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "L4D2 Brightness Patch";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
