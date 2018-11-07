using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;

namespace IA_DAL
{
    public class Controller
    {
        private XML_Reader Reader { get; set; }
        public int Score { get; private set; }
        public List<int> QuestionsTraitees { get; set; }
        public Question CurrentQuestion { get; private set; }

        public Controller(int score)
        {
            Reader = new XML_Reader(); ;
            Score = score;
            QuestionsTraitees = new List<int>();
        }

        public Controller() : this(0) { }

        public void LoadNextQuestion()
        {
            Random random = new Random();
            int val = random.Next(0, Reader.GetNumberOfQuestions());
            int nbTentatives = 0;
            int nbQuestions = Reader.GetNumberOfQuestions();
            while (QuestionsTraitees.Contains(val))
            {
                if (nbTentatives > 100)
                    throw new Exception("Erreur : Vous avez répondu à l'ensemble des questions du document. " +
                        "Vous ne pouvez pas charger de nouvelle question.");
                val = random.Next(0, nbQuestions);
                nbTentatives++;
            }
            QuestionsTraitees.Add(val);
            CurrentQuestion = Reader.GetQuestion(val);
        }

        public void SetResponse(int index)
        {
            if (CurrentQuestion.CorrectAnswer == index)
                Score += CurrentQuestion.NbPoints;
        }
    }
}
