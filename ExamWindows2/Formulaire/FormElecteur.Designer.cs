namespace ExamWindows2.Formulaire
{
    partial class FormElecteur
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
            this.comboBox_circonscription = new System.Windows.Forms.ComboBox();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.label_numéro = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_circonscription = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_courriel = new System.Windows.Forms.Label();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_courriel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_circonscription
            // 
            this.comboBox_circonscription.FormattingEnabled = true;
            this.comboBox_circonscription.Items.AddRange(new object[] {
            "Gatineau",
            "Aylmer",
            "Hull"});
            this.comboBox_circonscription.Location = new System.Drawing.Point(376, 156);
            this.comboBox_circonscription.Name = "comboBox_circonscription";
            this.comboBox_circonscription.Size = new System.Drawing.Size(200, 21);
            this.comboBox_circonscription.TabIndex = 12;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouter.Location = new System.Drawing.Point(355, 375);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(126, 45);
            this.button_ajouter.TabIndex = 10;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            // 
            // label_numéro
            // 
            this.label_numéro.AutoSize = true;
            this.label_numéro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numéro.Location = new System.Drawing.Point(173, 107);
            this.label_numéro.Name = "label_numéro";
            this.label_numéro.Size = new System.Drawing.Size(107, 24);
            this.label_numéro.TabIndex = 8;
            this.label_numéro.Text = "Le numéro:";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Red;
            this.label_title.Location = new System.Drawing.Point(252, 39);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(324, 37);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "Gestion des électeurs";
            // 
            // label_circonscription
            // 
            this.label_circonscription.AutoSize = true;
            this.label_circonscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_circonscription.Location = new System.Drawing.Point(173, 156);
            this.label_circonscription.Name = "label_circonscription";
            this.label_circonscription.Size = new System.Drawing.Size(167, 24);
            this.label_circonscription.TabIndex = 13;
            this.label_circonscription.Text = "La circonscription :";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(173, 202);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(61, 24);
            this.label_nom.TabIndex = 14;
            this.label_nom.Text = "Nom :";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenom.Location = new System.Drawing.Point(173, 247);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(87, 24);
            this.label_prenom.TabIndex = 15;
            this.label_prenom.Text = "Prenom :";
            // 
            // label_courriel
            // 
            this.label_courriel.AutoSize = true;
            this.label_courriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_courriel.Location = new System.Drawing.Point(173, 303);
            this.label_courriel.Name = "label_courriel";
            this.label_courriel.Size = new System.Drawing.Size(76, 24);
            this.label_courriel.TabIndex = 16;
            this.label_courriel.Text = "Courriel";
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(376, 107);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(200, 20);
            this.textBox_numero.TabIndex = 17;
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(376, 202);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(200, 20);
            this.textBox_nom.TabIndex = 18;
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(376, 252);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(200, 20);
            this.textBox_prenom.TabIndex = 19;
            // 
            // textBox_courriel
            // 
            this.textBox_courriel.Location = new System.Drawing.Point(376, 303);
            this.textBox_courriel.Name = "textBox_courriel";
            this.textBox_courriel.Size = new System.Drawing.Size(200, 20);
            this.textBox_courriel.TabIndex = 20;
            // 
            // FormElecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_courriel);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.textBox_numero);
            this.Controls.Add(this.label_courriel);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_circonscription);
            this.Controls.Add(this.comboBox_circonscription);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.label_numéro);
            this.Controls.Add(this.label_title);
            this.Name = "FormElecteur";
            this.Text = "FormElecteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_circonscription;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Label label_numéro;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_circonscription;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_courriel;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_courriel;
    }
}