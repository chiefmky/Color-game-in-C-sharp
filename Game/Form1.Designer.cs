namespace Game
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.colorgamelbl = new System.Windows.Forms.Label();
			this.colorlbl = new System.Windows.Forms.Label();
			this.greatlbl = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.resultlbl = new System.Windows.Forms.Label();
			this.againbtn = new System.Windows.Forms.Button();
			this.newColorbtn = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
			this.groupBox1.Controls.Add(this.colorgamelbl);
			this.groupBox1.Controls.Add(this.colorlbl);
			this.groupBox1.Controls.Add(this.greatlbl);
			this.groupBox1.Location = new System.Drawing.Point(3, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(753, 133);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// colorgamelbl
			// 
			this.colorgamelbl.AutoSize = true;
			this.colorgamelbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colorgamelbl.Location = new System.Drawing.Point(312, 102);
			this.colorgamelbl.Name = "colorgamelbl";
			this.colorgamelbl.Size = new System.Drawing.Size(141, 28);
			this.colorgamelbl.TabIndex = 3;
			this.colorgamelbl.Text = "COLOR GAME";
			// 
			// colorlbl
			// 
			this.colorlbl.AutoSize = true;
			this.colorlbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.colorlbl.Location = new System.Drawing.Point(232, 55);
			this.colorlbl.Name = "colorlbl";
			this.colorlbl.Size = new System.Drawing.Size(148, 37);
			this.colorlbl.TabIndex = 2;
			this.colorlbl.Text = "RGB Color";
			this.colorlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// greatlbl
			// 
			this.greatlbl.AutoSize = true;
			this.greatlbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.greatlbl.Location = new System.Drawing.Point(329, 18);
			this.greatlbl.Name = "greatlbl";
			this.greatlbl.Size = new System.Drawing.Size(119, 28);
			this.greatlbl.TabIndex = 0;
			this.greatlbl.Text = "THE GREAT";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.resultlbl);
			this.groupBox2.Controls.Add(this.againbtn);
			this.groupBox2.Controls.Add(this.newColorbtn);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(3, 140);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(753, 40);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// resultlbl
			// 
			this.resultlbl.AutoSize = true;
			this.resultlbl.ForeColor = System.Drawing.Color.Black;
			this.resultlbl.Location = new System.Drawing.Point(581, 19);
			this.resultlbl.Name = "resultlbl";
			this.resultlbl.Size = new System.Drawing.Size(32, 13);
			this.resultlbl.TabIndex = 4;
			this.resultlbl.Text = "label";
			// 
			// againbtn
			// 
			this.againbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.againbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.againbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.againbtn.ForeColor = System.Drawing.Color.DarkCyan;
			this.againbtn.Location = new System.Drawing.Point(306, 10);
			this.againbtn.Name = "againbtn";
			this.againbtn.Size = new System.Drawing.Size(119, 23);
			this.againbtn.TabIndex = 3;
			this.againbtn.Text = "PLAY AGAIN?";
			this.againbtn.UseVisualStyleBackColor = true;
			this.againbtn.Click += new System.EventHandler(this.againbtn_Click);
			// 
			// newColorbtn
			// 
			this.newColorbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.newColorbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.newColorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.newColorbtn.ForeColor = System.Drawing.Color.DarkCyan;
			this.newColorbtn.Location = new System.Drawing.Point(306, 10);
			this.newColorbtn.Name = "newColorbtn";
			this.newColorbtn.Size = new System.Drawing.Size(119, 23);
			this.newColorbtn.TabIndex = 0;
			this.newColorbtn.Text = "NEW COLORS";
			this.newColorbtn.UseVisualStyleBackColor = true;
			this.newColorbtn.Click += new System.EventHandler(this.newColorbtn_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Black;
			this.groupBox3.Controls.Add(this.btn6);
			this.groupBox3.Controls.Add(this.btn5);
			this.groupBox3.Controls.Add(this.btn4);
			this.groupBox3.Controls.Add(this.btn3);
			this.groupBox3.Controls.Add(this.btn2);
			this.groupBox3.Controls.Add(this.btn1);
			this.groupBox3.ForeColor = System.Drawing.Color.Black;
			this.groupBox3.Location = new System.Drawing.Point(3, 186);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(753, 302);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// btn6
			// 
			this.btn6.BackColor = System.Drawing.Color.Gold;
			this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn6.Location = new System.Drawing.Point(484, 163);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(129, 114);
			this.btn6.TabIndex = 5;
			this.btn6.UseVisualStyleBackColor = false;
			this.btn6.Click += new System.EventHandler(this.btn6_Click);
			// 
			// btn5
			// 
			this.btn5.BackColor = System.Drawing.Color.Purple;
			this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn5.Location = new System.Drawing.Point(317, 163);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(131, 114);
			this.btn5.TabIndex = 4;
			this.btn5.UseVisualStyleBackColor = false;
			this.btn5.Click += new System.EventHandler(this.btn5_Click);
			// 
			// btn4
			// 
			this.btn4.BackColor = System.Drawing.Color.Fuchsia;
			this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btn4.FlatAppearance.BorderSize = 0;
			this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn4.Location = new System.Drawing.Point(148, 163);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(129, 114);
			this.btn4.TabIndex = 3;
			this.btn4.UseVisualStyleBackColor = false;
			this.btn4.Click += new System.EventHandler(this.btn4_Click);
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.Color.Blue;
			this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn3.Location = new System.Drawing.Point(484, 34);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(129, 114);
			this.btn3.TabIndex = 2;
			this.btn3.UseVisualStyleBackColor = false;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.Color.DarkOrange;
			this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn2.Location = new System.Drawing.Point(317, 34);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(131, 114);
			this.btn2.TabIndex = 1;
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(14)))), ((int)(((byte)(10)))));
			this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btn1.FlatAppearance.BorderSize = 0;
			this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn1.Location = new System.Drawing.Point(148, 34);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(129, 114);
			this.btn1.TabIndex = 0;
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 513);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Form1";
			this.Text = "Color Game";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label colorgamelbl;
		private System.Windows.Forms.Label colorlbl;
		private System.Windows.Forms.Label greatlbl;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button newColorbtn;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button againbtn;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Label resultlbl;
	}
}

