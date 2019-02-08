using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindTest.Metier
{
    class Joueur
    {
        private String Name { get; set; }
        private int Score { get; set; }
        //Etat du joueur : si vrai, le joueur peut buzzer ; si faux, le joueur a donner une mauvaise réponse et ne peut plus buzzer
        private bool State { get; set; }

        public Joueur(String _name)
        {
            this.Name = _name;
            this.Score = 0;
            this.State = true;
        }
        public void gagnerPoints(int points)
        {
            this.Score += points;
        }
    }
}
