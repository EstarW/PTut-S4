using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlindTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AffichageMain();
        }
        private void AffichageMain()
        {
            this.l_jouer.Show();
            this.l_options.Show();
            this.l_credits.Show();
            this.l_quitter.Show();

            this.l_1joueur.Hide();
            this.l_2joueurs.Hide();
            this.l_3joueurs.Hide();
            this.l_4joueurs.Hide();

            this.l_entrerUnPseudo.Hide();
            this.l_j1.Hide();
            this.l_j2.Hide();
            this.l_j3.Hide();
            this.l_j4.Hide();
            this.textBox_j1.Hide();
            this.textBox_j2.Hide();
            this.textBox_j3.Hide();
            this.textBox_j4.Hide();

            this.b_jouer.Hide();
            this.b_retour.Hide();
        }

        private void AffichageNbJ()
        {
            this.l_jouer.Hide();
            this.l_options.Hide();
            this.l_credits.Hide();
            this.l_quitter.Hide();

            this.l_1joueur.Show();
            this.l_2joueurs.Show();
            this.l_3joueurs.Show();
            this.l_4joueurs.Show();

            this.l_entrerUnPseudo.Hide();
            this.l_j1.Hide();
            this.l_j2.Hide();
            this.l_j3.Hide();
            this.l_j4.Hide();
            this.textBox_j1.Hide();
            this.textBox_j2.Hide();
            this.textBox_j3.Hide();
            this.textBox_j4.Hide();

            this.b_jouer.Hide();
            this.b_retour.Show();
        }

        private void AffichageNomJ(int nb)
        {
            this.l_jouer.Hide();
            this.l_options.Hide();
            this.l_credits.Hide();
            this.l_quitter.Hide();

            this.l_1joueur.Hide();
            this.l_2joueurs.Hide();
            this.l_3joueurs.Hide();
            this.l_4joueurs.Hide();

            this.l_entrerUnPseudo.Show();
            this.l_j1.Show();
            if (nb > 1) this.l_j2.Show();
            if (nb > 2) this.l_j3.Show();
            if (nb > 3) this.l_j4.Show();
            this.textBox_j1.Show();
            if (nb > 1) this.textBox_j2.Show();
            if (nb > 2) this.textBox_j3.Show();
            if (nb > 3) this.textBox_j4.Show();

            this.b_jouer.Show();
            this.b_retour.Show();
        }

        private void l_jouer_Click(object sender, EventArgs e)
        {
            this.AffichageNbJ();
        }

        private void l_options_Click(object sender, EventArgs e)
        {

        }

        private void l_credits_Click(object sender, EventArgs e)
        {

        }

        private void l_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void l_1joueur_Click(object sender, EventArgs e)
        {
            this.AffichageNomJ(1);
        }

        private void l_2joueurs_Click(object sender, EventArgs e)
        {
            this.AffichageNomJ(2);
        }

        private void l_3joueurs_Click(object sender, EventArgs e)
        {
            this.AffichageNomJ(3);
        }

        private void l_4joueurs_Click(object sender, EventArgs e)
        {
            this.AffichageNomJ(4);
        }

        private void b_retour_Click(object sender, EventArgs e)
        {
            this.AffichageMain();
        }
    }
}
