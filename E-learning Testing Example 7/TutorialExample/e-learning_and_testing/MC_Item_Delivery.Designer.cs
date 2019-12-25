namespace e_learning_and_testing
{
    partial class MC_Item_Delivery
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.time_remaining = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.question_number = new System.Windows.Forms.Label();
            this.last_item = new System.Windows.Forms.Button();
            this.next_item = new System.Windows.Forms.Button();
            this.previous_item = new System.Windows.Forms.Button();
            this.first_item = new System.Windows.Forms.Button();

            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Option_A = new System.Windows.Forms.RadioButton();
            this.Option_D = new System.Windows.Forms.RadioButton();
            this.Option_C = new System.Windows.Forms.RadioButton();
            this.Option_B = new System.Windows.Forms.RadioButton();
            this.item_number = new System.Windows.Forms.Label();
            this.stem = new System.Windows.Forms.Label();
            this.option_a_text = new System.Windows.Forms.Label();
            this.option_b_text = new System.Windows.Forms.Label();
            this.option_c_text = new System.Windows.Forms.Label();
            this.option_d_text = new System.Windows.Forms.Label();
          

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::e_learning_and_testing.Properties.Resources.Ricks_swell_testing;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.time_remaining);
            this.panel1.Controls.Add(this.submit_button);
            this.panel1.Controls.Add(this.question_number);
            this.panel1.Controls.Add(this.last_item);
            this.panel1.Controls.Add(this.next_item);
            this.panel1.Controls.Add(this.previous_item);
            this.panel1.Controls.Add(this.first_item);
            this.panel1.Location = new System.Drawing.Point(299, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 133);
            this.panel1.TabIndex = 1;
            // 
            // time_remaining
            // 
            this.time_remaining.AutoSize = true;
            this.time_remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_remaining.Location = new System.Drawing.Point(458, 56);
            this.time_remaining.Name = "time_remaining";
            this.time_remaining.Size = new System.Drawing.Size(150, 69);
            this.time_remaining.TabIndex = 7;
            this.time_remaining.Text = "1:30";
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.Red;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.Color.White;
            this.submit_button.Location = new System.Drawing.Point(271, 66);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(122, 46);
            this.submit_button.TabIndex = 6;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.Submit_button_Click);
            // 
            // question_number
            // 
            this.question_number.AutoSize = true;
            this.question_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_number.Location = new System.Drawing.Point(12, 56);
            this.question_number.Name = "question_number";
            this.question_number.Size = new System.Drawing.Size(218, 69);
            this.question_number.TabIndex = 2;
            this.question_number.Text = "12 / 50";
            // 
            // last_item
            // 
            this.last_item.BackColor = System.Drawing.Color.Blue;
            this.last_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_item.ForeColor = System.Drawing.Color.White;
            this.last_item.Location = new System.Drawing.Point(548, 23);
            this.last_item.Name = "last_item";
            this.last_item.Size = new System.Drawing.Size(90, 30);
            this.last_item.TabIndex = 5;
            this.last_item.Text = ">>";
            this.last_item.UseVisualStyleBackColor = false;
            this.last_item.Click += new System.EventHandler(this.Last_item_Click);
            // 
            // next_item
            // 
            this.next_item.BackColor = System.Drawing.Color.Blue;
            this.next_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_item.ForeColor = System.Drawing.Color.White;
            this.next_item.Location = new System.Drawing.Point(429, 23);
            this.next_item.Name = "next_item";
            this.next_item.Size = new System.Drawing.Size(90, 30);
            this.next_item.TabIndex = 4;
            this.next_item.Text = ">";
            this.next_item.UseVisualStyleBackColor = false;
            this.next_item.Click += new System.EventHandler(this.Next_item_Click);
            // 
            // previous_item
            // 
            this.previous_item.BackColor = System.Drawing.Color.Blue;
            this.previous_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_item.ForeColor = System.Drawing.Color.White;
            this.previous_item.Location = new System.Drawing.Point(140, 23);
            this.previous_item.Name = "previous_item";
            this.previous_item.Size = new System.Drawing.Size(90, 30);
            this.previous_item.TabIndex = 3;
            this.previous_item.Text = "<";
            this.previous_item.UseVisualStyleBackColor = false;
            this.previous_item.Click += new System.EventHandler(this.Previous_item_Click);
            // 
            // first_item
            // 
            this.first_item.BackColor = System.Drawing.Color.Blue;
            this.first_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_item.ForeColor = System.Drawing.Color.White;
            this.first_item.Location = new System.Drawing.Point(21, 23);
            this.first_item.Name = "first_item";
            this.first_item.Size = new System.Drawing.Size(90, 30);
            this.first_item.TabIndex = 2;
            this.first_item.Text = "<<";
            this.first_item.UseVisualStyleBackColor = false;

            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Option_D, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Option_C, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Option_B, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.item_number, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.option_a_text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.option_b_text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.option_c_text, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.option_d_text, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Option_A, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 165);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.67875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33031F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33031F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33031F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33031F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 466);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Option_D
            // 
            this.Option_D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Option_D.AutoSize = true;
            this.Option_D.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Option_D.Location = new System.Drawing.Point(3, 385);
            this.Option_D.Name = "Option_D";
            this.Option_D.Size = new System.Drawing.Size(194, 78);
            this.Option_D.TabIndex = 11;
            this.Option_D.TabStop = true;
            this.Option_D.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Option_D.UseVisualStyleBackColor = true;
            // 
            // Option_C
            // 
            this.Option_C.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Option_C.AutoSize = true;
            this.Option_C.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Option_C.Location = new System.Drawing.Point(3, 305);
            this.Option_C.Name = "Option_C";
            this.Option_C.Size = new System.Drawing.Size(194, 74);
            this.Option_C.TabIndex = 10;
            this.Option_C.TabStop = true;
            this.Option_C.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Option_C.UseVisualStyleBackColor = true;
            // 
            // Option_B
            // 
            this.Option_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Option_B.AutoSize = true;
            this.Option_B.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Option_B.Location = new System.Drawing.Point(3, 225);
            this.Option_B.Name = "Option_B";
            this.Option_B.Size = new System.Drawing.Size(194, 74);
            this.Option_B.TabIndex = 9;
            this.Option_B.TabStop = true;
            this.Option_B.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Option_B.UseVisualStyleBackColor = true;
            // 
            // item_number
            // 
            this.item_number.AutoSize = true;
            this.item_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_number.Location = new System.Drawing.Point(3, 0);
            this.item_number.Name = "item_number";
            this.item_number.Size = new System.Drawing.Size(194, 142);
            this.item_number.TabIndex = 0;
            this.item_number.Text = "1";
            this.item_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stem
            // 
            this.stem.AutoSize = true;
            this.stem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stem.Location = new System.Drawing.Point(203, 0);
            this.stem.Name = "stem";
            this.stem.Size = new System.Drawing.Size(778, 142);
            this.stem.TabIndex = 1;
            this.stem.Text = "label1";
            this.stem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option_a_text
            // 
            this.option_a_text.AutoSize = true;
            this.option_a_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.option_a_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_a_text.Location = new System.Drawing.Point(203, 142);
            this.option_a_text.Name = "option_a_text";
            this.option_a_text.Size = new System.Drawing.Size(778, 80);
            this.option_a_text.TabIndex = 2;
            this.option_a_text.Text = "label1";
            this.option_a_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option_b_text
            // 
            this.option_b_text.AutoSize = true;
            this.option_b_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.option_b_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_b_text.Location = new System.Drawing.Point(203, 222);
            this.option_b_text.Name = "option_b_text";
            this.option_b_text.Size = new System.Drawing.Size(778, 80);
            this.option_b_text.TabIndex = 3;
            this.option_b_text.Text = "label1";
            this.option_b_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option_c_text
            // 
            this.option_c_text.AutoSize = true;
            this.option_c_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.option_c_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_c_text.Location = new System.Drawing.Point(203, 302);
            this.option_c_text.Name = "option_c_text";
            this.option_c_text.Size = new System.Drawing.Size(778, 80);
            this.option_c_text.TabIndex = 4;
            this.option_c_text.Text = "label1";
            this.option_c_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option_d_text
            // 
            this.option_d_text.AutoSize = true;
            this.option_d_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.option_d_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_d_text.Location = new System.Drawing.Point(203, 382);
            this.option_d_text.Name = "option_d_text";
            this.option_d_text.Size = new System.Drawing.Size(778, 84);
            this.option_d_text.TabIndex = 5;
            this.option_d_text.Text = "label1";
            this.option_d_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Option_A
            // 
            this.Option_A.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Option_A.AutoSize = true;
            this.Option_A.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Option_A.Location = new System.Drawing.Point(3, 145);
            this.Option_A.Name = "Option_A";
            this.Option_A.Size = new System.Drawing.Size(194, 74);
            this.Option_A.TabIndex = 8;
            this.Option_A.TabStop = true;
            this.Option_A.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Option_A.UseVisualStyleBackColor = true;
            // 
            // MC_Item_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MC_Item_Delivery";
            this.Text = "MC_Item_Delivery";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label time_remaining;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label question_number;
        private System.Windows.Forms.Button last_item;
        private System.Windows.Forms.Button next_item;
        private System.Windows.Forms.Button previous_item;
        private System.Windows.Forms.Button first_item;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label item_number;
        private System.Windows.Forms.Label stem;
        private System.Windows.Forms.Label option_a_text;
        private System.Windows.Forms.Label option_b_text;
        private System.Windows.Forms.Label option_c_text;
        private System.Windows.Forms.Label option_d_text;
        private System.Windows.Forms.RadioButton Option_D;
        private System.Windows.Forms.RadioButton Option_C;
        private System.Windows.Forms.RadioButton Option_B;
        private System.Windows.Forms.RadioButton Option_A;
    }
}