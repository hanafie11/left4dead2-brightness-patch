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
		private System.Windows.Forms.Button btnOpenVideotxt;
		private System.Windows.Forms.Label lblTutorial;
		private System.Windows.Forms.Label lblLock;
		
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblTutorial = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnSubscribe = new System.Windows.Forms.Button();
			this.btnOpenVideotxt = new System.Windows.Forms.Button();
			this.lblLock = new System.Windows.Forms.Label();
			this.lblVisitChnl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.lblRestore = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnQuit = new System.Windows.Forms.Button();
			this.btnPatch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
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
			// lblTutorial
			// 
			this.lblTutorial.AutoSize = true;
			this.lblTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblTutorial.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTutorial.ForeColor = System.Drawing.Color.SeaShell;
			this.lblTutorial.Location = new System.Drawing.Point(203, 269);
			this.lblTutorial.Name = "lblTutorial";
			this.lblTutorial.Size = new System.Drawing.Size(273, 14);
			this.lblTutorial.TabIndex = 9;
			this.lblTutorial.Text = "Confused? Click Here To Watch Tutorial";
			this.lblTutorial.Click += new System.EventHandler(this.LblTutorialClick);
			// 
			// btnSubscribe
			// 
			this.btnSubscribe.BackColor = System.Drawing.Color.Maroon;
			this.btnSubscribe.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSubscribe.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubscribe.ForeColor = System.Drawing.SystemColors.Control;
			this.btnSubscribe.Location = new System.Drawing.Point(392, 54);
			this.btnSubscribe.Name = "btnSubscribe";
			this.btnSubscribe.Size = new System.Drawing.Size(82, 22);
			this.btnSubscribe.TabIndex = 6;
			this.btnSubscribe.Text = "Subscibe!";
			this.toolTip1.SetToolTip(this.btnSubscribe, "Subscribe to my Youtube Channel, Hanafie11");
			this.btnSubscribe.UseVisualStyleBackColor = false;
			this.btnSubscribe.Click += new System.EventHandler(this.BtnSubscribeClick);
			// 
			// btnOpenVideotxt
			// 
			this.btnOpenVideotxt.BackColor = System.Drawing.Color.Transparent;
			this.btnOpenVideotxt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOpenVideotxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenVideotxt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenVideotxt.ForeColor = System.Drawing.Color.LawnGreen;
			this.btnOpenVideotxt.Location = new System.Drawing.Point(220, 15);
			this.btnOpenVideotxt.Name = "btnOpenVideotxt";
			this.btnOpenVideotxt.Size = new System.Drawing.Size(101, 35);
			this.btnOpenVideotxt.TabIndex = 7;
			this.btnOpenVideotxt.Text = "Open Video.txt";
			this.toolTip1.SetToolTip(this.btnOpenVideotxt, "Open Left 4 Dead 2 Video Config File");
			this.btnOpenVideotxt.UseVisualStyleBackColor = false;
			this.btnOpenVideotxt.Click += new System.EventHandler(this.BtnOpenVideotxtClick);
			this.btnOpenVideotxt.MouseEnter += new System.EventHandler(this.BtnOpenVideotxtMouseEnter);
			this.btnOpenVideotxt.MouseLeave += new System.EventHandler(this.BtnOpenVideotxtMouseLeave);
			// 
			// lblLock
			// 
			this.lblLock.AutoSize = true;
			this.lblLock.BackColor = System.Drawing.Color.DarkGreen;
			this.lblLock.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblLock.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLock.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblLock.Location = new System.Drawing.Point(6, 36);
			this.lblLock.Name = "lblLock";
			this.lblLock.Size = new System.Drawing.Size(154, 14);
			this.lblLock.TabIndex = 8;
			this.lblLock.Text = "> Lock Video.txt File";
			this.toolTip1.SetToolTip(this.lblLock, "Lock / Unlock Video.txt from any changes");
			this.lblLock.Click += new System.EventHandler(this.LblLockClick);
			// 
			// lblVisitChnl
			// 
			this.lblVisitChnl.AutoSize = true;
			this.lblVisitChnl.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblVisitChnl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVisitChnl.ForeColor = System.Drawing.Color.SeaShell;
			this.lblVisitChnl.Location = new System.Drawing.Point(18, 269);
			this.lblVisitChnl.Name = "lblVisitChnl";
			this.lblVisitChnl.Size = new System.Drawing.Size(119, 14);
			this.lblVisitChnl.TabIndex = 8;
			this.lblVisitChnl.Text = "Visit My Channel";
			this.lblVisitChnl.Click += new System.EventHandler(this.LblVisitChnlClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LawnGreen;
			this.label1.Location = new System.Drawing.Point(80, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(330, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Left 4 Dead 2 - Brightness Patch";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.LawnGreen;
			this.label2.Location = new System.Drawing.Point(80, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 14);
			this.label2.TabIndex = 3;
			this.label2.Text = "Version 1.6 | By. Hanafie11";
			// 
			// txtLog
			// 
			this.txtLog.BackColor = System.Drawing.Color.Black;
			this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLog.ForeColor = System.Drawing.Color.LawnGreen;
			this.txtLog.Location = new System.Drawing.Point(12, 82);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.Size = new System.Drawing.Size(462, 112);
			this.txtLog.TabIndex = 4;
			this.txtLog.Text = "[>] Hello There!\r\n[>] ONLY DOWNLOAD THIS PROGRAM FROM MY CHANNEL \'Hanafie11\'\r\n[>]" +
	" Close your Left 4 Dead 2 if it\'s open\r\n[>] Click \'Patch Now\' Button To Begin";
			// 
			// lblRestore
			// 
			this.lblRestore.AutoSize = true;
			this.lblRestore.BackColor = System.Drawing.Color.DarkGreen;
			this.lblRestore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblRestore.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRestore.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblRestore.Location = new System.Drawing.Point(6, 16);
			this.lblRestore.Name = "lblRestore";
			this.lblRestore.Size = new System.Drawing.Size(182, 14);
			this.lblRestore.TabIndex = 7;
			this.lblRestore.Text = "> Restore Previous Backup";
			this.lblRestore.Click += new System.EventHandler(this.LblRestoreClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblLock);
			this.groupBox1.Controls.Add(this.btnQuit);
			this.groupBox1.Controls.Add(this.lblRestore);
			this.groupBox1.Controls.Add(this.btnOpenVideotxt);
			this.groupBox1.Controls.Add(this.btnPatch);
			this.groupBox1.Location = new System.Drawing.Point(12, 200);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(462, 60);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// btnQuit
			// 
			this.btnQuit.BackColor = System.Drawing.Color.Transparent;
			this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuit.ForeColor = System.Drawing.Color.LawnGreen;
			this.btnQuit.Location = new System.Drawing.Point(405, 15);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(49, 35);
			this.btnQuit.TabIndex = 0;
			this.btnQuit.TabStop = false;
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
			this.btnPatch.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPatch.ForeColor = System.Drawing.Color.LawnGreen;
			this.btnPatch.Location = new System.Drawing.Point(326, 15);
			this.btnPatch.Name = "btnPatch";
			this.btnPatch.Size = new System.Drawing.Size(75, 35);
			this.btnPatch.TabIndex = 1;
			this.btnPatch.Text = "Patch Now";
			this.btnPatch.UseVisualStyleBackColor = false;
			this.btnPatch.Click += new System.EventHandler(this.BtnPatchClick);
			this.btnPatch.MouseEnter += new System.EventHandler(this.BtnPatchMouseEnter);
			this.btnPatch.MouseLeave += new System.EventHandler(this.BtnPatchMouseLeave);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(487, 295);
			this.Controls.Add(this.lblVisitChnl);
			this.Controls.Add(this.lblTutorial);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSubscribe);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
