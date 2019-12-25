using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationExample
{
    public partial class Form1 : Form
    {
        enum Direction
        {
            Left, Right, Up, Down
        }

        int x_position, y_position;
        int my_height, my_width;
        int max_height = 500, max_width = 500;
        int min_height = 50, min_width = 50;
        Boolean size_is_expanding = true;
        Boolean arrow_keys_active = true;
        string animation_mode = "none_of_these";
        string size_or_move = "spin";
        Direction my_direction;
        Image img;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // jump to location of mouse at time of left button click
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Left = e.X;
                pictureBox1.Top = e.Y;
            }
        }

        private void changeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void resizeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = 150;
            pictureBox1.Width = 250;
            pictureBox1.Top = 150;
            pictureBox1.Left = 250;
            animation_mode = "size";
        }

        private void rotateImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = 150;
            pictureBox1.Width = 250;
            pictureBox1.Top = 150;
            pictureBox1.Left = 250;
            animation_mode = "spin";
        }

        private void arrowKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrow_keys_active = true;
            pictureBox1.Height = 150;
            pictureBox1.Width = 250;
            pictureBox1.Top = 150;
            pictureBox1.Left = 250;
            animation_mode = "move";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            arrow_keys_active = false;
            pictureBox1.Height = 150;
            pictureBox1.Width = 250;
            pictureBox1.Top = 150;
            pictureBox1.Left = 250;
            animation_mode = "move";    
        }

        private void singleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoubleBuffered = false;
        }

        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        public Form1()
        {
            InitializeComponent();
            my_height = 50;
            my_width = 50;
            my_direction = Direction.Right;
            img = pictureBox1.Image;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (animation_mode == "size")
            {
                if (my_height < max_height && my_width < max_width && size_is_expanding)
                {

                    my_height = my_height + 10;
                    my_width = my_width + 10;

                }
                else if (my_height == max_height && my_width < max_width && size_is_expanding)
                {

                    my_width = my_width + 10;

                }
                else if (my_height == max_height && my_width == max_width)
                {

                    my_height = my_height - 10;
                    my_width = my_width - 10;
                    size_is_expanding = false;

                }
                else if (my_height > min_height && my_width > min_width)
                {

                    my_height = my_height - 10;
                    my_width = my_width - 10;

                }
                else if (my_width > min_width)
                {

                    my_width = my_width - 10;

                }
                else if (my_height == min_height && my_width == min_width)
                {
                    my_height = my_height + 10;
                    my_width = my_width + 10;
                    size_is_expanding = true;
                }

                pictureBox1.Height = my_height;
                pictureBox1.Width = my_width;

            }

            else if (animation_mode == "move" && arrow_keys_active == true)

            {

                if (my_direction == Direction.Right)
                {
                    x_position = x_position + 10;
                }
                else if (my_direction == Direction.Left)
                {
                    x_position = x_position - 10;
                }
                else if (my_direction == Direction.Up)
                {
                    y_position = y_position - 10;
                }
                else if (my_direction == Direction.Down)
                {
                    y_position = y_position + 10;
                }

                pictureBox1.Left = x_position;
                pictureBox1.Top = y_position;
            }
            else if (animation_mode == "spin")  // animation_mode = spin
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = img;
            }

            Invalidate();  //  repaint based on old paint no longer valid
        }

    }
}
