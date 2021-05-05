/*
 * Created by SharpDevelop.
 * User: Colin
 * Date: 31/10/2007
 * Time: 17:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Data;
namespace cw.TimeMonitor
{
	partial class frmTime
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTime));
			this.lblTotal = new System.Windows.Forms.Label();
			this.cmdClear8 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.cmdClear7 = new System.Windows.Forms.Button();
			this.cmdClear6 = new System.Windows.Forms.Button();
			this.cmdClear5 = new System.Windows.Forms.Button();
			this.cmdClear4 = new System.Windows.Forms.Button();
			this.cmdClear3 = new System.Windows.Forms.Button();
			this.cmdClear2 = new System.Windows.Forms.Button();
			this.cmdClear1 = new System.Windows.Forms.Button();
			this.lblTime8 = new System.Windows.Forms.Label();
			this.lblTime7 = new System.Windows.Forms.Label();
			this.lblTime6 = new System.Windows.Forms.Label();
			this.lblTime5 = new System.Windows.Forms.Label();
			this.lblTime4 = new System.Windows.Forms.Label();
			this.lblTime3 = new System.Windows.Forms.Label();
			this.lblTime2 = new System.Windows.Forms.Label();
			this.lblTime1 = new System.Windows.Forms.Label();
			this.cmdStartStop8 = new System.Windows.Forms.Button();
			this.cmdStartStop7 = new System.Windows.Forms.Button();
			this.cmdStartStop6 = new System.Windows.Forms.Button();
			this.cmdStartStop5 = new System.Windows.Forms.Button();
			this.cmdStartStop4 = new System.Windows.Forms.Button();
			this.cmdStartStop3 = new System.Windows.Forms.Button();
			this.cmdStartStop2 = new System.Windows.Forms.Button();
			this.cmdStartStop1 = new System.Windows.Forms.Button();
			this.txtTask8 = new System.Windows.Forms.TextBox();
			this.txtTask7 = new System.Windows.Forms.TextBox();
			this.txtTask6 = new System.Windows.Forms.TextBox();
			this.txtTask5 = new System.Windows.Forms.TextBox();
			this.txtTask4 = new System.Windows.Forms.TextBox();
			this.txtTask3 = new System.Windows.Forms.TextBox();
			this.txtTask2 = new System.Windows.Forms.TextBox();
			this.txtTask1 = new System.Windows.Forms.TextBox();
			this.lblTask2 = new System.Windows.Forms.Label();
			this.lblTask3 = new System.Windows.Forms.Label();
			this.lblTask4 = new System.Windows.Forms.Label();
			this.lblTask5 = new System.Windows.Forms.Label();
			this.lblTask6 = new System.Windows.Forms.Label();
			this.lblTask7 = new System.Windows.Forms.Label();
			this.lblTask8 = new System.Windows.Forms.Label();
			this.lblTask1 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuClearAll = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenu1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTotal
			// 
			this.lblTotal.Location = new System.Drawing.Point(235, 227);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(40, 16);
			this.lblTotal.TabIndex = 81;
			this.lblTotal.Text = "00:00";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdClear8
			// 
			this.cmdClear8.ImageIndex = 2;
			this.cmdClear8.ImageList = this.imageList1;
			this.cmdClear8.Location = new System.Drawing.Point(291, 195);
			this.cmdClear8.Name = "cmdClear8";
			this.cmdClear8.Size = new System.Drawing.Size(24, 18);
			this.cmdClear8.TabIndex = 80;
			this.cmdClear8.Click += new System.EventHandler(this.CmdClear8Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "start.ico");
			this.imageList1.Images.SetKeyName(1, "stop.ico");
			this.imageList1.Images.SetKeyName(2, "Clear.ico");
			// 
			// cmdClear7
			// 
			this.cmdClear7.ImageIndex = 2;
			this.cmdClear7.ImageList = this.imageList1;
			this.cmdClear7.Location = new System.Drawing.Point(291, 171);
			this.cmdClear7.Name = "cmdClear7";
			this.cmdClear7.Size = new System.Drawing.Size(24, 18);
			this.cmdClear7.TabIndex = 79;
			this.cmdClear7.Click += new System.EventHandler(this.CmdClear7Click);
			// 
			// cmdClear6
			// 
			this.cmdClear6.ImageIndex = 2;
			this.cmdClear6.ImageList = this.imageList1;
			this.cmdClear6.Location = new System.Drawing.Point(291, 147);
			this.cmdClear6.Name = "cmdClear6";
			this.cmdClear6.Size = new System.Drawing.Size(24, 18);
			this.cmdClear6.TabIndex = 78;
			this.cmdClear6.Click += new System.EventHandler(this.CmdClear6Click);
			// 
			// cmdClear5
			// 
			this.cmdClear5.ImageIndex = 2;
			this.cmdClear5.ImageList = this.imageList1;
			this.cmdClear5.Location = new System.Drawing.Point(291, 123);
			this.cmdClear5.Name = "cmdClear5";
			this.cmdClear5.Size = new System.Drawing.Size(24, 18);
			this.cmdClear5.TabIndex = 77;
			this.cmdClear5.Click += new System.EventHandler(this.CmdClear5Click);
			// 
			// cmdClear4
			// 
			this.cmdClear4.ImageIndex = 2;
			this.cmdClear4.ImageList = this.imageList1;
			this.cmdClear4.Location = new System.Drawing.Point(291, 99);
			this.cmdClear4.Name = "cmdClear4";
			this.cmdClear4.Size = new System.Drawing.Size(24, 18);
			this.cmdClear4.TabIndex = 76;
			this.cmdClear4.Click += new System.EventHandler(this.CmdClear4Click);
			// 
			// cmdClear3
			// 
			this.cmdClear3.ImageIndex = 2;
			this.cmdClear3.ImageList = this.imageList1;
			this.cmdClear3.Location = new System.Drawing.Point(291, 75);
			this.cmdClear3.Name = "cmdClear3";
			this.cmdClear3.Size = new System.Drawing.Size(24, 18);
			this.cmdClear3.TabIndex = 75;
			this.cmdClear3.Click += new System.EventHandler(this.CmdClear3Click);
			// 
			// cmdClear2
			// 
			this.cmdClear2.ImageIndex = 2;
			this.cmdClear2.ImageList = this.imageList1;
			this.cmdClear2.Location = new System.Drawing.Point(291, 51);
			this.cmdClear2.Name = "cmdClear2";
			this.cmdClear2.Size = new System.Drawing.Size(24, 18);
			this.cmdClear2.TabIndex = 74;
			this.cmdClear2.Click += new System.EventHandler(this.CmdClear2Click);
			// 
			// cmdClear1
			// 
			this.cmdClear1.ImageIndex = 2;
			this.cmdClear1.ImageList = this.imageList1;
			this.cmdClear1.Location = new System.Drawing.Point(291, 27);
			this.cmdClear1.Name = "cmdClear1";
			this.cmdClear1.Size = new System.Drawing.Size(24, 18);
			this.cmdClear1.TabIndex = 73;
			this.cmdClear1.Click += new System.EventHandler(this.CmdClear1Click);
			// 
			// lblTime8
			// 
			this.lblTime8.Location = new System.Drawing.Point(235, 195);
			this.lblTime8.Name = "lblTime8";
			this.lblTime8.Size = new System.Drawing.Size(40, 16);
			this.lblTime8.TabIndex = 72;
			this.lblTime8.Text = "0:00";
			this.lblTime8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTime7
			// 
			this.lblTime7.Location = new System.Drawing.Point(235, 171);
			this.lblTime7.Name = "lblTime7";
			this.lblTime7.Size = new System.Drawing.Size(40, 16);
			this.lblTime7.TabIndex = 71;
			this.lblTime7.Text = "0:00";
			this.lblTime7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTime6
			// 
			this.lblTime6.Location = new System.Drawing.Point(235, 147);
			this.lblTime6.Name = "lblTime6";
			this.lblTime6.Size = new System.Drawing.Size(40, 16);
			this.lblTime6.TabIndex = 70;
			this.lblTime6.Text = "0:00";
			this.lblTime6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTime5
			// 
			this.lblTime5.Location = new System.Drawing.Point(235, 123);
			this.lblTime5.Name = "lblTime5";
			this.lblTime5.Size = new System.Drawing.Size(40, 16);
			this.lblTime5.TabIndex = 69;
			this.lblTime5.Text = "0:00";
			this.lblTime5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTime4
			// 
			this.lblTime4.Location = new System.Drawing.Point(235, 99);
			this.lblTime4.Name = "lblTime4";
			this.lblTime4.Size = new System.Drawing.Size(40, 16);
			this.lblTime4.TabIndex = 68;
			this.lblTime4.Text = "0:00";
			this.lblTime4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTime3
			// 
			this.lblTime3.Location = new System.Drawing.Point(235, 75);
			this.lblTime3.Name = "lblTime3";
			this.lblTime3.Size = new System.Drawing.Size(40, 16);
			this.lblTime3.TabIndex = 67;
			this.lblTime3.Text = "0:00";
			this.lblTime3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTime2
			// 
			this.lblTime2.Location = new System.Drawing.Point(235, 51);
			this.lblTime2.Name = "lblTime2";
			this.lblTime2.Size = new System.Drawing.Size(40, 16);
			this.lblTime2.TabIndex = 66;
			this.lblTime2.Text = "0:00";
			this.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTime1
			// 
			this.lblTime1.Location = new System.Drawing.Point(235, 27);
			this.lblTime1.Name = "lblTime1";
			this.lblTime1.Size = new System.Drawing.Size(40, 16);
			this.lblTime1.TabIndex = 65;
			this.lblTime1.Text = "0:00";
			this.lblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdStartStop8
			// 
			this.cmdStartStop8.ImageIndex = 0;
			this.cmdStartStop8.ImageList = this.imageList1;
			this.cmdStartStop8.Location = new System.Drawing.Point(187, 195);
			this.cmdStartStop8.Name = "cmdStartStop8";
			this.cmdStartStop8.Size = new System.Drawing.Size(32, 18);
			this.cmdStartStop8.TabIndex = 64;
			this.cmdStartStop8.Click += new System.EventHandler(this.CmdStartStop8Click);
			// 
			// cmdStartStop7
			// 
			this.cmdStartStop7.ImageIndex = 0;
			this.cmdStartStop7.ImageList = this.imageList1;
			this.cmdStartStop7.Location = new System.Drawing.Point(187, 171);
			this.cmdStartStop7.Name = "cmdStartStop7";
			this.cmdStartStop7.Size = new System.Drawing.Size(32, 18);
			this.cmdStartStop7.TabIndex = 63;
			this.cmdStartStop7.Click += new System.EventHandler(this.CmdStartStop7Click);
			// 
			// cmdStartStop6
			// 
			this.cmdStartStop6.ImageIndex = 0;
			this.cmdStartStop6.ImageList = this.imageList1;
			this.cmdStartStop6.Location = new System.Drawing.Point(187, 147);
			this.cmdStartStop6.Name = "cmdStartStop6";
			this.cmdStartStop6.Size = new System.Drawing.Size(32, 18);
			this.cmdStartStop6.TabIndex = 62;
			this.cmdStartStop6.Click += new System.EventHandler(this.CmdStartStop6Click);
			// 
			// cmdStartStop5
			// 
			this.cmdStartStop5.ImageIndex = 0;
			this.cmdStartStop5.ImageList = this.imageList1;
			this.cmdStartStop5.Location = new System.Drawing.Point(187, 123);
			this.cmdStartStop5.Name = "cmdStartStop5";
			this.cmdStartStop5.Size = new System.Drawing.Size(32, 18);
			this.cmdStartStop5.TabIndex = 61;
			this.cmdStartStop5.Click += new System.EventHandler(this.CmdStartStop5Click);
			// 
			// cmdStartStop4
			// 
			this.cmdStartStop4.ImageIndex = 0;
			this.cmdStartStop4.ImageList = this.imageList1;
			this.cmdStartStop4.Location = new System.Drawing.Point(187, 99);
			this.cmdStartStop4.Name = "cmdStartStop4";
			this.cmdStartStop4.Size = new System.Drawing.Size(32, 18);
			this.cmdStartStop4.TabIndex = 60;
			this.cmdStartStop4.Click += new System.EventHandler(this.CmdStartStop4Click);
			// 
			// cmdStartStop3
			// 
			this.cmdStartStop3.ImageIndex = 0;
			this.cmdStartStop3.ImageList = this.imageList1;
			this.cmdStartStop3.Location = new System.Drawing.Point(187, 75);
			this.cmdStartStop3.Name = "cmdStartStop3";
			this.cmdStartStop3.Size = new System.Drawing.Size(32, 18);
			this.cmdStartStop3.TabIndex = 59;
			this.cmdStartStop3.Click += new System.EventHandler(this.CmdStartStop3Click);
			// 
			// cmdStartStop2
			// 
			this.cmdStartStop2.ImageIndex = 0;
			this.cmdStartStop2.ImageList = this.imageList1;
			this.cmdStartStop2.Location = new System.Drawing.Point(187, 51);
			this.cmdStartStop2.Name = "cmdStartStop2";
			this.cmdStartStop2.Size = new System.Drawing.Size(32, 18);
			this.cmdStartStop2.TabIndex = 58;
			this.cmdStartStop2.Click += new System.EventHandler(this.CmdStartStop2Click);
			// 
			// cmdStartStop1
			// 
			this.cmdStartStop1.ImageIndex = 0;
			this.cmdStartStop1.ImageList = this.imageList1;
			this.cmdStartStop1.Location = new System.Drawing.Point(187, 27);
			this.cmdStartStop1.Name = "cmdStartStop1";
			this.cmdStartStop1.Size = new System.Drawing.Size(32, 18);
			this.cmdStartStop1.TabIndex = 57;
			this.cmdStartStop1.Click += new System.EventHandler(this.CmdStartStop1Click);
			// 
			// txtTask8
			// 
			this.txtTask8.Location = new System.Drawing.Point(43, 195);
			this.txtTask8.Name = "txtTask8";
			this.txtTask8.Size = new System.Drawing.Size(136, 20);
			this.txtTask8.TabIndex = 56;
			this.txtTask8.Text = "Task...";
			// 
			// txtTask7
			// 
			this.txtTask7.Location = new System.Drawing.Point(43, 171);
			this.txtTask7.Name = "txtTask7";
			this.txtTask7.Size = new System.Drawing.Size(136, 20);
			this.txtTask7.TabIndex = 55;
			this.txtTask7.Text = "Task...";
			// 
			// txtTask6
			// 
			this.txtTask6.Location = new System.Drawing.Point(43, 147);
			this.txtTask6.Name = "txtTask6";
			this.txtTask6.Size = new System.Drawing.Size(136, 20);
			this.txtTask6.TabIndex = 54;
			this.txtTask6.Text = "Task...";
			// 
			// txtTask5
			// 
			this.txtTask5.Location = new System.Drawing.Point(43, 123);
			this.txtTask5.Name = "txtTask5";
			this.txtTask5.Size = new System.Drawing.Size(136, 20);
			this.txtTask5.TabIndex = 53;
			this.txtTask5.Text = "Task...";
			// 
			// txtTask4
			// 
			this.txtTask4.Location = new System.Drawing.Point(43, 99);
			this.txtTask4.Name = "txtTask4";
			this.txtTask4.Size = new System.Drawing.Size(136, 20);
			this.txtTask4.TabIndex = 52;
			this.txtTask4.Text = "Task...";
			// 
			// txtTask3
			// 
			this.txtTask3.Location = new System.Drawing.Point(43, 75);
			this.txtTask3.Name = "txtTask3";
			this.txtTask3.Size = new System.Drawing.Size(136, 20);
			this.txtTask3.TabIndex = 51;
			this.txtTask3.Text = "Task...";
			// 
			// txtTask2
			// 
			this.txtTask2.Location = new System.Drawing.Point(43, 51);
			this.txtTask2.Name = "txtTask2";
			this.txtTask2.Size = new System.Drawing.Size(136, 20);
			this.txtTask2.TabIndex = 50;
			this.txtTask2.Text = "Task...";
			// 
			// txtTask1
			// 
			this.txtTask1.Location = new System.Drawing.Point(43, 27);
			this.txtTask1.Name = "txtTask1";
			this.txtTask1.Size = new System.Drawing.Size(136, 20);
			this.txtTask1.TabIndex = 49;
			this.txtTask1.Text = "Task...";
			// 
			// lblTask2
			// 
			this.lblTask2.Location = new System.Drawing.Point(11, 51);
			this.lblTask2.Name = "lblTask2";
			this.lblTask2.Size = new System.Drawing.Size(16, 16);
			this.lblTask2.TabIndex = 48;
			this.lblTask2.Text = "2)";
			// 
			// lblTask3
			// 
			this.lblTask3.Location = new System.Drawing.Point(11, 75);
			this.lblTask3.Name = "lblTask3";
			this.lblTask3.Size = new System.Drawing.Size(16, 16);
			this.lblTask3.TabIndex = 47;
			this.lblTask3.Text = "3)";
			// 
			// lblTask4
			// 
			this.lblTask4.Location = new System.Drawing.Point(11, 99);
			this.lblTask4.Name = "lblTask4";
			this.lblTask4.Size = new System.Drawing.Size(16, 16);
			this.lblTask4.TabIndex = 46;
			this.lblTask4.Text = "4)";
			// 
			// lblTask5
			// 
			this.lblTask5.Location = new System.Drawing.Point(11, 123);
			this.lblTask5.Name = "lblTask5";
			this.lblTask5.Size = new System.Drawing.Size(16, 16);
			this.lblTask5.TabIndex = 45;
			this.lblTask5.Text = "5)";
			// 
			// lblTask6
			// 
			this.lblTask6.Location = new System.Drawing.Point(11, 147);
			this.lblTask6.Name = "lblTask6";
			this.lblTask6.Size = new System.Drawing.Size(16, 16);
			this.lblTask6.TabIndex = 44;
			this.lblTask6.Text = "6)";
			// 
			// lblTask7
			// 
			this.lblTask7.Location = new System.Drawing.Point(11, 171);
			this.lblTask7.Name = "lblTask7";
			this.lblTask7.Size = new System.Drawing.Size(16, 16);
			this.lblTask7.TabIndex = 43;
			this.lblTask7.Text = "7)";
			// 
			// lblTask8
			// 
			this.lblTask8.Location = new System.Drawing.Point(11, 195);
			this.lblTask8.Name = "lblTask8";
			this.lblTask8.Size = new System.Drawing.Size(16, 16);
			this.lblTask8.TabIndex = 42;
			this.lblTask8.Text = "8)";
			// 
			// lblTask1
			// 
			this.lblTask1.Location = new System.Drawing.Point(11, 27);
			this.lblTask1.Name = "lblTask1";
			this.lblTask1.Size = new System.Drawing.Size(16, 16);
			this.lblTask1.TabIndex = 41;
			this.lblTask1.Text = "1)";
			// 
			// mainMenu1
			// 
			this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mainMenu1.Location = new System.Drawing.Point(0, 0);
			this.mainMenu1.Name = "mainMenu1";
			this.mainMenu1.Size = new System.Drawing.Size(330, 24);
			this.mainMenu1.TabIndex = 82;
			this.mainMenu1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mnuLoad,
									this.mnuSave,
									this.mnuClearAll,
									this.mnuExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// mnuLoad
			// 
			this.mnuLoad.Name = "mnuLoad";
			this.mnuLoad.Size = new System.Drawing.Size(139, 22);
			this.mnuLoad.Text = "Load Tasks";
			this.mnuLoad.Click += new System.EventHandler(this.MnuLoadClick);
			// 
			// mnuSave
			// 
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.Size = new System.Drawing.Size(139, 22);
			this.mnuSave.Text = "Save Tasks";
			this.mnuSave.Click += new System.EventHandler(this.MnuSaveClick);
			// 
			// mnuClearAll
			// 
			this.mnuClearAll.Name = "mnuClearAll";
			this.mnuClearAll.Size = new System.Drawing.Size(139, 22);
			this.mnuClearAll.Text = "Clear All";
			this.mnuClearAll.Click += new System.EventHandler(this.MnuClearAllClick);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(139, 22);
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.MnuExitClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mnuAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(114, 22);
			this.mnuAbout.Text = "About";
			this.mnuAbout.Click += new System.EventHandler(this.MnuAboutClick);
			// 
			// frmTime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 266);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.cmdClear8);
			this.Controls.Add(this.cmdClear7);
			this.Controls.Add(this.cmdClear6);
			this.Controls.Add(this.cmdClear5);
			this.Controls.Add(this.cmdClear4);
			this.Controls.Add(this.cmdClear3);
			this.Controls.Add(this.cmdClear2);
			this.Controls.Add(this.cmdClear1);
			this.Controls.Add(this.lblTime8);
			this.Controls.Add(this.lblTime7);
			this.Controls.Add(this.lblTime6);
			this.Controls.Add(this.lblTime5);
			this.Controls.Add(this.lblTime4);
			this.Controls.Add(this.lblTime3);
			this.Controls.Add(this.lblTime2);
			this.Controls.Add(this.lblTime1);
			this.Controls.Add(this.cmdStartStop8);
			this.Controls.Add(this.cmdStartStop7);
			this.Controls.Add(this.cmdStartStop6);
			this.Controls.Add(this.cmdStartStop5);
			this.Controls.Add(this.cmdStartStop4);
			this.Controls.Add(this.cmdStartStop3);
			this.Controls.Add(this.cmdStartStop2);
			this.Controls.Add(this.cmdStartStop1);
			this.Controls.Add(this.txtTask8);
			this.Controls.Add(this.txtTask7);
			this.Controls.Add(this.txtTask6);
			this.Controls.Add(this.txtTask5);
			this.Controls.Add(this.txtTask4);
			this.Controls.Add(this.txtTask3);
			this.Controls.Add(this.txtTask2);
			this.Controls.Add(this.txtTask1);
			this.Controls.Add(this.lblTask2);
			this.Controls.Add(this.lblTask3);
			this.Controls.Add(this.lblTask4);
			this.Controls.Add(this.lblTask5);
			this.Controls.Add(this.lblTask6);
			this.Controls.Add(this.lblTask7);
			this.Controls.Add(this.lblTask8);
			this.Controls.Add(this.lblTask1);
			this.Controls.Add(this.mainMenu1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenu1;
			this.Name = "frmTime";
			this.Text = "TimeMonitor";
			this.mainMenu1.ResumeLayout(false);
			this.mainMenu1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuClearAll;
		private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripMenuItem mnuLoad;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MenuStrip mainMenu1;
		private System.Windows.Forms.Label lblTask1;
		private System.Windows.Forms.Label lblTask8;
		private System.Windows.Forms.Label lblTask7;
		private System.Windows.Forms.Label lblTask6;
		private System.Windows.Forms.Label lblTask5;
		private System.Windows.Forms.Label lblTask4;
		private System.Windows.Forms.Label lblTask3;
		private System.Windows.Forms.Label lblTask2;
		private System.Windows.Forms.TextBox txtTask1;
		private System.Windows.Forms.TextBox txtTask2;
		private System.Windows.Forms.TextBox txtTask3;
		private System.Windows.Forms.TextBox txtTask4;
		private System.Windows.Forms.TextBox txtTask5;
		private System.Windows.Forms.TextBox txtTask6;
		private System.Windows.Forms.TextBox txtTask7;
		private System.Windows.Forms.TextBox txtTask8;
		private System.Windows.Forms.Button cmdStartStop1;
		private System.Windows.Forms.Button cmdStartStop2;
		private System.Windows.Forms.Button cmdStartStop3;
		private System.Windows.Forms.Button cmdStartStop4;
		private System.Windows.Forms.Button cmdStartStop5;
		private System.Windows.Forms.Button cmdStartStop6;
		private System.Windows.Forms.Button cmdStartStop7;
		private System.Windows.Forms.Button cmdStartStop8;
		private System.Windows.Forms.Label lblTime1;
		private System.Windows.Forms.Label lblTime2;
		private System.Windows.Forms.Label lblTime3;
		private System.Windows.Forms.Label lblTime4;
		private System.Windows.Forms.Label lblTime5;
		private System.Windows.Forms.Label lblTime6;
		private System.Windows.Forms.Label lblTime7;
		private System.Windows.Forms.Label lblTime8;
		private System.Windows.Forms.Button cmdClear1;
		private System.Windows.Forms.Button cmdClear2;
		private System.Windows.Forms.Button cmdClear3;
		private System.Windows.Forms.Button cmdClear4;
		private System.Windows.Forms.Button cmdClear5;
		private System.Windows.Forms.Button cmdClear6;
		private System.Windows.Forms.Button cmdClear7;
		private System.Windows.Forms.Button cmdClear8;
		private System.Windows.Forms.Label lblTotal;
		private DateTime  m_StartTime;
		private int m_CurrButton = 0;
		private Label[] m_TimeLabels;
		private Button[] m_StartButtons;
		private Button[] m_ClearButtons;
		private TextBox[] m_TaskBoxes;
		
	}
}
