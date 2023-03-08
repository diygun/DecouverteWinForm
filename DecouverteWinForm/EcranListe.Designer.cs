
namespace DecouverteWinForm
{
    partial class EcranListe
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
            this.label1 = new System.Windows.Forms.Label();
            this.listePersonnes = new System.Windows.Forms.ListBox();
            this.btnOuvrirDoc = new System.Windows.Forms.Button();
            this.btnEnregistrerPErsonne = new System.Windows.Forms.Button();
            this.grBoxDetailPersonne = new System.Windows.Forms.GroupBox();
            this.btnAnnulerDetPersonne = new System.Windows.Forms.Button();
            this.btnConfirmerDetPersonne = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.lQualite = new System.Windows.Forms.Label();
            this.comboBoxQualite = new System.Windows.Forms.ComboBox();
            this.btnAjouterDetPersonne = new System.Windows.Forms.Button();
            this.btnSupprimerPersonne = new System.Windows.Forms.Button();
            this.grBoxDetailPersonne.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de fichier";
            // 
            // listePersonnes
            // 
            this.listePersonnes.FormattingEnabled = true;
            this.listePersonnes.Location = new System.Drawing.Point(16, 30);
            this.listePersonnes.Name = "listePersonnes";
            this.listePersonnes.Size = new System.Drawing.Size(422, 147);
            this.listePersonnes.Sorted = true;
            this.listePersonnes.TabIndex = 1;
            this.listePersonnes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listePersonnes_MouseDoubleClick);
            // 
            // btnOuvrirDoc
            // 
            this.btnOuvrirDoc.Location = new System.Drawing.Point(16, 184);
            this.btnOuvrirDoc.Name = "btnOuvrirDoc";
            this.btnOuvrirDoc.Size = new System.Drawing.Size(75, 23);
            this.btnOuvrirDoc.TabIndex = 2;
            this.btnOuvrirDoc.Text = "Ouvrir";
            this.btnOuvrirDoc.UseVisualStyleBackColor = true;
            this.btnOuvrirDoc.Click += new System.EventHandler(this.btnOuvrirDoc_Click);
            // 
            // btnEnregistrerPErsonne
            // 
            this.btnEnregistrerPErsonne.Location = new System.Drawing.Point(16, 214);
            this.btnEnregistrerPErsonne.Name = "btnEnregistrerPErsonne";
            this.btnEnregistrerPErsonne.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerPErsonne.TabIndex = 3;
            this.btnEnregistrerPErsonne.Text = "Enregistrer";
            this.btnEnregistrerPErsonne.UseVisualStyleBackColor = true;
            this.btnEnregistrerPErsonne.Click += new System.EventHandler(this.btnEnregistrerPErsonne_Click);
            // 
            // grBoxDetailPersonne
            // 
            this.grBoxDetailPersonne.Controls.Add(this.btnAnnulerDetPersonne);
            this.grBoxDetailPersonne.Controls.Add(this.btnConfirmerDetPersonne);
            this.grBoxDetailPersonne.Controls.Add(this.textBoxNom);
            this.grBoxDetailPersonne.Controls.Add(this.lNom);
            this.grBoxDetailPersonne.Controls.Add(this.lQualite);
            this.grBoxDetailPersonne.Controls.Add(this.comboBoxQualite);
            this.grBoxDetailPersonne.Location = new System.Drawing.Point(209, 184);
            this.grBoxDetailPersonne.Name = "grBoxDetailPersonne";
            this.grBoxDetailPersonne.Size = new System.Drawing.Size(229, 162);
            this.grBoxDetailPersonne.TabIndex = 5;
            this.grBoxDetailPersonne.TabStop = false;
            this.grBoxDetailPersonne.Text = "Détail personne";
            // 
            // btnAnnulerDetPersonne
            // 
            this.btnAnnulerDetPersonne.Location = new System.Drawing.Point(91, 133);
            this.btnAnnulerDetPersonne.Name = "btnAnnulerDetPersonne";
            this.btnAnnulerDetPersonne.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerDetPersonne.TabIndex = 5;
            this.btnAnnulerDetPersonne.Text = "Annuler";
            this.btnAnnulerDetPersonne.UseVisualStyleBackColor = true;
            this.btnAnnulerDetPersonne.Click += new System.EventHandler(this.btnAnnulerDetPersonne_Click);
            // 
            // btnConfirmerDetPersonne
            // 
            this.btnConfirmerDetPersonne.Location = new System.Drawing.Point(10, 133);
            this.btnConfirmerDetPersonne.Name = "btnConfirmerDetPersonne";
            this.btnConfirmerDetPersonne.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmerDetPersonne.TabIndex = 4;
            this.btnConfirmerDetPersonne.Text = "Confrmer";
            this.btnConfirmerDetPersonne.UseVisualStyleBackColor = true;
            this.btnConfirmerDetPersonne.Click += new System.EventHandler(this.btnConfirmerDetPersonne_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(6, 93);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(121, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(10, 76);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(29, 13);
            this.lNom.TabIndex = 2;
            this.lNom.Text = "Nom";
            // 
            // lQualite
            // 
            this.lQualite.AutoSize = true;
            this.lQualite.Location = new System.Drawing.Point(7, 24);
            this.lQualite.Name = "lQualite";
            this.lQualite.Size = new System.Drawing.Size(40, 13);
            this.lQualite.TabIndex = 1;
            this.lQualite.Text = "Qualité";
            // 
            // comboBoxQualite
            // 
            this.comboBoxQualite.FormattingEnabled = true;
            this.comboBoxQualite.Items.AddRange(new object[] {
            "M.",
            "Mme.",
            "Pingouin"});
            this.comboBoxQualite.Location = new System.Drawing.Point(6, 43);
            this.comboBoxQualite.Name = "comboBoxQualite";
            this.comboBoxQualite.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQualite.TabIndex = 0;
            // 
            // btnAjouterDetPersonne
            // 
            this.btnAjouterDetPersonne.Location = new System.Drawing.Point(16, 277);
            this.btnAjouterDetPersonne.Name = "btnAjouterDetPersonne";
            this.btnAjouterDetPersonne.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterDetPersonne.TabIndex = 6;
            this.btnAjouterDetPersonne.Text = "Ajouter";
            this.btnAjouterDetPersonne.UseVisualStyleBackColor = true;
            this.btnAjouterDetPersonne.Click += new System.EventHandler(this.btnAjouterDetPersonne_Click);
            // 
            // btnSupprimerPersonne
            // 
            this.btnSupprimerPersonne.Location = new System.Drawing.Point(16, 307);
            this.btnSupprimerPersonne.Name = "btnSupprimerPersonne";
            this.btnSupprimerPersonne.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerPersonne.TabIndex = 7;
            this.btnSupprimerPersonne.Text = "Supprimer";
            this.btnSupprimerPersonne.UseVisualStyleBackColor = true;
            this.btnSupprimerPersonne.Click += new System.EventHandler(this.btnSupprimerPersonne_Click);
            // 
            // EcranListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 357);
            this.Controls.Add(this.btnSupprimerPersonne);
            this.Controls.Add(this.btnAjouterDetPersonne);
            this.Controls.Add(this.grBoxDetailPersonne);
            this.Controls.Add(this.btnEnregistrerPErsonne);
            this.Controls.Add(this.btnOuvrirDoc);
            this.Controls.Add(this.listePersonnes);
            this.Controls.Add(this.label1);
            this.Name = "EcranListe";
            this.Text = "EcranListe";
            this.grBoxDetailPersonne.ResumeLayout(false);
            this.grBoxDetailPersonne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listePersonnes;
        private System.Windows.Forms.Button btnOuvrirDoc;
        private System.Windows.Forms.Button btnEnregistrerPErsonne;
        private System.Windows.Forms.GroupBox grBoxDetailPersonne;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lQualite;
        private System.Windows.Forms.ComboBox comboBoxQualite;
        private System.Windows.Forms.Button btnAnnulerDetPersonne;
        private System.Windows.Forms.Button btnConfirmerDetPersonne;
        private System.Windows.Forms.Button btnAjouterDetPersonne;
        private System.Windows.Forms.Button btnSupprimerPersonne;
    }
}