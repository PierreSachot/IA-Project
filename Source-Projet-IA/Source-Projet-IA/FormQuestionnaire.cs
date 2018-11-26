using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Threading;
using Domain;
using System.Timers;

namespace Source_Projet_IA
{
    public partial class FormQuestionnaire : Form
    {
        private Controller CurrentController;
        private MainForm MainForm;
        public System.Timers.Timer aTimer;

        public FormQuestionnaire(MainForm form)
        {
            MainForm = form;
            CurrentController = new Controller(this);
            InitializeComponent();
            LoadQuestion();
            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 150;
            aTimer.Enabled = true;
        }

        // Specify what you want to happen when the Elapsed event is raised.
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            aTimer.Enabled = false;
            this.Invoke(new Action(ResizeComponents));
        }

        public void LoadQuestion()
        {
            try
            {
                CurrentController.LoadNextQuestion();
                dynamicQuestionLabel.Text = CurrentController.CurrentQuestion.Title.Replace("\t", "    ");
                labelQuestions.Text = CurrentController.QuestionsTraitees.Count+"/"+Controller.NB_QUESTIONS;
                linkLabel1.Text = CurrentController.CurrentQuestion.LAnswers[0];
                linkLabel2.Text = CurrentController.CurrentQuestion.LAnswers[1];
                linkLabel3.Text = CurrentController.CurrentQuestion.LAnswers[2];
                linkLabel4.Text = CurrentController.CurrentQuestion.LAnswers[3];
                if (CurrentController.CurrentQuestion.ImgURL == "")
                {
                    pictureBox.Hide();
                }
                else
                {
                    pictureBox.Image = Image.FromFile(CurrentController.CurrentQuestion.ImgURL);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Show();
                }
                ResizeComponents();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,
                "Erreur",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }

        public void ResizeComponents()
        {
            linkLabel1.Left = (this.groupBoxReponses.Width / 2) - (linkLabel1.Width / 2);
            linkLabel2.Left = (this.groupBoxReponses.Width / 2) - (linkLabel2.Width / 2);
            linkLabel3.Left = (this.groupBoxReponses.Width / 2) - (linkLabel3.Width / 2);
            linkLabel4.Left = (this.groupBoxReponses.Width / 2) - (linkLabel4.Width / 2);
        }

        // procédure appelée lors d'un clic sur une réponse.
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int nb = ((int)((LinkLabel)sender).Tag);
            int correctAns = CurrentController.SetResponse(nb);
            if(nb != correctAns)
            {
                MessageBox.Show("La bonne réponse était : " + 
                    CurrentController.CurrentQuestion.LAnswers[CurrentController.CurrentQuestion.CorrectAnswer], 
                    "Mauvaise réponse !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadQuestion();
        }

        private void buttonRecommencer_Click(object sender, EventArgs e)
        {
            GoBackToParentForm();
        }

        public void GoBackToParentForm()
        {
            MainForm.Show();
            this.Hide();
        }

        public void OpenScoreBox(int score, int scoreTotal)
        {
            MessageBox.Show("Vous avez obtenu la note de "+score+"/"+scoreTotal+"\n" +
                "soit "+(int)(((double)score /scoreTotal)*100)+"% de réponses correctes",
                "Fin du questionnaire",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            MainForm.IsFirstExDone = true;
            if(MainForm.IsSecondExDone)
            {
                MainForm.Show();
            }
            else
            {
                new FormDijkstra(MainForm).Show();
            }
            this.Hide();
        }

        private void Questionnaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            GoBackToParentForm();
        }
    }
}
