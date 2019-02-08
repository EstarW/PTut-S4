namespace BlindTest
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
            this.l_jouer = new System.Windows.Forms.Label();
            this.l_options = new System.Windows.Forms.Label();
            this.l_credits = new System.Windows.Forms.Label();
            this.l_quitter = new System.Windows.Forms.Label();
            this.l_1joueur = new System.Windows.Forms.Label();
            this.l_2joueurs = new System.Windows.Forms.Label();
            this.l_3joueurs = new System.Windows.Forms.Label();
            this.l_4joueurs = new System.Windows.Forms.Label();
            this.l_entrerUnPseudo = new System.Windows.Forms.Label();
            this.l_j1 = new System.Windows.Forms.Label();
            this.l_j2 = new System.Windows.Forms.Label();
            this.l_j3 = new System.Windows.Forms.Label();
            this.l_j4 = new System.Windows.Forms.Label();
            this.textBox_j1 = new System.Windows.Forms.TextBox();
            this.textBox_j2 = new System.Windows.Forms.TextBox();
            this.textBox_j3 = new System.Windows.Forms.TextBox();
            this.textBox_j4 = new System.Windows.Forms.TextBox();
            this.b_jouer = new System.Windows.Forms.Button();
            this.b_retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_jouer
            // 
            this.l_jouer.AutoSize = true;
            this.l_jouer.Location = new System.Drawing.Point(366, 250);
            this.l_jouer.Name = "l_jouer";
            this.l_jouer.Size = new System.Drawing.Size(43, 13);
            this.l_jouer.TabIndex = 0;
            this.l_jouer.Text = "JOUER";
            this.l_jouer.Click += new System.EventHandler(this.l_jouer_Click);
            // 
            // l_options
            // 
            this.l_options.AutoSize = true;
            this.l_options.Location = new System.Drawing.Point(366, 276);
            this.l_options.Name = "l_options";
            this.l_options.Size = new System.Drawing.Size(55, 13);
            this.l_options.TabIndex = 1;
            this.l_options.Text = "OPTIONS";
            this.l_options.Click += new System.EventHandler(this.l_options_Click);
            // 
            // l_credits
            // 
            this.l_credits.AutoSize = true;
            this.l_credits.Location = new System.Drawing.Point(366, 304);
            this.l_credits.Name = "l_credits";
            this.l_credits.Size = new System.Drawing.Size(54, 13);
            this.l_credits.TabIndex = 2;
            this.l_credits.Text = "CREDITS";
            this.l_credits.Click += new System.EventHandler(this.l_credits_Click);
            // 
            // l_quitter
            // 
            this.l_quitter.AutoSize = true;
            this.l_quitter.Location = new System.Drawing.Point(366, 333);
            this.l_quitter.Name = "l_quitter";
            this.l_quitter.Size = new System.Drawing.Size(55, 13);
            this.l_quitter.TabIndex = 3;
            this.l_quitter.Text = "QUITTER";
            this.l_quitter.Click += new System.EventHandler(this.l_quitter_Click);
            // 
            // l_1joueur
            // 
            this.l_1joueur.AutoSize = true;
            this.l_1joueur.Location = new System.Drawing.Point(354, 65);
            this.l_1joueur.Name = "l_1joueur";
            this.l_1joueur.Size = new System.Drawing.Size(45, 13);
            this.l_1joueur.TabIndex = 4;
            this.l_1joueur.Text = "1 joueur";
            this.l_1joueur.Click += new System.EventHandler(this.l_1joueur_Click);
            // 
            // l_2joueurs
            // 
            this.l_2joueurs.AutoSize = true;
            this.l_2joueurs.Location = new System.Drawing.Point(357, 101);
            this.l_2joueurs.Name = "l_2joueurs";
            this.l_2joueurs.Size = new System.Drawing.Size(50, 13);
            this.l_2joueurs.TabIndex = 5;
            this.l_2joueurs.Text = "2 joueurs";
            this.l_2joueurs.Click += new System.EventHandler(this.l_2joueurs_Click);
            // 
            // l_3joueurs
            // 
            this.l_3joueurs.AutoSize = true;
            this.l_3joueurs.Location = new System.Drawing.Point(357, 142);
            this.l_3joueurs.Name = "l_3joueurs";
            this.l_3joueurs.Size = new System.Drawing.Size(50, 13);
            this.l_3joueurs.TabIndex = 6;
            this.l_3joueurs.Text = "3 joueurs";
            this.l_3joueurs.Click += new System.EventHandler(this.l_3joueurs_Click);
            // 
            // l_4joueurs
            // 
            this.l_4joueurs.AutoSize = true;
            this.l_4joueurs.Location = new System.Drawing.Point(357, 186);
            this.l_4joueurs.Name = "l_4joueurs";
            this.l_4joueurs.Size = new System.Drawing.Size(50, 13);
            this.l_4joueurs.TabIndex = 7;
            this.l_4joueurs.Text = "4 joueurs";
            this.l_4joueurs.Click += new System.EventHandler(this.l_4joueurs_Click);
            // 
            // l_entrerUnPseudo
            // 
            this.l_entrerUnPseudo.AutoSize = true;
            this.l_entrerUnPseudo.Location = new System.Drawing.Point(38, 65);
            this.l_entrerUnPseudo.Name = "l_entrerUnPseudo";
            this.l_entrerUnPseudo.Size = new System.Drawing.Size(88, 13);
            this.l_entrerUnPseudo.TabIndex = 8;
            this.l_entrerUnPseudo.Text = "Entrer un pseudo";
            // 
            // l_j1
            // 
            this.l_j1.AutoSize = true;
            this.l_j1.Location = new System.Drawing.Point(38, 100);
            this.l_j1.Name = "l_j1";
            this.l_j1.Size = new System.Drawing.Size(18, 13);
            this.l_j1.TabIndex = 9;
            this.l_j1.Text = "J1";
            // 
            // l_j2
            // 
            this.l_j2.AutoSize = true;
            this.l_j2.Location = new System.Drawing.Point(41, 165);
            this.l_j2.Name = "l_j2";
            this.l_j2.Size = new System.Drawing.Size(18, 13);
            this.l_j2.TabIndex = 10;
            this.l_j2.Text = "J2";
            // 
            // l_j3
            // 
            this.l_j3.AutoSize = true;
            this.l_j3.Location = new System.Drawing.Point(41, 226);
            this.l_j3.Name = "l_j3";
            this.l_j3.Size = new System.Drawing.Size(18, 13);
            this.l_j3.TabIndex = 11;
            this.l_j3.Text = "J3";
            // 
            // l_j4
            // 
            this.l_j4.AutoSize = true;
            this.l_j4.Location = new System.Drawing.Point(41, 285);
            this.l_j4.Name = "l_j4";
            this.l_j4.Size = new System.Drawing.Size(18, 13);
            this.l_j4.TabIndex = 12;
            this.l_j4.Text = "J4";
            // 
            // textBox_j1
            // 
            this.textBox_j1.Location = new System.Drawing.Point(41, 125);
            this.textBox_j1.Name = "textBox_j1";
            this.textBox_j1.Size = new System.Drawing.Size(100, 20);
            this.textBox_j1.TabIndex = 13;
            // 
            // textBox_j2
            // 
            this.textBox_j2.Location = new System.Drawing.Point(41, 197);
            this.textBox_j2.Name = "textBox_j2";
            this.textBox_j2.Size = new System.Drawing.Size(100, 20);
            this.textBox_j2.TabIndex = 14;
            // 
            // textBox_j3
            // 
            this.textBox_j3.Location = new System.Drawing.Point(41, 250);
            this.textBox_j3.Name = "textBox_j3";
            this.textBox_j3.Size = new System.Drawing.Size(100, 20);
            this.textBox_j3.TabIndex = 15;
            // 
            // textBox_j4
            // 
            this.textBox_j4.Location = new System.Drawing.Point(41, 304);
            this.textBox_j4.Name = "textBox_j4";
            this.textBox_j4.Size = new System.Drawing.Size(100, 20);
            this.textBox_j4.TabIndex = 16;
            // 
            // b_jouer
            // 
            this.b_jouer.Location = new System.Drawing.Point(570, 378);
            this.b_jouer.Name = "b_jouer";
            this.b_jouer.Size = new System.Drawing.Size(75, 23);
            this.b_jouer.TabIndex = 17;
            this.b_jouer.Text = "JOUER";
            this.b_jouer.UseVisualStyleBackColor = true;
            // 
            // b_retour
            // 
            this.b_retour.Location = new System.Drawing.Point(51, 378);
            this.b_retour.Name = "b_retour";
            this.b_retour.Size = new System.Drawing.Size(75, 23);
            this.b_retour.TabIndex = 18;
            this.b_retour.Text = "RETOUR";
            this.b_retour.UseVisualStyleBackColor = true;
            this.b_retour.Click += new System.EventHandler(this.b_retour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_retour);
            this.Controls.Add(this.b_jouer);
            this.Controls.Add(this.textBox_j4);
            this.Controls.Add(this.textBox_j3);
            this.Controls.Add(this.textBox_j2);
            this.Controls.Add(this.textBox_j1);
            this.Controls.Add(this.l_j4);
            this.Controls.Add(this.l_j3);
            this.Controls.Add(this.l_j2);
            this.Controls.Add(this.l_j1);
            this.Controls.Add(this.l_entrerUnPseudo);
            this.Controls.Add(this.l_4joueurs);
            this.Controls.Add(this.l_3joueurs);
            this.Controls.Add(this.l_2joueurs);
            this.Controls.Add(this.l_1joueur);
            this.Controls.Add(this.l_quitter);
            this.Controls.Add(this.l_credits);
            this.Controls.Add(this.l_options);
            this.Controls.Add(this.l_jouer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_jouer;
        private System.Windows.Forms.Label l_options;
        private System.Windows.Forms.Label l_credits;
        private System.Windows.Forms.Label l_quitter;
        private System.Windows.Forms.Label l_1joueur;
        private System.Windows.Forms.Label l_2joueurs;
        private System.Windows.Forms.Label l_3joueurs;
        private System.Windows.Forms.Label l_4joueurs;
        private System.Windows.Forms.Label l_entrerUnPseudo;
        private System.Windows.Forms.Label l_j1;
        private System.Windows.Forms.Label l_j2;
        private System.Windows.Forms.Label l_j3;
        private System.Windows.Forms.Label l_j4;
        private System.Windows.Forms.TextBox textBox_j1;
        private System.Windows.Forms.TextBox textBox_j2;
        private System.Windows.Forms.TextBox textBox_j3;
        private System.Windows.Forms.TextBox textBox_j4;
        private System.Windows.Forms.Button b_jouer;
        private System.Windows.Forms.Button b_retour;
    }
}

