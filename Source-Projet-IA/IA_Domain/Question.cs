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
        public string ImgURL { get; set; }
        public List<string> LAnswers { get; set; }
        public int CorrectAnswer { get; set; }

        public Question(string title, string imgURL, List<string> lAnswers, int correctAnswer)
        {
            Title = title;
            ImgURL = imgURL;
            LAnswers = lAnswers;
            CorrectAnswer = correctAnswer;
        }
    }
}
