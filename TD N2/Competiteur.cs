using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_N2
{
    class Competiteur
    {
        private int cin;
        public int Cin 
        {
            get {return cin; }
            set { cin = value; }
        }
        private string nom;
        public string Nom 
        {
            get { return nom; }
            set { nom = value; }
        }
        private int classement;
        public int Classement
        {
            get { return classement; }
            set { classement = value; }
        }
        private string etablissement;
        public string Etablissement 
        {
            get { return etablissement; }
            set { etablissement = value; }
        }
        public Competiteur(int cin, string nom, int classement, string etablissement) 
        {
            this.cin = cin;
            this.nom = nom;
            this.classement = classement;
            this.etablissement = etablissement;
        }
        public Competiteur() { }
    }
}
