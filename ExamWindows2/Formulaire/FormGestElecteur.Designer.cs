﻿namespace ExamWindows2.Formulaire
{
    partial class FormGestElecteur
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.électionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.électeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeÉlecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.électionToolStripMenuItem,
            this.électeurToolStripMenuItem,
            this.listeÉlecteurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // électionToolStripMenuItem
            // 
            this.électionToolStripMenuItem.Name = "électionToolStripMenuItem";
            this.électionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.électionToolStripMenuItem.Text = "Élection";
            this.électionToolStripMenuItem.Click += new System.EventHandler(this.électionToolStripMenuItem_Click);
            // 
            // électeurToolStripMenuItem
            // 
            this.électeurToolStripMenuItem.Name = "électeurToolStripMenuItem";
            this.électeurToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.électeurToolStripMenuItem.Text = "Électeur";
            this.électeurToolStripMenuItem.Click += new System.EventHandler(this.électeurToolStripMenuItem_Click);
            // 
            // listeÉlecteurToolStripMenuItem
            // 
            this.listeÉlecteurToolStripMenuItem.Name = "listeÉlecteurToolStripMenuItem";
            this.listeÉlecteurToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.listeÉlecteurToolStripMenuItem.Text = "Liste électeur";
            this.listeÉlecteurToolStripMenuItem.Click += new System.EventHandler(this.listeÉlecteurToolStripMenuItem_Click);
            // 
            // FormGestElecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGestElecteur";
            this.Text = "Gestion de l\'élection";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem électionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem électeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeÉlecteurToolStripMenuItem;
    }
}