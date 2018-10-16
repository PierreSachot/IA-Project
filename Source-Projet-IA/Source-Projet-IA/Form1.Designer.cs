namespace Source_Projet_IA
{
    partial class Form1
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.labelAnswer3 = new System.Windows.Forms.Label();
            this.labelAnswer4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Monotype Corsiva", 20.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelQuestion.Location = new System.Drawing.Point(324, 27);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(112, 34);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer1.Location = new System.Drawing.Point(343, 120);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(71, 16);
            this.labelAnswer1.TabIndex = 1;
            this.labelAnswer1.Text = "answer1";
            this.labelAnswer1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAnswer2.AutoSize = true;
            this.labelAnswer2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer2.Location = new System.Drawing.Point(343, 157);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(71, 16);
            this.labelAnswer2.TabIndex = 2;
            this.labelAnswer2.Text = "answer2";
            this.labelAnswer2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAnswer3
            // 
            this.labelAnswer3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAnswer3.AutoSize = true;
            this.labelAnswer3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer3.Location = new System.Drawing.Point(343, 194);
            this.labelAnswer3.Name = "labelAnswer3";
            this.labelAnswer3.Size = new System.Drawing.Size(71, 16);
            this.labelAnswer3.TabIndex = 3;
            this.labelAnswer3.Text = "answer3";
            this.labelAnswer3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAnswer4
            // 
            this.labelAnswer4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAnswer4.AutoSize = true;
            this.labelAnswer4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer4.Location = new System.Drawing.Point(343, 224);
            this.labelAnswer4.Name = "labelAnswer4";
            this.labelAnswer4.Size = new System.Drawing.Size(71, 16);
            this.labelAnswer4.TabIndex = 4;
            this.labelAnswer4.Text = "answer4";
            this.labelAnswer4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAnswer4);
            this.Controls.Add(this.labelAnswer3);
            this.Controls.Add(this.labelAnswer2);
            this.Controls.Add(this.labelAnswer1);
            this.Controls.Add(this.labelQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.Label labelAnswer3;
        private System.Windows.Forms.Label labelAnswer4;
    }
}

