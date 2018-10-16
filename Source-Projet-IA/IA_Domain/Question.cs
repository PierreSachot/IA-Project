using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Question
    {
        public string Title { get; set; }
        public List<string> LAnswers { get; set; }

        public Question(string title, List<string> lAnswers)
        {
            Title = title;
            LAnswers = lAnswers;
        }
    }
}
