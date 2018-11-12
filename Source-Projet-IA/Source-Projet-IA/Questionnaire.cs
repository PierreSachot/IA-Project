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
using IA_DAL;

namespace Source_Projet_IA
{
    public partial class Questionnaire : Form
    {
        private Controller CurrentController;
        private Form MainForm;

        public Questionnaire(Form form)
        {
            Thread.Sleep(500);
            MainForm = form;
            CurrentController = new Controller();
            InitializeComponent();
            Thread.Sleep(100);
            LoadQuestion();
        }
        public void LoadQuestion()
        {
            try
            {
                CurrentController.LoadNextQuestion();
                dynamicQuestionLabel.Text = CurrentController.CurrentQuestion.Title;
                labelQuestions.Text = CurrentController.QuestionsTraitees.Count+"/20";
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

        private void Questionnaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
