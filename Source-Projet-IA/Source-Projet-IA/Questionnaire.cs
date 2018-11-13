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

namespace Source_Projet_IA
{
    public partial class Questionnaire : Form
    {
        private Controller CurrentController;
        private MainForm MainForm;

        public Questionnaire(MainForm form)
        {
            Thread.Sleep(500);
            MainForm = form;
            CurrentController = new Controller(this);
            InitializeComponent();
            Thread.Sleep(100);
            LoadQuestion();
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
                ResizeComponents();
                if (CurrentController.CurrentQuestion.ImgURL == "")
                {
                    //groupBoxReponses.Anchor = System.Windows.Forms.AnchorStyles.Top;
                    pictureBox.Hide();
                }
                else
                {
                    pictureBox.Image = Image.FromFile(CurrentController.CurrentQuestion.ImgURL);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Show();
                    //groupBoxReponses.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
                }
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

        // procédure appelée lors d'un clique sur une réponse.
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int nb = ((int)((LinkLabel)sender).Tag);
            CurrentController.SetResponse(nb);
            LoadQuestion();
        }

        private void buttonRecommencer_Click(object sender, EventArgs e)
        {
            MainForm.Show();
            this.Close();
        }

        public void OpenScoreBox(int score, int scoreTotal)
        {
            MessageBox.Show("Vous avez obtenu la note de "+score+"/"+scoreTotal+"" +
                "soit "+(int)(((double)score /scoreTotal)*100)+"% de réponses correctes",
                "Fin du questionnaire",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            MainForm.Show();
            this.Hide();
        }

        private void Questionnaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
