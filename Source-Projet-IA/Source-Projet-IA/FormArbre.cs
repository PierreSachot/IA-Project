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

        /// <summary>
        /// Permet de gérer le clique sur le bouton de fin d'exercice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Permet de comparer 2 TreeView afin de connaître les différences (affichage en rouge si différences)
        /// </summary>
        /// <param name="tv1"></param>
        /// <param name="tv2"></param>
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

        /// <summary>
        /// Permet de comparer récursivement 2 TreeNode.
        /// </summary>
        /// <param name="tn1"></param>
        /// <param name="tn2"></param>
        /// <param name="isScoreDone"></param>
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

        /// <summary>
        /// Permet de gérer la fermeture d'un formulaire afin de considérer l'exercice comme terminé.
        /// L'attribut formClosed permet de palier à l'exception stackOverflow.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormArbre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formClosed)
                Controller.ExDone(this);
            formClosed = true;
        }
    }
}
