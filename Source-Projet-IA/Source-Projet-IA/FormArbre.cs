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
        private MainForm parent;

        public FormArbre(MainForm parent, ListBox precedentResult, SearchTree g, Node2 N0, double[,] matrice)
        {
            InitializeComponent();
            noeudInitial = FormDijkstra.numinitial;
            noeudFinal = FormDijkstra.numfinal;
            FormDijkstra.numfinal--;
            textBoxInitialNode.Text = noeudInitial+"";
            textBoxFinalNode.Text = "" + noeudFinal;
            this.parent = parent;
            foreach (var l in precedentResult.Items)
            {
                listBox1.Items.Add(l);
            }
            listBox1 = precedentResult;
            /*N0.numero = noeudInitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);
            Node2 N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i];
                listBox1.Items.Add(Convert.ToString(N1.numero)
                     + "--->" + Convert.ToString(N2.numero)
                     + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }*/
            this.g = g;
            g.GetSearchTree(treeView1, true);
        }

        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            TreeView correction = new TreeView();
            g.GetSearchTree(treeView2, false);
            CompareTreeNodes(treeView2, treeView1);
            buttonEndGame.Enabled = false;
            this.parent.IsSecondExDone = true;
            if (parent.IsFirstExDone)
            {
                parent.Show();
            }
            else
            {
                new FormQuestionnaire(parent).Show();
            }
            this.Hide();
        }

        void CompareTreeNodes(TreeView tv1, TreeView tv2)
        {
            int compare = Math.Min(tv1.Nodes.Count, tv2.Nodes.Count);
            // ignore extra nodes
            for (int i = 0; i < compare; i++)
            {
                CompareRecursiveTree(tv1.Nodes[i], tv2.Nodes[i]);
            }
        }

        private void CompareRecursiveTree(TreeNode tn1, TreeNode tn2)
        {
            if (tn1.Text != tn2.Text)
            {
                tn1.ForeColor = Color.Red;
                tn2.ForeColor = Color.Red;

                TreeNode tnp = tn2;
                while (tnp.Parent != null)
                {
                    tnp = tnp.Parent;
                }
                tnp.BackColor = Color.Yellow;
            }
            // colour differently on comparing text
            int areThey = String.Compare(tn1.Text, tn2.Text, StringComparison.OrdinalIgnoreCase);
            if (areThey < 0)
            {
                tn1.ForeColor = Color.Red;
                tn2.ForeColor = Color.Green;
            }
            else if (areThey > 0)
            {
                tn1.ForeColor = Color.Green;
                tn2.ForeColor = Color.Red;
            }
            int compare = Math.Min(tn1.Nodes.Count, tn2.Nodes.Count);
            // ignore extra nodes
            for (int i = 0; i < compare; i++)
            {
                CompareRecursiveTree(tn1.Nodes[i], tn2.Nodes[i]);
            }
        }
    }
}
