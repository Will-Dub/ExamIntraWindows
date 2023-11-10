namespace ExamWindows2.Formulaire
{
    partial class FormListElecteurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_circonscription = new System.Windows.Forms.Label();
            this.label_recherche = new System.Windows.Forms.Label();
            this.comboBox_circonscription = new System.Windows.Forms.ComboBox();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.label_nom_election = new System.Windows.Forms.Label();
            this.label_date_election = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCourriel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label_circonscription
            // 
            this.label_circonscription.AutoSize = true;
            this.label_circonscription.Location = new System.Drawing.Point(84, 57);
            this.label_circonscription.Name = "label_circonscription";
            this.label_circonscription.Size = new System.Drawing.Size(90, 13);
            this.label_circonscription.TabIndex = 0;
            this.label_circonscription.Text = "La circonscription";
            // 
            // label_recherche
            // 
            this.label_recherche.AutoSize = true;
            this.label_recherche.Location = new System.Drawing.Point(31, 25);
            this.label_recherche.Name = "label_recherche";
            this.label_recherche.Size = new System.Drawing.Size(60, 13);
            this.label_recherche.TabIndex = 1;
            this.label_recherche.Text = "Recherche";
            // 
            // comboBox_circonscription
            // 
            this.comboBox_circonscription.FormattingEnabled = true;
            this.comboBox_circonscription.Items.AddRange(new object[] {
            "Gatineau",
            "Aylmer",
            "Hull"});
            this.comboBox_circonscription.Location = new System.Drawing.Point(223, 54);
            this.comboBox_circonscription.Name = "comboBox_circonscription";
            this.comboBox_circonscription.Size = new System.Drawing.Size(200, 21);
            this.comboBox_circonscription.TabIndex = 13;
            // 
            // button_rechercher
            // 
            this.button_rechercher.Location = new System.Drawing.Point(463, 52);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(88, 23);
            this.button_rechercher.TabIndex = 14;
            this.button_rechercher.Text = "Rechercher";
            this.button_rechercher.UseVisualStyleBackColor = true;
            // 
            // label_nom_election
            // 
            this.label_nom_election.AutoSize = true;
            this.label_nom_election.Location = new System.Drawing.Point(31, 102);
            this.label_nom_election.Name = "label_nom_election";
            this.label_nom_election.Size = new System.Drawing.Size(94, 13);
            this.label_nom_election.TabIndex = 15;
            this.label_nom_election.Text = "Nom de l\'élection: ";
            // 
            // label_date_election
            // 
            this.label_date_election.AutoSize = true;
            this.label_date_election.Location = new System.Drawing.Point(31, 137);
            this.label_date_election.Name = "label_date_election";
            this.label_date_election.Size = new System.Drawing.Size(86, 13);
            this.label_date_election.TabIndex = 16;
            this.label_date_election.Text = "Dae de l\'élection";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumero,
            this.columnNom,
            this.columnPrenom,
            this.columnCourriel});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 166);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(731, 259);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnNumero
            // 
            this.columnNumero.Text = "Numéro";
            this.columnNumero.Width = 79;
            // 
            // columnNom
            // 
            this.columnNom.Text = "Nom";
            // 
            // columnPrenom
            // 
            this.columnPrenom.Text = "Prenom";
            this.columnPrenom.Width = 113;
            // 
            // columnCourriel
            // 
            this.columnCourriel.Text = "Courriel";
            this.columnCourriel.Width = 238;
            // 
            // FormListElecteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_date_election);
            this.Controls.Add(this.label_nom_election);
            this.Controls.Add(this.button_rechercher);
            this.Controls.Add(this.comboBox_circonscription);
            this.Controls.Add(this.label_recherche);
            this.Controls.Add(this.label_circonscription);
            this.Name = "FormListElecteurs";
            this.Text = "Liste des électeurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_circonscription;
        private System.Windows.Forms.Label label_recherche;
        private System.Windows.Forms.ComboBox comboBox_circonscription;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.Label label_nom_election;
        private System.Windows.Forms.Label label_date_election;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnNumero;
        private System.Windows.Forms.ColumnHeader columnNom;
        private System.Windows.Forms.ColumnHeader columnPrenom;
        private System.Windows.Forms.ColumnHeader columnCourriel;
    }
}