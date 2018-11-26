using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace Source_Projet_IA
{
    public partial class MainForm : Form
    {
        private FormQuestionnaire questionnaire;
        private FormDijkstra dijkstra;
        public Controller Controller { get; set; }
        public bool IsFirstExDone;
        public bool IsSecondExDone;

        public MainForm()
        {
            InitializeComponent();
            Controller = new Controller();
        }

        private void LoadDijkstra()
        {
            this.Hide();
            dijkstra = new FormDijkstra(this);
            dijkstra.Show();
        }
        private void LoadQuestionnaire()
        {
            this.Hide();
            questionnaire = new FormQuestionnaire(this, Controller);
            questionnaire.CurrentController = Controller;
            Controller.QuestionnaireForm = questionnaire;
            questionnaire.Show();
        }

        public void ExDone(Form type)
        {
            if (type is FormQuestionnaire)
            {
                buttonStartQCM.Enabled = false;
                IsFirstExDone = true;
                type.Close();
                labelResultPart1.Text = "Résultat QCM : " + Controller.ScoreQCM + "/" + Controller.ScoreTotalQCM;
                if (!IsSecondExDone)
                {
                    LoadDijkstra();
                }
            }
            else
            {
                buttonStartDijkstra.Enabled = false;
                IsSecondExDone = true;
                dijkstra.Close();
                type.Close();
                labelResultPart2.Text = "Résultat Dijkstra : " + Controller.ScoreDijkstra + "/" 
                    + Controller.ScoreTotalDijkstra;
                if (!IsFirstExDone)
                {
                    LoadQuestionnaire();
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            LoadQuestionnaire();
        }

        private void buttonStartDijkstra_Click(object sender, EventArgs e)
        {
            LoadDijkstra();
        }
    }
}
