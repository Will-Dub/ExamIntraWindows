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
            return this.list_electeurs;
        }

        public bool verifier_date_election()
        {
            return this.date_election >= DateTime.Now;
        }

        // Constructeur
        public Election()
        {

        }
    }
}
