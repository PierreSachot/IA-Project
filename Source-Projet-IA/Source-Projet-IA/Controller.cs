using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace Source_Projet_IA
{
    /// <summary>
    /// Controller de l'ensemble de l'application
    /// </summary>
    public class Controller
    {
        // constante permettant de savoir combien de questions il y a dans l'exercice.
        public static readonly int NB_QUESTIONS = 20;
        private XML_Reader Reader { get; set; }
        public int ScoreQCM { get; private set; }
        public int ScoreTotalQCM { get; private set; }
        public int ScoreDijkstra { get; set; }
        public int ScoreTotalDijkstra { get; set; }
        public List<int> QuestionsTraitees { get; set; }
        public Question CurrentQuestion { get; private set; }

        public MainForm MainForm { get; set; }
        private FormQuestionnaire questionnaire;
        private FormDijkstra dijkstra;
        public bool IsFirstExDone { get; private set; }
        public bool IsSecondExDone { get; private set; }


        public Controller()
        {
            Reader = new XML_Reader(); ;
            ScoreQCM = 0;
            ScoreTotalQCM = 0;
            ScoreDijkstra = 0;
            ScoreTotalDijkstra = 3;
            QuestionsTraitees = new List<int>();
        }

        /// <summary>
        /// Permet de gérer dynamiquement l'ensemble des exercices.
        /// </summary>
        /// <param name="type"></param>
        public void ExDone(Form type)
        {
            if (type is FormQuestionnaire)
            {
                MainForm.buttonStartQCM.Enabled = false;
                IsFirstExDone = true;
                if(!((FormQuestionnaire)type).formClosed)
                {
                    ((FormQuestionnaire)type).formClosed = true;
                    type.Close();
                }
                MainForm.labelResultPart1.Text = "Résultat QCM : " + ScoreQCM + "/" + ScoreTotalQCM;
                if (!IsSecondExDone)
                {
                    LoadDijkstra();
                }
                else
                {
                    MainForm.Show();
                }
            }
            else
            {
                if (type is FormArbre && ((FormArbre)type).formClosed)
                {
                    ((FormArbre)type).formClosed = true;
                    type.Close();
                }
                if(type is FormDijkstra && ((FormDijkstra)type).formClosed)
                {
                    ((FormDijkstra)type).formClosed = true;
                    type.Close();
                }
                MainForm.buttonStartDijkstra.Enabled = false;
                IsSecondExDone = true;
                MainForm.labelResultPart2.Text = "Résultat Dijkstra : " + ScoreDijkstra + "/"
                    + ScoreTotalDijkstra;
                if (!IsFirstExDone)
                {
                    LoadQuestionnaire();
                }
                else
                {
                    MainForm.Show();
                }
            }
        }

        /// <summary>
        /// Permet de lancer l'exercice sur Dijkstra
        /// </summary>
        public void LoadDijkstra()
        {
            IsSecondExDone = true;
            MainForm.Hide();
            dijkstra = new FormDijkstra(this);
            dijkstra.Show();
        }

        /// <summary>
        /// Permet de lancer le questionnaire
        /// </summary>
        public void LoadQuestionnaire()
        {
            IsFirstExDone = true;
            MainForm.Hide();
            questionnaire = new FormQuestionnaire(this);
            questionnaire.Show();
        }

        /// <summary>
        /// Permet au questionnaire de charger la question suivante
        /// </summary>
        public void LoadNextQuestion()
        {
            //On vérifie que l'exercice n'est pas terminé.
            if(QuestionsTraitees.Count() >= NB_QUESTIONS)
            {
                questionnaire.OpenScoreBox(ScoreQCM, ScoreTotalQCM);
            }
            else
            {
                //On charge de manière aléatoire une question qui n'a pas été traitée
                Random random = new Random();
                int val = random.Next(0, Reader.GetNumberOfQuestions());
                int nbTentatives = 0;
                int nbQuestions = Reader.GetNumberOfQuestions();
                while (QuestionsTraitees.Contains(val))
                {
                    //On a un seuil de tentatives afin de ne pas être dans un loop infini.
                    if (nbTentatives > 100)
                        throw new Exception("Erreur : Vous avez répondu à l'ensemble des questions du document. " +
                            "Vous ne pouvez pas charger de nouvelle question.");
                    val = random.Next(0, nbQuestions);
                    nbTentatives++;
                }
                QuestionsTraitees.Add(val);
                CurrentQuestion = Reader.GetQuestion(val);
            }
        }

        /// <summary>
        /// Permet de gérer la réponse de l'utilisateur à une question du QCM
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int SetResponse(int index)
        {
            if (CurrentQuestion.CorrectAnswer == index)
                ScoreQCM += CurrentQuestion.NbPoints;
            ScoreTotalQCM += CurrentQuestion.NbPoints;
            return CurrentQuestion.CorrectAnswer;
        }
    }
}
