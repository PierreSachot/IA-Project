using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Source_Projet_IA
{
    public partial class FormArbre : Form
    {
        private int noeudInitial;
        private int noeudFinal;
        private SearchTree g;
        private Controller Controller;
        private bool aFini;
        public bool formClosed;

        public FormArbre(Controller c, ListBox precedentResult, SearchTree g, Node2 N0, double[,] matrice)
        {
            InitializeComponent();
            noeudInitial = FormDijkstra.numinitial;
            noeudFinal = FormDijkstra.numfinal;
            FormDijkstra.numfinal--;
            textBoxInitialNode.Text = noeudInitial+"";
            textBoxFinalNode.Text = "" + noeudFinal;
            this.Controller = c;
            foreach (var l in precedentResult.Items)
            {
                listBox1.Items.Add(l);
            }
            listBox1 = precedentResult;
            this.g = g;
            g.GetSearchTree(treeView1, true);
        }
        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            if(aFini)
            {
                Controller.ExDone(this);
            }
            else
            {
                TreeView correction = new TreeView();
                g.GetSearchTree(treeView2, false);
                CompareTreeNodes(treeView2, treeView1);
                MessageBox.Show("Vous avez obtenu le score de " + Controller.ScoreDijkstra
                    + "/" + Controller.ScoreTotalDijkstra);
                this.buttonEndGame.Text = "Passer à la suite";
                aFini = true;
            }
        }

        void CompareTreeNodes(TreeView tv1, TreeView tv2)
        {
            int compare = Math.Min(tv1.Nodes.Count, tv2.Nodes.Count);
            // ignore extra nodes
            Controller.ScoreDijkstra += 1;
            for (int i = 0; i < compare; i++)
            {
                CompareRecursiveTree(tv1.Nodes[i], tv2.Nodes[i], false);
            }
        }

        private void CompareRecursiveTree(TreeNode tn1, TreeNode tn2, bool isScoreDone)
        {
            if (tn1.Text != tn2.Text)
            {
                tn1.ForeColor = Color.Red;
                tn2.ForeColor = Color.Red;
                if (!isScoreDone)
                {
                    Controller.ScoreDijkstra--;
                    isScoreDone = true;
                }

                TreeNode tnp = tn2;
                while (tnp.Parent != null)
                {
                    tnp = tnp.Parent;
                }
                tnp.BackColor = Color.Yellow;
            }
            int compare = Math.Min(tn1.Nodes.Count, tn2.Nodes.Count);
            // ignore extra nodes
            for (int i = 0; i < compare; i++)
            {
                CompareRecursiveTree(tn1.Nodes[i], tn2.Nodes[i], isScoreDone);
            }
        }

        private void FormArbre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formClosed)
                Controller.ExDone(this);
            formClosed = true;
        }
    }
}
