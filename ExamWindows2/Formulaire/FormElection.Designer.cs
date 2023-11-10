namespace ExamWindows2.Formulaire
{
    partial class FormElection
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.button_creer = new System.Windows.Forms.Button();
            this.dateTimePicker_date_election = new System.Windows.Forms.DateTimePicker();
            this.comboBox_nom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Red;
            this.label_title.Location = new System.Drawing.Point(244, 71);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(321, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Gestion des élections";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(222, 163);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(51, 24);
            this.label_nom.TabIndex = 1;
            this.label_nom.Text = "Nom";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(225, 244);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(48, 24);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "Date";
            // 
            // button_creer
            // 
            this.button_creer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_creer.Location = new System.Drawing.Point(334, 322);
            this.button_creer.Name = "button_creer";
            this.button_creer.Size = new System.Drawing.Size(126, 45);
            this.button_creer.TabIndex = 3;
            this.button_creer.Text = "Créer";
            this.button_creer.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_date_election
            // 
            this.dateTimePicker_date_election.Location = new System.Drawing.Point(347, 248);
            this.dateTimePicker_date_election.Name = "dateTimePicker_date_election";
            this.dateTimePicker_date_election.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_date_election.TabIndex = 5;
            // 
            // comboBox_nom
            // 
            this.comboBox_nom.FormattingEnabled = true;
            this.comboBox_nom.Items.AddRange(new object[] {
            "Municipal",
            "Provinciale",
            "Fédérale"});
            this.comboBox_nom.Location = new System.Drawing.Point(347, 163);
            this.comboBox_nom.Name = "comboBox_nom";
            this.comboBox_nom.Size = new System.Drawing.Size(200, 21);
            this.comboBox_nom.TabIndex = 6;
            // 
            // FormElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_nom);
            this.Controls.Add(this.dateTimePicker_date_election);
            this.Controls.Add(this.button_creer);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_title);
            this.Name = "FormElection";
            this.Text = "Élection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button button_creer;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date_election;
        private System.Windows.Forms.ComboBox comboBox_nom;
    }
}