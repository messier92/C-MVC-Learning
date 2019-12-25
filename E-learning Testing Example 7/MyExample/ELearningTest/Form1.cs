using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELearningTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Validate_user() == true)
            {
                Form2 QnsList = new Form2();
                QnsList.Show();
                this.Hide();
            }
        }

        private Boolean Validate_user()
        {
            // this would be a db lookup and probably count three attempts before you boot them out
            // we will just use a stub here
            return true;
        }
    }
    }
