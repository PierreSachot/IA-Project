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
            this.buttonStartDijkstra = new System.Windows.Forms.Button();
            this.buttonStartQCM = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.buttonStartDijkstra);
            this.mainPanel.Controls.Add(this.buttonStartQCM);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(597, 176);
            this.mainPanel.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choisissez votre exercice :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 176);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "QCM intelligence artificiel";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button buttonStartQCM;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button buttonStartDijkstra;
        private System.Windows.Forms.Label label1;
    }
}