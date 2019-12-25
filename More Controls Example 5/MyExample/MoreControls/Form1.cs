using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                MessageBox.Show(rb.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Eugene can code in";
            if (checkBox1.Checked) s = s + " " + checkBox1.Text;
            if (checkBox2.Checked) s = s + " " + checkBox2.Text;
            if (checkBox3.Checked) s = s + " " + checkBox3.Text;
            if (checkBox4.Checked) s = s + " " + checkBox4.Text;
            if (checkBox5.Checked) s = s + " " + checkBox5.Text;
            MessageBox.Show(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your birthday is on " + dateTimePicker1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Dogs");
            treeView1.Nodes.Add("Cats");
            treeView1.Nodes.Add("Snakes");

            treeView1.Nodes[0].Nodes.Add("Beagle");
            treeView1.Nodes[0].Nodes.Add("Husky");
            treeView1.Nodes[0].Nodes.Add("Retriever");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
    }
}
