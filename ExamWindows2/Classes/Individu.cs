using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWindows2
{
    internal class Individu
    {
        // Attributs privés
        private string nom;
        private string prenom;
        private string courriel;

        // Propriétés
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public string Courriel
        {
            get { return this.courriel; }
            set { this.courriel = value; }
        }

        // Override functions
        public override string ToString()
        {
            return "************\nNom: " + this.Nom + "\nPrenom: " + this.Prenom + "\nCourriel: " + this.Courriel + "\n************";
        }

        // Constructeur
        public Individu(string p_nom, string p_prenom, string p_courriel)
        {
            this.nom = p_nom;
            this.prenom = p_prenom;
            this.prenom = p_courriel;
        }

    }
}
