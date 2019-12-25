using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_learning_and_testing
{

    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (validate_user() == true)
            {
                MC_Item_Delivery MCD = new MC_Item_Delivery();
                MCD.Show();
                this.Hide();

            }
        }

        private Boolean validate_user()
        {
            // this would be a db lookup and probably count three attempts before you boot them out
            // we will just use a stub here
            return true;
        }
    }
}
