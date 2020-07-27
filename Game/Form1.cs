using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
	public partial class Form1 : Form
	{
		//Variables declaration
		private int numSquares = 6;
		private string LabelOutput = "";
		private List<Color> colors;
		private byte r, g, b;
		private Color pickedColor;
		private Random RandColor = new Random();


		public Form1()
		{
			InitializeComponent();
			resetGame();
		}

		/// <summary>
		/// Button thant generate new colors
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void newColorbtn_Click(object sender, EventArgs e)
		{
			resetGame();
		}
	
		/// <summary>
		/// boxes clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn1_Click(object sender, EventArgs e)
		{
			if (pickedColor.Name == colors[0].Name)
			{
				winSetup();

			}

			else
			{
				btn1.BackColor = Color.Black;
				resultlbl.Text = "Incorrect";
			}
		}
		
		private void btn2_Click(object sender, EventArgs e)
		{
			if (pickedColor.Name == colors[1].Name)
			{
				winSetup();
			}

			else
			{
				btn2.BackColor = Color.Black;
				resultlbl.Text = "Incorrect";
			}

		}

		private void btn3_Click(object sender, EventArgs e)
		{
			if (pickedColor.Name == colors[2].Name)
			{
				winSetup();
			}

			else
			{
				btn3.BackColor = Color.Black;
				resultlbl.Text = "Incorrect";
			}
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			if (pickedColor.Name == colors[3].Name)
			{
				winSetup();
			}

			else
			{
				btn4.BackColor = Color.Black;
				resultlbl.Text = "Incorrect";
			}
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			if (pickedColor.Name == colors[4].Name)
			{
				winSetup();
			}

			else
			{
				btn5.BackColor = Color.Black;
				resultlbl.Text = "Incorrect";
			}
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			if (pickedColor.Name == colors[5].Name)
			{
				winSetup();
			}

			else
			{
				btn6.BackColor = Color.Black;
				resultlbl.Text = "Incorrect";
			}
		}
		private void winSetup()
		{
			btn1.BackColor = pickedColor;
			btn2.BackColor = pickedColor;
			btn3.BackColor = pickedColor;
			btn4.BackColor = pickedColor;
			btn5.BackColor = pickedColor;
			btn6.BackColor = pickedColor;
			groupBox1.BackColor = pickedColor;

			newColorbtn.Visible = false;
			againbtn.Visible = true;
			resultlbl.Text = "Correct. You Won!";
		}

		/// <summary>
		///  button Play again clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void againbtn_Click(object sender, EventArgs e)
		{
			resetGame();
		}

		/// <summary>
		/// Assigned color to each box
		/// </summary>
		private void generateRandomColors()
		{
			btn1.BackColor = colors[0];
			btn2.BackColor = colors[1];
			btn3.BackColor = colors[2];
			btn4.BackColor = colors[3];
			btn5.BackColor = colors[4];
			btn6.BackColor = colors[5];
		}
				
		/// <summary>
		/// Generate color list
		/// </summary>
		private void randomColor()
		{
			int r, g, b;
		    colors = new List<Color>();
			int idx = RandColor.Next(0, numSquares);
			pickedColor = new Color();

			for (int i=0; i < numSquares; i++)
			{
				r = RandColor.Next(0, 256);
				g = RandColor.Next(0, 256);
				b = RandColor.Next(0, 256);
				colors.Add(Color.FromArgb(r, g, b));
			}

			pickedColor = colors[idx];	
		}

		/// <summary>
		/// resetting game
		/// </summary>
		private void resetGame()
		{
			
			againbtn.Visible = false;
			newColorbtn.Visible = true;
			randomColor();
			
			r = pickedColor.R;
			g = pickedColor.G;
			b = pickedColor.B;

			LabelOutput = string.Format("RGB({0},{1},{2})", new object[] { r, g, b });
			colorlbl.Text = LabelOutput;
			generateRandomColors();
			groupBox1.BackColor = Color.DarkCyan;
			resultlbl.Text = "";

		}
		
	}
}
