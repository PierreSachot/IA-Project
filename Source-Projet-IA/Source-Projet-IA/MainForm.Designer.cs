namespace Source_Projet_IA
{
    partial class MainForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.labelResultPart2 = new System.Windows.Forms.Label();
            this.labelResultPart1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartDijkstra = new System.Windows.Forms.Button();
            this.buttonStartQCM = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.labelResultPart2);
            this.mainPanel.Controls.Add(this.labelResultPart1);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.buttonStartDijkstra);
            this.mainPanel.Controls.Add(this.buttonStartQCM);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(597, 223);
            this.mainPanel.TabIndex = 0;
            // 
            // labelResultPart2
            // 
            this.labelResultPart2.AutoSize = true;
            this.labelResultPart2.Location = new System.Drawing.Point(12, 203);
            this.labelResultPart2.Name = "labelResultPart2";
            this.labelResultPart2.Size = new System.Drawing.Size(99, 13);
            this.labelResultPart2.TabIndex = 5;
            this.labelResultPart2.Text = "Résultat Dijkstra : ?";
            // 
            // labelResultPart1
            // 
            this.labelResultPart1.AutoSize = true;
            this.labelResultPart1.Location = new System.Drawing.Point(12, 190);
            this.labelResultPart1.Name = "labelResultPart1";
            this.labelResultPart1.Size = new System.Drawing.Size(88, 13);
            this.labelResultPart1.TabIndex = 4;
            this.labelResultPart1.Text = "Résultat QCM : ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choisissez votre exercice :";
            // 
            // buttonStartDijkstra
            // 
            this.buttonStartDijkstra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartDijkstra.AutoSize = true;
            this.buttonStartDijkstra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStartDijkstra.Location = new System.Drawing.Point(246, 141);
            this.buttonStartDijkstra.Name = "buttonStartDijkstra";
            this.buttonStartDijkstra.Size = new System.Drawing.Size(97, 23);
            this.buttonStartDijkstra.TabIndex = 2;
            this.buttonStartDijkstra.Text = "Partie 2 - Dijkstra";
            this.buttonStartDijkstra.UseVisualStyleBackColor = true;
            this.buttonStartDijkstra.Click += new System.EventHandler(this.buttonStartDijkstra_Click);
            // 
            // buttonStartQCM
            // 
            this.buttonStartQCM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartQCM.AutoSize = true;
            this.buttonStartQCM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStartQCM.Location = new System.Drawing.Point(251, 99);
            this.buttonStartQCM.Name = "buttonStartQCM";
            this.buttonStartQCM.Size = new System.Drawing.Size(86, 23);
            this.buttonStartQCM.TabIndex = 1;
            this.buttonStartQCM.Text = "Partie 1 - QCM";
            this.buttonStartQCM.UseVisualStyleBackColor = true;
            this.buttonStartQCM.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Pristina", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(230, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(138, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Menu principal";
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 223);
            this.Controls.Add(this.mainPanel);
            this.Name = "Controller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen Intelligence Artificielle";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Button buttonStartQCM;
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.Button buttonStartDijkstra;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelResultPart2;
        public System.Windows.Forms.Label labelResultPart1;
    }
}