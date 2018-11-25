namespace Source_Projet_IA
{
    partial class FormArbre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFinalNode = new System.Windows.Forms.TextBox();
            this.textBoxInitialNode = new System.Windows.Forms.TextBox();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Astuce = new System.Windows.Forms.GroupBox();
            this.Astuce.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(196, 171);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 180);
            this.treeView1.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 121);
            this.listBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Noeud final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Noeud initial";
            // 
            // textBoxFinalNode
            // 
            this.textBoxFinalNode.Location = new System.Drawing.Point(268, 44);
            this.textBoxFinalNode.Name = "textBoxFinalNode";
            this.textBoxFinalNode.ReadOnly = true;
            this.textBoxFinalNode.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinalNode.TabIndex = 11;
            this.textBoxFinalNode.Text = "6";
            // 
            // textBoxInitialNode
            // 
            this.textBoxInitialNode.Location = new System.Drawing.Point(144, 44);
            this.textBoxInitialNode.Name = "textBoxInitialNode";
            this.textBoxInitialNode.ReadOnly = true;
            this.textBoxInitialNode.Size = new System.Drawing.Size(100, 20);
            this.textBoxInitialNode.TabIndex = 10;
            this.textBoxInitialNode.Text = "0";
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.Location = new System.Drawing.Point(477, 414);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(75, 23);
            this.buttonEndGame.TabIndex = 20;
            this.buttonEndGame.Text = "J\'ai fini !";
            this.buttonEndGame.UseVisualStyleBackColor = true;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Résultats précédents :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Arbre à remplir :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Correction :";
            // 
            // treeView2
            // 
            this.treeView2.LabelEdit = true;
            this.treeView2.Location = new System.Drawing.Point(400, 171);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(152, 180);
            this.treeView2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Remplacer les \'?\' par les noeuds souhaités";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(385, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cliquez une fois pour séctionner le \'?\' souhaité puis une seconde pour le modifie" +
    "r";
            // 
            // Astuce
            // 
            this.Astuce.Controls.Add(this.label7);
            this.Astuce.Location = new System.Drawing.Point(6, 80);
            this.Astuce.Name = "Astuce";
            this.Astuce.Size = new System.Drawing.Size(566, 56);
            this.Astuce.TabIndex = 28;
            this.Astuce.TabStop = false;
            this.Astuce.Text = "Astuce";
            // 
            // FormArbre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 449);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Astuce);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFinalNode);
            this.Controls.Add(this.textBoxInitialNode);
            this.Name = "FormArbre";
            this.Text = "Dijkstra - Arbre de recherche";
            this.Astuce.ResumeLayout(false);
            this.Astuce.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFinalNode;
        private System.Windows.Forms.TextBox textBoxInitialNode;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Astuce;
    }
}