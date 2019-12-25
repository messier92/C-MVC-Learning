using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELearningTest
{
    public partial class Form2 : Form
    {
        itembank my_bank = new itembank();
        item this_item = new item();
        private static Random random = new Random();
        string my_datetime;
        int current_item_index = 0;
        int max_index = 4;
        int min_index = 0;
        int correct_option;
        int this_score = 0;

        public Form2()
        {
            InitializeComponent();

            set_navigation_buttons();
            load_the_bank();

            // set initial value of count down clock
            my_datetime = string.Format("{0:00}:{1:00}", my_bank.duration_in_seconds / 3600, my_bank.duration_in_seconds % 3600 / 60);
            time_remaining.Text = my_datetime;

            if (my_bank.Randomize)
            {
                randomize_the_bank();
            }
            paint_the_screen();
        }

        public void set_navigation_buttons()
        {
            if (current_item_index == min_index)
            {
                first_item.Visible = false;
                previous_item.Visible = false;
                next_item.Visible = true;
                last_item.Visible = true;
            }
            else if (current_item_index == max_index)
            {
                first_item.Visible = true;
                previous_item.Visible = true;
                next_item.Visible = false;
                last_item.Visible = false;
            }
            else
            {
                first_item.Visible = true;
                previous_item.Visible = true;
                next_item.Visible = true;
                last_item.Visible = true;
            }
        }

        public void paint_the_screen()
        {
            set_navigation_buttons();
            set_question_number();

            // this item_number label is the one located just to the left of the stem
            item_number.Text = (current_item_index + 1).ToString();

            if (my_bank.ib[current_item_index].Is_Scored) // item is a MC question
            {
                stem.Text = my_bank.ib[current_item_index].Stem;
                if (my_bank.ib[current_item_index].Distractor3.Length > 0)
                {
                    // make all the checkboxes visible and set checked/unchecked based on previous answer
                    Option_A.Enabled = true;
                    Option_A.Visible = true;
                    Option_A.Checked = false;
                    Option_B.Enabled = true;
                    Option_B.Visible = true;
                    Option_B.Checked = false;
                    Option_C.Enabled = true;
                    Option_C.Visible = true;
                    Option_C.Checked = false;
                    Option_D.Enabled = true;
                    Option_D.Visible = true;
                    Option_D.Checked = false;

                    // randomize the option choices
                    correct_option = random.Next(3);  // 0 = a, 1 = b, 2 = c, 3 = d

                    // paint the 4 option MC item
                    switch (correct_option)
                    {
                        case 0:
                            {
                                // paint the item
                                my_bank.ib[current_item_index].Correct_Option = "A";
                                option_a_text.Text = my_bank.ib[current_item_index].Correct_Answer;
                                option_b_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_c_text.Text = my_bank.ib[current_item_index].Distractor2;
                                option_d_text.Text = my_bank.ib[current_item_index].Distractor3;

                                // handle previously checked answers
                                if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Correct_Answer)
                                {
                                    Option_A.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    Option_B.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor2)
                                {
                                    Option_C.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor3)
                                {
                                    Option_D.Checked = true;
                                }
                                break;
                            }
                        case 1:
                            {
                                my_bank.ib[current_item_index].Correct_Option = "B";
                                option_a_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_b_text.Text = my_bank.ib[current_item_index].Correct_Answer;
                                option_c_text.Text = my_bank.ib[current_item_index].Distractor2;
                                option_d_text.Text = my_bank.ib[current_item_index].Distractor3;

                                if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    Option_A.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Correct_Answer)
                                {
                                    Option_B.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor2)
                                {
                                    Option_C.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor3)
                                {
                                    Option_D.Checked = true;
                                }
                                break;
                            }
                        case 2:
                            {
                                my_bank.ib[current_item_index].Correct_Option = "C";
                                option_a_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_b_text.Text = my_bank.ib[current_item_index].Distractor2;
                                option_c_text.Text = my_bank.ib[current_item_index].Correct_Answer;
                                option_d_text.Text = my_bank.ib[current_item_index].Distractor3;

                                if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    Option_A.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor2)
                                {
                                    Option_B.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Correct_Answer)
                                {
                                    Option_C.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor3)
                                {
                                    Option_D.Checked = true;
                                }
                                break;
                            }
                        case 3:
                            {
                                my_bank.ib[current_item_index].Correct_Option = "D";
                                option_a_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_b_text.Text = my_bank.ib[current_item_index].Distractor2;
                                option_c_text.Text = my_bank.ib[current_item_index].Distractor3;
                                option_d_text.Text = my_bank.ib[current_item_index].Correct_Answer;

                                if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    Option_A.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor2)
                                {
                                    Option_B.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor3)
                                {
                                    Option_C.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Correct_Answer)
                                {
                                    Option_D.Checked = true;
                                }
                                break;
                            }
                    }
                }
                else if (my_bank.ib[current_item_index].Distractor1.Length > 0) // this is a true/false there are no three option MCs
                {
                    // make options A and B visible and enabled other two disabled and invisible
                    Option_A.Enabled = true;
                    Option_A.Visible = true;
                    Option_A.Checked = false;
                    Option_B.Enabled = true;
                    Option_B.Visible = true;
                    Option_B.Checked = false;
                    Option_C.Enabled = false;
                    Option_C.Visible = false;
                    Option_C.Checked = false;
                    Option_D.Enabled = false;
                    Option_D.Visible = false;
                    Option_D.Checked = false;

                    correct_option = random.Next(1);  // 0 = A, 1 = B
                    switch (correct_option)
                    {
                        case 0:
                            {
                                my_bank.ib[current_item_index].Correct_Option = "A";
                                option_a_text.Text = my_bank.ib[current_item_index].Correct_Answer;
                                option_b_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_c_text.Text = "";
                                option_d_text.Text = "";

                                if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Correct_Answer)
                                {
                                    Option_A.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    Option_B.Checked = true;
                                }

                                break;
                            }
                        case 1:
                            {
                                my_bank.ib[current_item_index].Correct_Option = "B";
                                option_a_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_b_text.Text = my_bank.ib[current_item_index].Correct_Answer;
                                option_c_text.Text = "";
                                option_d_text.Text = "";

                                if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    Option_A.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].Chosen_Answer == my_bank.ib[current_item_index].Correct_Answer)
                                {
                                    Option_B.Checked = true;
                                }

                                break;
                            }
                    }
                }
            }
            else // item is not scored - just HTML content
            {
                stem.Text = my_bank.ib[current_item_index].Stem;
                my_bank.ib[current_item_index].Correct_Option = "NA";
                Option_A.Enabled = false;
                Option_A.Visible = false;
                option_a_text.Text = "";
                Option_B.Enabled = false;
                Option_B.Visible = false;
                option_b_text.Text = "";
                Option_C.Enabled = false;
                Option_C.Visible = false;
                option_c_text.Text = "";
                Option_D.Enabled = false;
                Option_D.Visible = false;
                option_d_text.Text = "";
            }
        }

        public void randomize_the_bank()
        {
            // quick and dirty randomization process
            for (int i = my_bank.ib.Length - 1; i >= 0; i--)
            {
                this_item = my_bank.ib[i];
                int randomIndex = random.Next(i + 1);

                // swap the elements
                my_bank.ib[i] = new item();
                my_bank.ib[i] = my_bank.ib[randomIndex];
                my_bank.ib[randomIndex] = this_item;
            }
        }

        public void load_the_bank()
        {
            my_bank.ID = 1;
            my_bank.duration_in_seconds = 5400;  // 1.5 hours
            my_bank.passing_score = 4;
            my_bank.Randomize = true;
            my_bank.report_results = false;

            my_bank.ib[0] = new item();
            my_bank.ib[0].ID = 1;
            my_bank.ib[0].Stem = "ROYGBIV refers to the colors in what natural phenomena?";
            my_bank.ib[0].Correct_Answer = "Rainbow";
            my_bank.ib[0].Distractor1 = "Burning Coal";
            my_bank.ib[0].Distractor2 = "Steam";
            my_bank.ib[0].Distractor3 = "Coal Ash";
            my_bank.ib[0].Is_Scored = true;

            my_bank.ib[1] = new item();
            my_bank.ib[1].ID = 2;
            my_bank.ib[1].Stem = "Elong Musk is CEO of which automobile company";
            my_bank.ib[1].Correct_Answer = "Tesla";
            my_bank.ib[1].Distractor1 = "Chrysler";
            my_bank.ib[1].Distractor2 = "Volkswagon";
            my_bank.ib[1].Distractor3 = "Mercedes Benz";
            my_bank.ib[1].Is_Scored = true;

            my_bank.ib[2] = new item();
            my_bank.ib[2].ID = 3;
            my_bank.ib[2].Stem = "Tiger Woods is the winningest golfer of all time.";
            my_bank.ib[2].Correct_Answer = "False";
            my_bank.ib[2].Distractor1 = "True";
            my_bank.ib[2].Distractor2 = "";
            my_bank.ib[2].Distractor3 = "";
            my_bank.ib[2].Is_Scored = true;

            my_bank.ib[3] = new item();
            my_bank.ib[3].ID = 4;
            my_bank.ib[3].Stem = "New York City is the capital of New York State.";
            my_bank.ib[3].Correct_Answer = "False";
            my_bank.ib[3].Distractor1 = "True";
            my_bank.ib[3].Distractor2 = "";
            my_bank.ib[3].Distractor3 = "";
            my_bank.ib[3].Is_Scored = true;

            my_bank.ib[4] = new item();
            my_bank.ib[4].ID = 5;
            my_bank.ib[4].Stem = "This is a long string of HTML which would otherwise represent a bunch of e-learning content.  It may contain any web-ready content including text, video, audio or still imagery.  If the content is too long scroll bars should be automatically added to your display.";
            my_bank.ib[4].Correct_Answer = "";
            my_bank.ib[4].Distractor1 = "";
            my_bank.ib[4].Distractor2 = "";
            my_bank.ib[4].Distractor3 = "";
            my_bank.ib[4].Is_Scored = false;
        }

 
        private void set_question_number()
        {
            question_number.Text = (current_item_index + 1).ToString() + "/" + (max_index + 1).ToString();
        }

        private void score_this_test()
        {
            for (int i = 0; i < max_index; i++)
            {
                if (my_bank.ib[i].Correct_Answer == my_bank.ib[i].Chosen_Answer)
                    this_score = this_score + 1;
            }

            if (this_score >= my_bank.passing_score)
            {
                MessageBox.Show("Congratulations, you passed this test.");
            }
            else
            {
                MessageBox.Show("Sorry, you did not pass this test.");
            }
        }

        private void first_item_Click(object sender, EventArgs e)
        {
            record_previous_answer();
            current_item_index = min_index;
            paint_the_screen();
        }

        private void previous_item_Click(object sender, EventArgs e)
        {
            record_previous_answer();
            if (current_item_index > min_index)
                current_item_index = current_item_index - 1;
            paint_the_screen();
        }

        private void next_item_Click(object sender, EventArgs e)
        {
            record_previous_answer();
            if (current_item_index < max_index)
                current_item_index = current_item_index + 1;
            paint_the_screen();
        }

        private void last_item_Click(object sender, EventArgs e)
        {
            record_previous_answer();
            current_item_index = max_index;
            paint_the_screen();
        }

        private void record_previous_answer()
        {
            if (Option_A.Checked)
            {
                my_bank.ib[current_item_index].Chosen_Answer = option_a_text.Text;
            }
            else if (Option_B.Checked)
            {
                my_bank.ib[current_item_index].Chosen_Answer = option_b_text.Text;
            }
            else if (Option_C.Checked)
            {
                my_bank.ib[current_item_index].Chosen_Answer = option_c_text.Text;
            }
            else if (Option_D.Checked)
            {
                my_bank.ib[current_item_index].Chosen_Answer = option_d_text.Text;
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you certain you want to submit this exam, time still remains?",
                "Submit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {

                score_this_test();

                // shut it all down
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    Application.OpenForms[i].Close();
                }
         
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            my_bank.duration_in_seconds = my_bank.duration_in_seconds - 1;

            if (my_bank.duration_in_seconds == 0)
            {
                score_this_test();

                // shut it all down
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    Application.OpenForms[i].Close();
                }

            }

            if (my_bank.duration_in_seconds <= 300)
            {
                time_remaining.BackColor = Color.Red;  // with less than 5 minutes turn this background red
            }
            my_datetime = string.Format("{0:00}:{1:00}", my_bank.duration_in_seconds / 3600, my_bank.duration_in_seconds % 3600 / 60);
            time_remaining.Text = my_datetime;
        }
    }
}
