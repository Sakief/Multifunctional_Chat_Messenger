//--------------------------------------------------------------
//  TicTacToeWin32
//
// Author: Grant Richard (dgrichard100@hotmail.com)
//
// Copyright 2002 Grant Richard
// Permission automatically granted for personal use.
//--------------------------------------------------------------
using System;
using System.Windows.Forms;
using System.Drawing;		// needed for Color constants

namespace TicTacToeWin32
{
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button but1;
		private System.Windows.Forms.Button but2;
		private System.Windows.Forms.Button but3;
		private System.Windows.Forms.Button but4;
		private System.Windows.Forms.Button but5;
		private System.Windows.Forms.Button but6;
		private System.Windows.Forms.Button but7;
		private System.Windows.Forms.Button but8;
		private System.Windows.Forms.Button but9;
		private System.Windows.Forms.Button butPlay;

		private System.Windows.Forms.Button [] _buttonArray; 
		private bool _isX;			// to determine if X or O is current character
		private bool _isGameOver;	// if the game is over

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
			this.but1 = new System.Windows.Forms.Button();
			this.but2 = new System.Windows.Forms.Button();
			this.but3 = new System.Windows.Forms.Button();
			this.but4 = new System.Windows.Forms.Button();
			this.but5 = new System.Windows.Forms.Button();
			this.but6 = new System.Windows.Forms.Button();
			this.but7 = new System.Windows.Forms.Button();
			this.but8 = new System.Windows.Forms.Button();
			this.but9 = new System.Windows.Forms.Button();
			this.butPlay = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// but1
			// 
			this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but1.Location = new System.Drawing.Point(24, 16);
			this.but1.Name = "but1";
			this.but1.Size = new System.Drawing.Size(50, 50);
			this.but1.TabIndex = 0;
			// 
			// but2
			// 
			this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but2.Location = new System.Drawing.Point(72, 16);
			this.but2.Name = "but2";
			this.but2.Size = new System.Drawing.Size(50, 50);
			this.but2.TabIndex = 1;
			// 
			// but3
			// 
			this.but3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but3.Location = new System.Drawing.Point(120, 16);
			this.but3.Name = "but3";
			this.but3.Size = new System.Drawing.Size(50, 50);
			this.but3.TabIndex = 2;
			// 
			// but4
			// 
			this.but4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but4.Location = new System.Drawing.Point(24, 64);
			this.but4.Name = "but4";
			this.but4.Size = new System.Drawing.Size(50, 50);
			this.but4.TabIndex = 3;
			// 
			// but5
			// 
			this.but5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but5.Location = new System.Drawing.Point(72, 64);
			this.but5.Name = "but5";
			this.but5.Size = new System.Drawing.Size(50, 50);
			this.but5.TabIndex = 4;
			// 
			// but6
			// 
			this.but6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but6.Location = new System.Drawing.Point(120, 64);
			this.but6.Name = "but6";
			this.but6.Size = new System.Drawing.Size(50, 50);
			this.but6.TabIndex = 5;
			// 
			// but7
			// 
			this.but7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but7.Location = new System.Drawing.Point(24, 112);
			this.but7.Name = "but7";
			this.but7.Size = new System.Drawing.Size(50, 50);
			this.but7.TabIndex = 6;
			// 
			// but8
			// 
			this.but8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but8.Location = new System.Drawing.Point(72, 112);
			this.but8.Name = "but8";
			this.but8.Size = new System.Drawing.Size(50, 50);
			this.but8.TabIndex = 7;
			// 
			// but9
			// 
			this.but9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.but9.Location = new System.Drawing.Point(120, 112);
			this.but9.Name = "but9";
			this.but9.Size = new System.Drawing.Size(50, 50);
			this.but9.TabIndex = 8;
			// 
			// butPlay
			// 
			this.butPlay.Location = new System.Drawing.Point(56, 176);
			this.butPlay.Name = "butPlay";
			this.butPlay.TabIndex = 9;
			this.butPlay.Text = "Play";
			this.butPlay.Click += new System.EventHandler(this.butPlay_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(192, 213);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.butPlay,
																		  this.but9,
																		  this.but8,
																		  this.but7,
																		  this.but6,
																		  this.but5,
																		  this.but4,
																		  this.but3,
																		  this.but2,
																		  this.but1});
			this.Name = "Form1";
			this.Text = "Tic Tac Toe for Windows Forms";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			_buttonArray = new Button[9] {but1, but2, but3, but4, but5, but6, but7, but8, but9};

			for(int i = 0; i < 9; i++)
				this._buttonArray[i].Click += new System.EventHandler(this.ClickHandler);

			InitTicTacToe();  // set the defaults
		}

		private void butPlay_Click(object sender, System.EventArgs e)
		{
			InitTicTacToe();	
		}

		private void InitTicTacToe()
		{
			for(int i=0;i<9;i++)
			{
				_buttonArray[i].Text = "";
				_buttonArray[i].ForeColor = Color.Black;
				_buttonArray[i].BackColor = Color.LightGray;
				_buttonArray[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			}
			this._isX = true;
			this._isGameOver = false;
		}

		private void ClickHandler(object sender, System.EventArgs e)
		{
			Button tempButton = (Button)sender;
			
			if( this._isGameOver )
			{
				MessageBox.Show("Game Over...Select Play for a new game!","ERROR",MessageBoxButtons.OK);
				return;			
			}

			if( tempButton.Text != "" )	// if is it empty
			{
				MessageBox.Show("Button already has value!","ERROR",MessageBoxButtons.OK);
				return;
			}

			if( _isX )	// put the character in the Text property
				tempButton.Text = "X";
			else
				tempButton.Text = "O";

			_isX = !_isX;	// prepare for next character

			this._isGameOver = TicTacToeUtils.CheckAndProcessWinner(_buttonArray );
		}
	}
	public class TicTacToeUtils
	{
		// Winners contains all the array locations of
		// the winning combination -- if they are all 
		// either X or O (and not blank)
		static private int [,] Winners = new int[,]
				   {
						{0,1,2},
						{3,4,5},
						{6,7,8},
						{0,3,6},
						{1,4,7},
						{2,5,8},
						{0,4,8},
						{2,4,6}
				   };

		//--------------------------------------------------------------
		// CheckAndProcessWinner determines if either X or O has won.
		// Once a winner has been determined, play stops.
		//--------------------------------------------------------------
		static public bool CheckAndProcessWinner( Button [] myControls )
		{
			bool gameOver = false;
			for(int i = 0; i < 8; i++)
			{
				int a = Winners[i,0],b=Winners[i,1],c=Winners[i,2];		// get the indices
																		// of the winners

				Button b1=myControls[a], b2=myControls[b], b3=myControls[c];// just to make the 
																			// the code readable

				if(b1.Text == "" || b2.Text == "" || b3.Text == "" )	// any of the squares blank
					continue;											// try another -- no need to go further

				if(b1.Text == b2.Text && b2.Text == b3.Text )			// are they the same?
				{														// if so, they WIN!
					b1.BackColor = b2.BackColor = b3.BackColor = Color.LightCoral;
					b1.Font = b2.Font = b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Italic & System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
					gameOver = true;
					break;  // don't bother to continue
				}
			}	
			return gameOver;
		}
	}
}