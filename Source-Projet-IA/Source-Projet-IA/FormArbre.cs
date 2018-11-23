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

        public FormArbre(ListBox precedentResult, SearchTree g, Node2 N0, double[,] matrice)
        {
            InitializeComponent();
            noeudInitial = FormDijkstra.numinitial;
            noeudFinal = FormDijkstra.numfinal;
            textBoxInitialNode.Text = noeudInitial+"";
            textBoxFinalNode.Text = "" + (noeudFinal-1);
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
            g.GetSearchTree(treeView1, true);
        }
    }
}
