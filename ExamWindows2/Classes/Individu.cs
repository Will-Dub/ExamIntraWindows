using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExamWindows2
{
    public class Individu
    {
        // Attributs privés
        private string nom;
        private string prenom;
        private string courriel;

        // Propriétés
        public string Nom
        {
            get { return this.nom; }
            set {
                Regex Reg = new Regex("[A-Z][a-z]{5,20}");
                if (Reg.IsMatch(value))
                {
                    this.nom = value;
                }
            }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set {
                Regex Reg = new Regex("[A-Z][a-z]{5,20}");
                if (Reg.IsMatch(value))
                {
                    this.prenom = value;
                }
            }
        }

        public string Courriel
        {
            get { return this.courriel; }
            set {
                Regex Reg = new Regex("[a-zA-Z]\\S{4,25}@[a-zA-Z]{1,10}.ca");
                if (Reg.IsMatch(value))
                {
                    this.courriel = value;
                }
            }
        }

        // Override functions
        public override string ToString()
        {
            return "************\nNom: " + this.Nom + "\nPrenom: " + this.Prenom + "\nCourriel: " + this.Courriel + "\n************";
        }

        // Constructeur
        public Individu(string p_nom = "", string p_prenom = "", string p_courriel = "")
        {
            this.nom = p_nom;
            this.prenom = p_prenom;
            this.prenom = p_courriel;
        }

    }
}
