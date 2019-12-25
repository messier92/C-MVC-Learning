using System;
using System.Windows.Forms;

namespace CalculatorApp_Tut2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Button button_eight;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Display = new System.Windows.Forms.Label();
            this.button_c = new System.Windows.Forms.Button();
            this.button_ce = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_seven = new System.Windows.Forms.Button();
            this.button_nine = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_four = new System.Windows.Forms.Button();
            this.button_five = new System.Windows.Forms.Button();
            this.button_six = new System.Windows.Forms.Button();
            this.button_multi = new System.Windows.Forms.Button();
            this.button_one = new System.Windows.Forms.Button();
            this.button_two = new System.Windows.Forms.Button();
            this.button_three = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_deci = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_plusminus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeSkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            button_eight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Display, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_c, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_ce, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_equal, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_seven, 0, 2);
            this.tableLayoutPanel1.Controls.Add(button_eight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_nine, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_div, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_four, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_five, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_six, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_multi, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_one, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_two, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_three, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_subtract, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_plus, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_deci, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_plusminus, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 128);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 413);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Display, 4);
            this.Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(3, 0);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(452, 86);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Display.UseMnemonic = false;
            // 
            // button_c
            // 
            this.button_c.Location = new System.Drawing.Point(3, 89);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(106, 59);
            this.button_c.TabIndex = 1;
            this.button_c.Text = "C";
            this.button_c.UseVisualStyleBackColor = true;
            this.button_c.Click += new System.EventHandler(this.button_c_Click);
            // 
            // button_ce
            // 
            this.button_ce.Location = new System.Drawing.Point(117, 89);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(108, 59);
            this.button_ce.TabIndex = 2;
            this.button_ce.Text = "CE";
            this.button_ce.UseVisualStyleBackColor = true;
            this.button_ce.Click += new System.EventHandler(this.button_ce_Click);
            // 
            // button_equal
            // 
            this.button_equal.Location = new System.Drawing.Point(345, 89);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(110, 59);
            this.button_equal.TabIndex = 3;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_seven
            // 
            this.button_seven.Location = new System.Drawing.Point(3, 154);
            this.button_seven.Name = "button_seven";
            this.button_seven.Size = new System.Drawing.Size(106, 59);
            this.button_seven.TabIndex = 4;
            this.button_seven.Text = "7";
            this.button_seven.UseVisualStyleBackColor = true;
            this.button_seven.Click += new System.EventHandler(this.button_seven_Click);
            // 
            // button_eight
            // 
            button_eight.AutoSize = true;
            button_eight.Location = new System.Drawing.Point(117, 154);
            button_eight.Name = "button_eight";
            button_eight.Size = new System.Drawing.Size(108, 59);
            button_eight.TabIndex = 5;
            button_eight.Text = "8";
            button_eight.UseVisualStyleBackColor = true;
            button_eight.Click += new System.EventHandler(this.button_eight_Click);
            // 
            // button_nine
            // 
            this.button_nine.Location = new System.Drawing.Point(231, 154);
            this.button_nine.Name = "button_nine";
            this.button_nine.Size = new System.Drawing.Size(107, 59);
            this.button_nine.TabIndex = 6;
            this.button_nine.Text = "9";
            this.button_nine.UseVisualStyleBackColor = true;
            this.button_nine.Click += new System.EventHandler(this.button_nine_Click);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(345, 154);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(110, 59);
            this.button_div.TabIndex = 7;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_four
            // 
            this.button_four.Location = new System.Drawing.Point(3, 219);
            this.button_four.Name = "button_four";
            this.button_four.Size = new System.Drawing.Size(106, 59);
            this.button_four.TabIndex = 8;
            this.button_four.Text = "4";
            this.button_four.UseVisualStyleBackColor = true;
            this.button_four.Click += new System.EventHandler(this.button_four_Click);
            // 
            // button_five
            // 
            this.button_five.Location = new System.Drawing.Point(117, 219);
            this.button_five.Name = "button_five";
            this.button_five.Size = new System.Drawing.Size(108, 59);
            this.button_five.TabIndex = 9;
            this.button_five.Text = "5";
            this.button_five.UseVisualStyleBackColor = true;
            this.button_five.Click += new System.EventHandler(this.button_five_Click);
            // 
            // button_six
            // 
            this.button_six.Location = new System.Drawing.Point(231, 219);
            this.button_six.Name = "button_six";
            this.button_six.Size = new System.Drawing.Size(107, 59);
            this.button_six.TabIndex = 10;
            this.button_six.Text = "6";
            this.button_six.UseVisualStyleBackColor = true;
            this.button_six.Click += new System.EventHandler(this.button_six_Click);
            // 
            // button_multi
            // 
            this.button_multi.Location = new System.Drawing.Point(345, 219);
            this.button_multi.Name = "button_multi";
            this.button_multi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_multi.Size = new System.Drawing.Size(110, 59);
            this.button_multi.TabIndex = 11;
            this.button_multi.Text = "X";
            this.button_multi.UseVisualStyleBackColor = true;
            this.button_multi.Click += new System.EventHandler(this.button_multi_Click);
            // 
            // button_one
            // 
            this.button_one.Location = new System.Drawing.Point(3, 284);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(108, 59);
            this.button_one.TabIndex = 12;
            this.button_one.Text = "1";
            this.button_one.UseVisualStyleBackColor = true;
            this.button_one.Click += new System.EventHandler(this.button_one_Click);
            // 
            // button_two
            // 
            this.button_two.Location = new System.Drawing.Point(117, 284);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(108, 59);
            this.button_two.TabIndex = 13;
            this.button_two.Text = "2";
            this.button_two.UseVisualStyleBackColor = true;
            this.button_two.Click += new System.EventHandler(this.button_two_Click);
            // 
            // button_three
            // 
            this.button_three.Location = new System.Drawing.Point(231, 284);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(107, 59);
            this.button_three.TabIndex = 14;
            this.button_three.Text = "3";
            this.button_three.UseVisualStyleBackColor = true;
            this.button_three.Click += new System.EventHandler(this.button_three_Click);
            // 
            // button_subtract
            // 
            this.button_subtract.Location = new System.Drawing.Point(345, 284);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(110, 59);
            this.button_subtract.TabIndex = 15;
            this.button_subtract.Text = "-";
            this.button_subtract.UseVisualStyleBackColor = true;
            this.button_subtract.Click += new System.EventHandler(this.button_subtract_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(345, 349);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(110, 61);
            this.button_plus.TabIndex = 16;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_deci
            // 
            this.button_deci.Location = new System.Drawing.Point(231, 349);
            this.button_deci.Name = "button_deci";
            this.button_deci.Size = new System.Drawing.Size(107, 61);
            this.button_deci.TabIndex = 17;
            this.button_deci.Text = ".";
            this.button_deci.UseVisualStyleBackColor = true;
            this.button_deci.Click += new System.EventHandler(this.button_deci_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(117, 349);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(108, 61);
            this.button_0.TabIndex = 18;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_plusminus
            // 
            this.button_plusminus.Location = new System.Drawing.Point(3, 349);
            this.button_plusminus.Name = "button_plusminus";
            this.button_plusminus.Size = new System.Drawing.Size(108, 61);
            this.button_plusminus.TabIndex = 19;
            this.button_plusminus.Text = "+/-";
            this.button_plusminus.UseVisualStyleBackColor = true;
            this.button_plusminus.Click += new System.EventHandler(this.button_plusminus_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSkinToolStripMenuItem,
            this.changeBackgroundColorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changeSkinToolStripMenuItem
            // 
            this.changeSkinToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.changeSkinToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.changeSkinToolStripMenuItem.Name = "changeSkinToolStripMenuItem";
            this.changeSkinToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.changeSkinToolStripMenuItem.Text = "Change Skin";
            this.changeSkinToolStripMenuItem.Click += new System.EventHandler(this.changeSkinToolStripMenuItem_Click);
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            this.changeBackgroundColorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            this.changeBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.changeBackgroundColorToolStripMenuItem.Text = "Change Background Color";
            this.changeBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.changeBackgroundColorToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Eugene\'s Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Button button_ce;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_seven;
        private System.Windows.Forms.Button button_nine;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_four;
        private System.Windows.Forms.Button button_five;
        private System.Windows.Forms.Button button_six;
        private System.Windows.Forms.Button button_multi;
        private System.Windows.Forms.Button button_one;
        private System.Windows.Forms.Button button_two;
        private System.Windows.Forms.Button button_three;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_deci;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_plusminus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeSkinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

