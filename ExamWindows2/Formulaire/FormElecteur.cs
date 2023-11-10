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
    public partial class FormElecteur : Form
    {
        public FormElecteur()
        {
            InitializeComponent();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            //Initialiser les booleens
            bool b_numero = false;
            bool b_circonscription = false;
            bool b_nom = false;
            bool b_prenom = false;
            bool b_courriel = false;

            Electeur electeur = new Electeur();
        }
    }
}
