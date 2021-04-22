using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Mancala
{
	/// <summary>
	/// Summary description for frmRules.
	/// </summary>
	public class frmRules : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox rtbRules;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmRules()
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rtbRules = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// rtbRules
			// 
			this.rtbRules.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbRules.Location = new System.Drawing.Point(0, 0);
			this.rtbRules.Name = "rtbRules";
			this.rtbRules.ReadOnly = true;
			this.rtbRules.Size = new System.Drawing.Size(464, 368);
			this.rtbRules.TabIndex = 0;
			this.rtbRules.Text = "";
			// 
			// frmRules
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(464, 368);
			this.Controls.Add(this.rtbRules);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRules";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rules";
			this.Load += new System.EventHandler(this.frmRules_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmRules_Load(object sender, System.EventArgs e)
		{
			rtbRules.LoadFile("man-rules.rtf");
		}
	}
}
