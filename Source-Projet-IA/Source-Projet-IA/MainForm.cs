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
        FormQuestionnaire questionnaire;
        FormDijkstra dijkstra;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            questionnaire = new FormQuestionnaire(this);
            questionnaire.Show();
        }

        private void buttonStartDijkstra_Click(object sender, EventArgs e)
        {
            this.Hide();
            dijkstra = new FormDijkstra(this);
            dijkstra.Show();
        }
    }
}
