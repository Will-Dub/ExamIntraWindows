using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExamWindows2.Classes
{
    internal class Electeur : Individu
    {
         // Attributs privés
        private string numero_electeur;
        private string circoncription;

        // Méthode
        public string Numero_electeur
        {
            get { return this.numero_electeur; }
            set {
                Regex Reg = new Regex("/d{6}");
                if (Reg.IsMatch(value))
                {
                    this.numero_electeur = value;
                }
            }
        }

        public string Circoncription
        {
            get { return this.circoncription; }
            set { 
                if(value == "Gatineau" || value == "Aylmer" || value == "Hull")
                {
                    this.circoncription = value;
                }
            }
        }

        // Override functions
        public override string ToString()
        {
            return "************\nNom: " + this.Nom + "\nPrenom: " + this.Prenom + "\nCourriel: " + this.Courriel + "\nNuméro de l'électeur: " + this.Numero_electeur +
                "\nCirconscription: " + this.Circoncription + "\n************";
        }


        // Constructeur
        Electeur(string p_nom, string p_prenom, string p_courriel, string p_numero_electeur, string p_circonscription) : base (p_nom, p_prenom, p_courriel)
        {
            this.numero_electeur = p_numero_electeur;
            this.circoncription = p_circonscription;
        }
    }
}
