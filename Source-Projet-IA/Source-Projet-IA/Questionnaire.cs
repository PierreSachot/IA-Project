using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DAL;
using Domain;

namespace Source_Projet_IA
{
    public partial class Questionnaire : Form
    {
        private XML_Reader Reader { get; set; }
        private Question CurrentQuestion { get; set; }
        private Form Parent { get; set; }
        public Questionnaire(XML_Reader reader, Form parent)
        {
            Parent = parent;
            InitializeComponent();
            Thread.Sleep(100);
            Reader = reader;
            LoadQuestion();
        }
        public void LoadQuestion()
        {
            Random random = new Random();
            int val = random.Next(0, 2);
            CurrentQuestion = Reader.GetQuestion(val);
            dynamicQuestionLabel.Text = CurrentQuestion.Title;
            linkLabel1.Text = CurrentQuestion.LAnswers[0];
            linkLabel2.Text = CurrentQuestion.LAnswers[1];
            linkLabel3.Text = CurrentQuestion.LAnswers[2];
            linkLabel4.Text = CurrentQuestion.LAnswers[3];
            ResizeComponents();
            if (CurrentQuestion.ImgURL == "")
            {
                pictureBox.Hide();
            }
            else
            {
                pictureBox.Image = Image.FromFile(CurrentQuestion.ImgURL);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Show();
            }
        }

        public void ResizeComponents()
        {
            linkLabel1.Left = (this.ClientSize.Width / 2) - (linkLabel1.Width / 2);
            linkLabel2.Left = (this.ClientSize.Width / 2) - (linkLabel2.Width / 2);
            linkLabel3.Left = (this.ClientSize.Width / 2) - (linkLabel3.Width / 2);
            linkLabel4.Left = (this.ClientSize.Width / 2) - (linkLabel4.Width / 2);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        private void Questionnaire_Deactivate(object sender, EventArgs e)
        {
            this.Parent.Close();
        }
    }
}
