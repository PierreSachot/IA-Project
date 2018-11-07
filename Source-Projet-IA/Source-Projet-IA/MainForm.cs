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
        Questionnaire questionnaire;
        public MainForm()
        {
            XML_Reader reader = new XML_Reader();
            questionnaire = new Questionnaire(reader, this);
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            questionnaire.Show();
        }
    }
}
