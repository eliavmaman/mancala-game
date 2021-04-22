using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Mancala
{
	/// <summary>
	/// Summary description for frmPlayerName.
	/// </summary>
	public class frmPlayerName : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnOk;
		
		private System.ComponentModel.Container components = null;

		public frmPlayerName()
		{			
			InitializeComponent();			
			this.DialogResult = DialogResult.Cancel;
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(64, 16);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(312, 20);
			this.txtName.TabIndex = 1;
			this.txtName.Text = "";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(168, 48);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "&Ok";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// frmPlayerName
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(408, 80);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPlayerName";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Enter Player\'s Name";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		public string PlayerName
		{
			get { return this.txtName.Text; }
		}
	}
}
