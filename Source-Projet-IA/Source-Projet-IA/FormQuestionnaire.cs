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
        private Controller Controller;
        public System.Timers.Timer aTimer;
        public bool formClosed;

        public FormQuestionnaire(Controller c)
        {
            Controller = c;
            InitializeComponent();
            LoadQuestion();
            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 100;
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
                Controller.LoadNextQuestion();
                dynamicQuestionLabel.Text = Controller.CurrentQuestion.Title.Replace("\t", "    ");
                labelQuestions.Text = Controller.QuestionsTraitees.Count+"/"+Controller.NB_QUESTIONS;
                linkLabel1.Text = Controller.CurrentQuestion.LAnswers[0];
                linkLabel2.Text = Controller.CurrentQuestion.LAnswers[1];
                linkLabel3.Text = Controller.CurrentQuestion.LAnswers[2];
                linkLabel4.Text = Controller.CurrentQuestion.LAnswers[3];
                if (Controller.CurrentQuestion.ImgURL == "")
                {
                    pictureBox.Hide();
                }
                else
                {
                    pictureBox.Image = Image.FromFile(Controller.CurrentQuestion.ImgURL);
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
            int yGb = groupBoxReponses.Location.Y;
            int yPb = pictureBox.Location.Y;
            pictureBox.Size = new Size(groupBoxReponses.Size.Width, yGb - yPb);
            linkLabel1.Left = (this.groupBoxReponses.Width / 2) - (linkLabel1.Width / 2);
            linkLabel2.Left = (this.groupBoxReponses.Width / 2) - (linkLabel2.Width / 2);
            linkLabel3.Left = (this.groupBoxReponses.Width / 2) - (linkLabel3.Width / 2);
            linkLabel4.Left = (this.groupBoxReponses.Width / 2) - (linkLabel4.Width / 2);
        }

        // procédure appelée lors d'un clic sur une réponse.
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int nb = ((int)((LinkLabel)sender).Tag);
            int correctAns = Controller.SetResponse(nb);
            if(nb != correctAns)
            {
                MessageBox.Show("La bonne réponse était : " + 
                    Controller.CurrentQuestion.LAnswers[Controller.CurrentQuestion.CorrectAnswer], 
                    "Mauvaise réponse !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadQuestion();
        }

        public void OpenScoreBox(int score, int scoreTotal)
        {
            MessageBox.Show("Vous avez obtenu la note de "+score+"/"+scoreTotal+"\n" +
                "soit "+(int)(((double)score /scoreTotal)*100)+"% de réponses correctes",
                "Fin du questionnaire",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            Controller.ExDone(this);
        }

        private void FormQuestionnaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formClosed)
                Controller.ExDone(this);
            formClosed = true;
        }
    }
}
