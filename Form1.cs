using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Mancala
{
	public class frmMancala : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Label lblPlayer1;
		private System.Windows.Forms.Label lblPlayer2;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem mnuNew;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.MenuItem mnuHelpAbout;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.ImageList imgMid;
		private System.Windows.Forms.ImageList imgEnd;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem mnuNewOneMachine;
		private System.Windows.Forms.MenuItem mnuHostNetGame;
		private System.Windows.Forms.MenuItem mnuJoinNetGame;

		private Board board;

		public frmMancala()
		{
			InitializeComponent();
			// open with all empty
			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is PictureBox && ctrl.Tag != null)
				{
					PictureBox pic = (PictureBox)ctrl;
					int iNum = Convert.ToInt32(pic.Tag);
					if (iNum != 6 && iNum != 13)
					{
                        pic.Image =  imgMid.Images[0];
                        //Image.FromFile(@"C:\Users\i517369\Downloads\Mancala-master (1)\Mancala-master\oak.jpg");
                    }
					else
					{
						pic.Image = imgEnd.Images[0];
					}	
				}
			}
		}

		private void InitialiseGame(Player one, Player two)
		{
			board = new Board(one, two);
			board.dishUpdate += new DishUpdateDelegate(OnDishUpdate);
			board.turnOver += new TurnOverDelegate(board_turnOver);
			board.gameOver += new GameOverDelegate(board_gameOver);
			board.Refresh();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMancala));
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuNew = new System.Windows.Forms.MenuItem();
            this.mnuNewOneMachine = new System.Windows.Forms.MenuItem();
            this.mnuHostNetGame = new System.Windows.Forms.MenuItem();
            this.mnuJoinNetGame = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.MenuItem();
            this.imgMid = new System.Windows.Forms.ImageList(this.components);
            this.imgEnd = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Yellow;
            this.lblMessage.Location = new System.Drawing.Point(0, 8);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(864, 23);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "Mancala";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayer1.Location = new System.Drawing.Point(32, 40);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(96, 23);
            this.lblPlayer1.TabIndex = 16;
            this.lblPlayer1.Text = "Enter Player One";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayer2.Location = new System.Drawing.Point(720, 40);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(104, 23);
            this.lblPlayer2.TabIndex = 17;
            this.lblPlayer2.Text = "Enter Player Two";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNew,
            this.menuItem4,
            this.menuItem3,
            this.mnuExit});
            this.menuItem1.Text = "&File";
            // 
            // mnuNew
            // 
            this.mnuNew.Index = 0;
            this.mnuNew.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNewOneMachine,
            this.mnuHostNetGame,
            this.mnuJoinNetGame});
            this.mnuNew.Text = "&New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuNewOneMachine
            // 
            this.mnuNewOneMachine.Index = 0;
            this.mnuNewOneMachine.Text = "Game";
            this.mnuNewOneMachine.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // mnuHostNetGame
            // 
            this.mnuHostNetGame.Index = 1;
            this.mnuHostNetGame.Text = "";
            // 
            // mnuJoinNetGame
            // 
            this.mnuJoinNetGame.Index = 2;
            this.mnuJoinNetGame.Text = "";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 3;
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.mnuHelpAbout});
            this.menuItem5.Text = "&Help";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "&Rules";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Index = 1;
            this.mnuHelpAbout.Text = "&About";
            // 
            // imgMid
            // 
            this.imgMid.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMid.ImageStream")));
            this.imgMid.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMid.Images.SetKeyName(0, "");
            this.imgMid.Images.SetKeyName(1, "");
            this.imgMid.Images.SetKeyName(2, "");
            this.imgMid.Images.SetKeyName(3, "");
            this.imgMid.Images.SetKeyName(4, "");
            this.imgMid.Images.SetKeyName(5, "");
            this.imgMid.Images.SetKeyName(6, "");
            this.imgMid.Images.SetKeyName(7, "");
            this.imgMid.Images.SetKeyName(8, "");
            this.imgMid.Images.SetKeyName(9, "");
            this.imgMid.Images.SetKeyName(10, "");
            this.imgMid.Images.SetKeyName(11, "");
            this.imgMid.Images.SetKeyName(12, "");
            // 
            // imgEnd
            // 
            this.imgEnd.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgEnd.ImageStream")));
            this.imgEnd.TransparentColor = System.Drawing.Color.Transparent;
            this.imgEnd.Images.SetKeyName(0, "");
            this.imgEnd.Images.SetKeyName(1, "");
            this.imgEnd.Images.SetKeyName(2, "");
            this.imgEnd.Images.SetKeyName(3, "");
            this.imgEnd.Images.SetKeyName(4, "");
            this.imgEnd.Images.SetKeyName(5, "");
            this.imgEnd.Images.SetKeyName(6, "");
            this.imgEnd.Images.SetKeyName(7, "");
            this.imgEnd.Images.SetKeyName(8, "");
            this.imgEnd.Images.SetKeyName(9, "");
            this.imgEnd.Images.SetKeyName(10, "");
            this.imgEnd.Images.SetKeyName(11, "");
            this.imgEnd.Images.SetKeyName(12, "");
            this.imgEnd.Images.SetKeyName(13, "");
            this.imgEnd.Images.SetKeyName(14, "");
            this.imgEnd.Images.SetKeyName(15, "");
            this.imgEnd.Images.SetKeyName(16, "");
            this.imgEnd.Images.SetKeyName(17, "");
            this.imgEnd.Images.SetKeyName(18, "");
            this.imgEnd.Images.SetKeyName(19, "");
            this.imgEnd.Images.SetKeyName(20, "");
            this.imgEnd.Images.SetKeyName(21, "");
            this.imgEnd.Images.SetKeyName(22, "");
            this.imgEnd.Images.SetKeyName(23, "");
            this.imgEnd.Images.SetKeyName(24, "");
            this.imgEnd.Images.SetKeyName(25, "");
            this.imgEnd.Images.SetKeyName(26, "");
            this.imgEnd.Images.SetKeyName(27, "");
            this.imgEnd.Images.SetKeyName(28, "");
            this.imgEnd.Images.SetKeyName(29, "");
            this.imgEnd.Images.SetKeyName(30, "");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(624, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 84);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "12";
            this.pictureBox1.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(528, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 84);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "11";
            this.pictureBox2.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(336, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 84);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "9";
            this.pictureBox3.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(432, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 84);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "10";
            this.pictureBox4.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(144, 72);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(84, 84);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "7";
            this.pictureBox5.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(240, 72);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(84, 84);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "8";
            this.pictureBox6.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(144, 184);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(84, 84);
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "5";
            this.pictureBox7.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(240, 184);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(84, 84);
            this.pictureBox8.TabIndex = 28;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "4";
            this.pictureBox8.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(336, 184);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(84, 84);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "3";
            this.pictureBox9.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(432, 184);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(84, 84);
            this.pictureBox10.TabIndex = 26;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "2";
            this.pictureBox10.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(528, 184);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(84, 84);
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "1";
            this.pictureBox11.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(624, 184);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(84, 84);
            this.pictureBox12.TabIndex = 24;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "0";
            this.pictureBox12.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(728, 72);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(84, 200);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 30;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "13";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(40, 72);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(84, 200);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 31;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "6";
            this.pictureBox14.Click += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // frmMancala
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(872, 297);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "frmMancala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mancala";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMancala());
		}

		private void OnDishUpdate(object sender, DishUpdateArgs args)
		{
			int dishNumber = 0;
			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is PictureBox && ctrl.Tag != null)
				{
					dishNumber = Convert.ToInt32(ctrl.Tag);
					if (dishNumber == args.DishNumber)
					{
						PictureBox pb = (PictureBox)ctrl;
						if (dishNumber != 6 && dishNumber != 13)
						{
							pb.Image = imgMid.Images[args.Tokens<13?args.Tokens:12];
						}
						else
						{
							pb.Image = imgEnd.Images[args.Tokens<31?args.Tokens:30];
						}
					}
				}
			}
		}

		private void PictureBox_DoubleClick(object sender, System.EventArgs e)
		{
			try 
			{
				int dishNumber = Convert.ToInt32(((PictureBox)sender).Tag);
				board.TakeTurn(dishNumber);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void board_turnOver(Player currentPlayer)
		{
			lblMessage.Text = currentPlayer.ToString() + "'s turn";
		}

		private void board_gameOver(Player winner)
		{
			if (winner == null)
				lblMessage.Text = "Drawn match";
			else
				lblMessage.Text = winner.ToString() + " wins!!!";
		}

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			board = null;
		}

		private void mnuNew_Click(object sender, System.EventArgs e)
		{

		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			frmRules frm = new frmRules();
			frm.ShowDialog();
		}

        //לחיצה על תחילת משחק מהתפריט
		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			Player one = null, two = null;
			// player one
			frmPlayerName frm = new frmPlayerName();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				one = new Player(frm.PlayerName);
			}

			frm = new frmPlayerName();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				two = new Player(frm.PlayerName);
			}

			if (two == null || one == null)
			{
				MessageBox.Show("Cannot start new game without players");
			} 
			else 
			{

				lblPlayer1.Text = one.ToString();
				lblPlayer2.Text = two.ToString();

				InitialiseGame(one, two);
			}
		}

		private void mnuHostNetGame_Click(object sender, System.EventArgs e)
		{
			lblMessage.Text = "(New Net Game) Waiting for player to join...";


		}
	}
}
