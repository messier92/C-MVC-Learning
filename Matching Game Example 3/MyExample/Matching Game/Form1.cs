using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_Game
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
            salutationCB.SelectedIndex = 0;
            firstNameTB.Text = null;
            firstNameError.Text = null;
            lastNameTB.Text = null;
            lastNameError.Text = null;
            emailTB.Text = null;
            emailError.Text = null; 
            salutationError.ForeColor = Color.Black;
            firstNameError.ForeColor = Color.Black;
            lastNameError.ForeColor = Color.Black;
            emailError.ForeColor = Color.Black;
        }

        
        private void UserProfile_Load(object sender, EventArgs e)
        {
            salutationCB.SelectedIndex = 0;
            firstNameTB.Text = null;
            firstNameError.Text = null;
            lastNameTB.Text = null;
            lastNameError.Text = null;
            emailTB.Text = null;
            emailError.Text = null;
            firstNameError.ForeColor = Color.Black;
            lastNameError.ForeColor = Color.Black;
            emailError.ForeColor = Color.Black;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataOK())
            {
                this.Hide();
                MatchingGame mg = new MatchingGame(firstNameTB.Text);
                mg.ShowDialog();
            }
        }

        public bool DataOK()
        {
            bool rv = true;
            
            if (salutationCB.Text.Length == 0) 
            {
                salutationError.Text = "Salutation is required.";
                salutationError.ForeColor = Color.Red;
                rv = false;            
            }
            if (firstNameTB.Text.Length == 0 || firstNameTB.Text is null)
            {
                firstNameError.Text = "First name is required.";
                firstNameError.ForeColor = Color.Red;
                rv = false; 
            }
            if (lastNameTB.Text.Length == 0 || lastNameTB.Text is null)
            {
                lastNameError.Text = "Last name is required.";
                lastNameError.ForeColor = Color.Red;
                rv = false;
            }
            if (emailTB.Text.Length == 0 || emailTB.Text is null)
            {
                emailError.Text = "E-mail is required.";
                emailError.ForeColor = Color.Red;
                rv = false;
            }
            if (isValidEmail(emailTB.Text) == false)
            {
                emailError.Text = "E-mail does not pass validation standards.";
                emailError.ForeColor = Color.Red;
                rv = false;            
            }
            return rv;
        }

        bool isValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            salutationCB.SelectedIndex = 0;
            firstNameTB.Text = null;
            firstNameError.Text = null;
            lastNameTB.Text = null;
            lastNameError.Text = null;
            emailTB.Text = null;
            emailError.Text = null;
            salutationError.ForeColor = Color.Black;
            firstNameError.ForeColor = Color.Black;
            lastNameError.ForeColor = Color.Black;
            emailError.ForeColor = Color.Black;
        }
    }
}
