using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExamWindows2
{
    public class Election
    {
        // Attributs privés
        private string nom_election;
        private DateTime date_election;
        private List<Electeur> list_electeurs;

        // Propriétés
        public string NomElection
        {
            get { return nom_election; }
            set { 
                if(value == "Municipal" || value == "Provinciale" || value == "Fédérale")
                {
                    nom_election = value;
                }
            }
        }

        public DateTime DateElection
        {
            get { return this.date_election; }
            set { this.date_election = value;}
        }

        internal List<Electeur> List_electeurs
        {
            get { return this.list_electeurs; }
            set { this.list_electeurs = value; }
        }

        // Fonctions
        internal void ajouter_electeur(Electeur p_elect)
        {
            this.list_electeurs.Add(p_elect);
        }

        internal List<Electeur> rechercher_electeur_circonscription(string p_circons)
        {
            List<Electeur> list_electeurs_circons = new List<Electeur>();

            foreach (Electeur p_elect in list_electeurs)
            {
                if(p_elect.Circoncription == p_circons)
                {
                    list_electeurs_circons.Add((Electeur)p_elect);
                }
            }

            return list_electeurs_circons;
        }

        public bool verifier_date_election()
        {
            DateTime current_date = DateTime.Now;
            current_date = current_date.AddDays(1);
            return this.date_election >= current_date;
        }

        // Constructeur
        public Election()
        {

        }
    }
}
