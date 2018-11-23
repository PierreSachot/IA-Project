namespace Source_Projet_IA
{
    partial class FormDijkstra
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxStartNode = new System.Windows.Forms.TextBox();
            this.textBoxEndNode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.textBoxFermes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ouverts = new System.Windows.Forms.Label();
            this.textBoxOuverts = new System.Windows.Forms.TextBox();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRepFerme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRepOuvert = new System.Windows.Forms.TextBox();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStartNode
            // 
            this.textBoxStartNode.Enabled = false;
            this.textBoxStartNode.Location = new System.Drawing.Point(171, 38);
            this.textBoxStartNode.Name = "textBoxStartNode";
            this.textBoxStartNode.ReadOnly = true;
            this.textBoxStartNode.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartNode.TabIndex = 1;
            this.textBoxStartNode.Text = "0";
            // 
            // textBoxEndNode
            // 
            this.textBoxEndNode.Enabled = false;
            this.textBoxEndNode.Location = new System.Drawing.Point(311, 38);
            this.textBoxEndNode.Name = "textBoxEndNode";
            this.textBoxEndNode.ReadOnly = true;
            this.textBoxEndNode.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndNode.TabIndex = 2;
            this.textBoxEndNode.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Noeud initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Noeud final";
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(31, 93);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(100, 121);
            this.listBoxgraphe.TabIndex = 9;
            // 
            // textBoxFermes
            // 
            this.textBoxFermes.Enabled = false;
            this.textBoxFermes.Location = new System.Drawing.Point(208, 314);
            this.textBoxFermes.Name = "textBoxFermes";
            this.textBoxFermes.ReadOnly = true;
            this.textBoxFermes.Size = new System.Drawing.Size(100, 20);
            this.textBoxFermes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fermés";
            // 
            // Ouverts
            // 
            this.Ouverts.AutoSize = true;
            this.Ouverts.Location = new System.Drawing.Point(148, 359);
            this.Ouverts.Name = "Ouverts";
            this.Ouverts.Size = new System.Drawing.Size(44, 13);
            this.Ouverts.TabIndex = 13;
            this.Ouverts.Text = "Ouverts";
            // 
            // textBoxOuverts
            // 
            this.textBoxOuverts.Enabled = false;
            this.textBoxOuverts.Location = new System.Drawing.Point(208, 356);
            this.textBoxOuverts.Name = "textBoxOuverts";
            this.textBoxOuverts.ReadOnly = true;
            this.textBoxOuverts.Size = new System.Drawing.Size(100, 20);
            this.textBoxOuverts.TabIndex = 12;
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Location = new System.Drawing.Point(407, 398);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(147, 23);
            this.buttonNextStep.TabIndex = 14;
            this.buttonNextStep.Text = "Étape suivante";
            this.buttonNextStep.UseVisualStyleBackColor = true;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Réponses précédentes";
            // 
            // textBoxRepFerme
            // 
            this.textBoxRepFerme.Location = new System.Drawing.Point(336, 314);
            this.textBoxRepFerme.Name = "textBoxRepFerme";
            this.textBoxRepFerme.Size = new System.Drawing.Size(128, 20);
            this.textBoxRepFerme.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Vos réponses (séparées par une virgule):";
            // 
            // textBoxRepOuvert
            // 
            this.textBoxRepOuvert.Location = new System.Drawing.Point(336, 356);
            this.textBoxRepOuvert.Name = "textBoxRepOuvert";
            this.textBoxRepOuvert.Size = new System.Drawing.Size(128, 20);
            this.textBoxRepOuvert.TabIndex = 18;
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.Location = new System.Drawing.Point(575, 398);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(75, 23);
            this.buttonEndGame.TabIndex = 19;
            this.buttonEndGame.Text = "J\'ai fini !";
            this.buttonEndGame.UseVisualStyleBackColor = true;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 23);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "< Menu principal";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(171, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 173);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.textBoxRepOuvert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRepFerme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonNextStep);
            this.Controls.Add(this.Ouverts);
            this.Controls.Add(this.textBoxOuverts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFermes);
            this.Controls.Add(this.listBoxgraphe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEndNode);
            this.Controls.Add(this.textBoxStartNode);
            this.Name = "FormDijkstra";
            this.Text = "Exercie Dijkstra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDijkstra_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxStartNode;
        private System.Windows.Forms.TextBox textBoxEndNode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.TextBox textBoxFermes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Ouverts;
        private System.Windows.Forms.TextBox textBoxOuverts;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRepFerme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRepOuvert;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

