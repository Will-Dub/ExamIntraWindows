using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWindows2.Formulaire
{
    public partial class FormElection : Form
    {
        public FormElection()
        {
            InitializeComponent();
        }
        public void Afficher_messages(bool b_nom, bool b_date)
        {
            string s = "";
            if (b_nom == false) s += "Le nom est incorrecte \n";
            if (b_date == false) s += "La date est trop basse \n";
            MessageBox.Show(s, "Message(s) d'erreur");
        }
        public void Reinitialiser(bool b_nom, bool b_date)
        {
            if (!b_nom) comboBox_nom.Text = "";
            if (!b_date) dateTimePicker_date_election.Text = "";
        }


        private void button_creer_Click(object sender, EventArgs e)
        {
            //Initialiser les booleens
            bool b_nom = false;
            bool b_date = false;

            Election election = new Election();

            election.NomElection = comboBox_nom.Text;
            election.DateElection = dateTimePicker_date_election.Value;

            if(election.NomElection == comboBox_nom.Text) b_nom = true;
            if (election.DateElection == dateTimePicker_date_election.Value) b_date = true;

            if(b_nom && b_date)
            {
                Reinitialiser(!b_nom, !b_date);
            }
            else
            {
                Reinitialiser(b_nom, b_date);
            }
        }
    }
}
