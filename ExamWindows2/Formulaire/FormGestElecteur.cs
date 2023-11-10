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
    public partial class FormGestElecteur : Form
    {
        public FormGestElecteur()
        {
            InitializeComponent();
        }

        private void électionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormElection formulaire = new FormElection();
            formulaire.MdiParent = this;
            formulaire.Show();
        }

        private void électeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormElecteur formulaire = new FormElecteur();
            formulaire.MdiParent = this;
            formulaire.Show();
        }

        private void listeÉlecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListElecteurs formulaire = new FormListElecteurs();
            formulaire.MdiParent = this;
            formulaire.Show();
        }
    }
}
