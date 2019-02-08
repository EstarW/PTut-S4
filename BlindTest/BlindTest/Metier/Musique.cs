using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindTest.Metier
{
    class Musique
    {
        private String Titre { get; }
        private String Auteur { get; }
        //Durée totale de la musique en seconde
        private int Duree { get; }
        //Chemin d'accès à la musique
        private String Path { get; }

        public Musique(String _path)
        {
            this.Path = _path;
            this.Titre = null;
            this.Auteur = null;
            this.Duree = 0;
        }
        //Démarre la musique ou reprend la lecture
        public void Play()
        {

        }
        //Met le musique en pause
        public void Pause()
        {

        }
    }
}
