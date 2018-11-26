using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Domain;


namespace Source_Projet_IA
{
    public partial class FormDijkstra : Form
    {
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;

        public SearchTree g;
        public Node2 N0;
        public GenericNode N;

        private MainForm parent;

        public FormDijkstra(MainForm mainForm)
        {
            parent = mainForm;
            InitializeComponent();

            pictureBox1.Image = Image.FromFile("Images/Partie2_Dijkstra.PNG");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                StreamReader monStreamReader = new StreamReader("dijkstra.txt");
                // Lecture du fichier avec un while, évidemment !
                // 1ère ligne : "nombre de noeuds du graphe
                string ligne = monStreamReader.ReadLine();
                int i = 0;
                while (ligne[i] != ':') i++;
                string strnbnoeuds = "";
                i++; // On dépasse le ":"
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                while (i < ligne.Length)
                {
                    strnbnoeuds = strnbnoeuds + ligne[i];
                    i++;
                }
                nbnodes = Convert.ToInt32(strnbnoeuds);

                Random rand = new Random();
                int startNode = rand.Next(0, nbnodes / 2);
                int endNode = rand.Next((nbnodes / 2) + 2, nbnodes);
                textBoxStartNode.Text = startNode + "";
                textBoxEndNode.Text = endNode + "";


                matrice = new double[nbnodes, nbnodes];
                for (i = 0; i < nbnodes; i++)
                    for (int j = 0; j < nbnodes; j++)
                        matrice[i, j] = -1;

                // Ensuite on a ls tructure suivante : 
                //  arc : n°noeud départ    n°noeud arrivée  valeur
                //  exemple 4 : 
                ligne = monStreamReader.ReadLine();
                while (ligne != null)
                {
                    i = 0;
                    while (ligne[i] != ':') i++;
                    i++; // on passe le :
                    while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                    string strN1 = "";
                    while (ligne[i] != ' ')
                    {
                        strN1 = strN1 + ligne[i];
                        i++;
                    }
                    int N1 = Convert.ToInt32(strN1);

                    // On saute les blancs éventuels
                    while (ligne[i] == ' ') i++;
                    string strN2 = "";
                    while (ligne[i] != ' ')
                    {
                        strN2 = strN2 + ligne[i];
                        i++;
                    }
                    int N2 = Convert.ToInt32(strN2);

                    // On saute les blancs éventuels
                    while (ligne[i] == ' ') i++;
                    string strVal = "";
                    while ((i < ligne.Length) && (ligne[i] != ' '))
                    {
                        strVal = strVal + ligne[i];
                        i++;
                    }
                    double val = Convert.ToDouble(strVal);

                    matrice[N1, N2] = val;
                    matrice[N2, N1] = val;
                    listBoxgraphe.Items.Add(Convert.ToString(N1)
                       + "--->" + Convert.ToString(N2)
                       + "   : " + Convert.ToString(matrice[N1, N2]));

                    ligne = monStreamReader.ReadLine();
                }
                // Fermeture du StreamReader (obligatoire) 
                monStreamReader.Close();
                numinitial = Convert.ToInt32(textBoxStartNode.Text);
                numfinal = Convert.ToInt32(textBoxEndNode.Text);
                g = new SearchTree();
                Node2 N0 = new Node2();
                N0.numero = numinitial;
                textBoxFermes.Text = "";
                textBoxOuverts.Text = "" + numinitial;
                textBoxRepFerme.Text = "";
                textBoxRepOuvert.Text = "" + numinitial;
                N = g.InitialiserSolution(N0);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Erreur lors du chargement du fichier 'dijkstra.txt'.\n Erreur :" + exp.Message);
            }
        }

        private void FormDijkstra_FormClosing(object sender, FormClosingEventArgs e)
        {
            GoBackToParentForm();
        }

        public void GoBackToParentForm()
        {
            parent.Show();
            this.Hide();
        }

        private bool VerifierRep(string rep, string attendu)
        {
            bool estOk = true;
            string[] allRep = rep.Split(',');
            int i = 0;
            while (i < allRep.Length)
            {
                if (!attendu.Contains(allRep[i]))
                    estOk = false;
                i++;
            }
            string[] allAttendu = attendu.Split(',');
            i = 0;
            while (i < allAttendu.Length)
            {
                if (!rep.Contains(allAttendu[i]))
                    estOk = false;
                i++;
            }
            return estOk;
        }
        public string GetOuverts()
        {
            string result = "";
            foreach (var ouverts in g.L_Ouverts)
            {
                result += Convert.ToString(ouverts) + ",";
            }
            if (result.Length != 0)
                result = result.Remove(result.Length - 1);
            return result;
        }
        public string GetFermés()
        {
            string result = "";
            foreach (var fermes in g.L_Fermes)
            {
                result += Convert.ToString(fermes) + ",";
            }
            if (result.Length != 0)
                result = result.Remove(result.Length - 1);
            return result;
        }

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            if(N.EndState())
            {
                textBoxFermes.Text = GetFermés() + "," + numfinal;
                textBoxOuverts.Text = "FIN !";
                MessageBox.Show("Cliquez sur \"J'ai fini\" la prochaine fois" +
                    "Fermés : " + GetFermés() + "," + numfinal +
                    "\nOuverts : FIN !",
                   "Mauvaise réponse !",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                LaunchFormArbre();
            }
            else if(g.L_Ouverts.Count != 0)
            {
                g.CalculerEtapeSuivante(ref g.L_Ouverts, ref g.L_Fermes, ref N);
                string correctFerme = GetFermés(), correctOuvert = GetOuverts();
                bool repFermeCorrect = VerifierRep(textBoxRepFerme.Text, correctFerme);
                bool repOuvertCorrect = VerifierRep(textBoxRepOuvert.Text, correctOuvert);
                if (repFermeCorrect && repOuvertCorrect)
                {
                    textBoxFermes.Text = correctFerme;
                    textBoxOuverts.Text = correctOuvert;
                }
                else
                {
                    CalculateEnd();
                    textBoxFermes.Text = GetFermés() + "," + numfinal;
                    textBoxOuverts.Text = "FIN !";
                    textBoxFermes.Text = GetFermés();
                    MessageBox.Show("Voici la correction de l'ensemble de l'algorithme:\n" +
                     "Fermés : " + GetFermés() + "," + numfinal +
                     "\nOuverts : FIN !",
                    "Mauvaise réponse !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LaunchFormArbre();
                }
            }
        }


        private void CalculateEnd()
        {
            while (g.L_Ouverts.Count != 0 && N.EndState() == false)
            {
                g.CalculerEtapeSuivante(ref g.L_Ouverts, ref g.L_Fermes, ref N);
            }
        }

        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            if (N.EndState())
            {
                MessageBox.Show("Bravo, c'est gagné", "Fin de la question",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                parent.Controller.ScoreDijkstra = 2;
            }
            else
            {
                CalculateEnd();
                textBoxFermes.Text = GetFermés();
                MessageBox.Show("Voici la correction de l'ensemble de l'algorithme:\n" +
                    "Fermés : " + GetFermés() + "," + numfinal +
                    "\nOuverts : FIN !",
                   "Mauvaise réponse !",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFermes.Text = GetFermés() + "," + numfinal;
                textBoxOuverts.Text = "FIN !";
            }
            LaunchFormArbre();
        }

        public void LaunchFormArbre()
        {
            this.Hide();
            new FormArbre(parent, listBoxgraphe, g, N0, matrice).Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            GoBackToParentForm();
        }
    }
}
