using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearningTest
{
    public class item
    {
        public int ID;
        public string Stem;
        public string Correct_Answer;
        public string Correct_Option = "";
        public string Chosen_Answer = "";
        public string Distractor1;
        public string Distractor2;
        public string Distractor3;
        public Boolean Is_Scored;
    }

    public class itembank
    {
        public int ID;
        public int duration_in_seconds;
        public int passing_score;
        public bool Randomize;
        public bool report_results;
        public item[] ib = new item[5];
    }
}
