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
        public int NbPoints { get; set; }

        /// <summary>
        /// Permet de créer une question
        /// </summary>
        /// <param name="title">titre</param>
        /// <param name="imgURL">url de l'image à afficher</param>
        /// <param name="lAnswers">liste des réponses possibles</param>
        /// <param name="correctAnswer">index de la réponse correcte</param>
        /// <param name="nbPoints">nombre de points que la réponse rapporte</param>
        public Question(string title, string imgURL, List<string> lAnswers, int correctAnswer, int nbPoints)
        {
            Title = title;
            ImgURL = imgURL;
            LAnswers = lAnswers;
            CorrectAnswer = correctAnswer;
            NbPoints = nbPoints;
        }
    }
}
