using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExamWindows2.Classes
{
    internal class Election
    {
        // Attributs privés
        private string nom_election;
        private DateTime date_election;
        private List<Electeur> list_electeurs;

        // Propriétés
        public string NomElection
        {
            get { return nom_election; }
            set { nom_election = value; }
        }

        public DateTime DateElection
        {
            get { return date_election; }
            set { date_election = value; }
        }

        public List<Electeur> ListElecteurs
        {
            get { return list_electeurs; }
            set { list_electeurs = value; }
        }

        // Fonctions
        public void ajouter_electeur(Electeur p_elect)
        {
            this.list_electeurs.Add(p_elect);
        }

        public List<Electeur> rechercher_electeur_circonscription(string p_circons)
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
