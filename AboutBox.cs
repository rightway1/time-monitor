using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;

namespace cw.AboutBox
{
	/// <summary>
	/// Summary description for WinForm1.
	/// </summary>
	public class frmAbout : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;

		private frmAbout()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(80, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "TimeMonitor";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(80, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Having trouble guestimating your time recording?  Keep losing track when you\'ve b" +
                "een switching between tasks?";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 64);
            this.label4.TabIndex = 4;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(248, 184);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(136, 48);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 16);
            this.lblVersion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "(c)GISMonkey.co.uk, 2004 - 2011";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(232, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Compiled for .Net 2.0";
            // 
            // frmAbout
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(352, 212);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbout";
            this.Text = "About TimeMonitor";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		
		private void btnClose_Click(object sender, System.EventArgs e)
		{
            this.Close();
		}

		internal static void ShowAboutForm( IWin32Window Owner )
		{
			System.Diagnostics.Debug.Assert( ( Owner != null ) || !( Owner is IWin32Window ) ,
			"AboutForm.AboutForm.ShowAboutForm MUST be supplied with a valid parent window" );

			frmAbout theForm = new frmAbout();

			theForm.ShowDialog( Owner );
		}

		private void frmAbout_Load(object sender, System.EventArgs e)
		{
			//Initialize About box with information about the application
			Assembly ThisAssembly = Assembly.GetExecutingAssembly();

			AssemblyName ThisAssemblyName = ThisAssembly.GetName();
			string FriendlyVersion = string.Format("{0:D}-{1:D2}" ,	ThisAssemblyName.Version.Major, ThisAssemblyName.Version.Minor );

			this.lblVersion.Text = FriendlyVersion;
			this.lblName.Text = ThisAssemblyName.Name;

		}

		
	}
}
