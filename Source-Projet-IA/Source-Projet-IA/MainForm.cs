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
        public Controller Controller { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Controller = new Controller();
            Controller.MainForm = this;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Controller.LoadQuestionnaire();
        }

        private void buttonStartDijkstra_Click(object sender, EventArgs e)
        {
            Controller.LoadDijkstra();
        }
    }
}
