
namespace DecouverteWinForm
{
    partial class EcranEditeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranEditeur));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichier_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveau_fichier_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrir_fichier_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrer_fichier_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.quitter_fichier_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.edition_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.copier_edition_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.couper_edition_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.coller_edition_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.formater_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.justifier_formater_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.gauche_justifier_formater_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.centre_justifier_formater_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.droite_justifier_formater_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.police_formater_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.caractère_formater_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.gras_caractère_formater_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.italique_caractère_formater_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.souligné_caractère_formater_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.barré_caractère_formater_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.btn_picture_quitter = new System.Windows.Forms.PictureBox();
            this.btn_picture_sauvgarder_sous = new System.Windows.Forms.PictureBox();
            this.btn_picture_sauvgarder = new System.Windows.Forms.PictureBox();
            this.btn_picture_nouveau_fichier = new System.Windows.Forms.PictureBox();
            this.rtbTexte = new System.Windows.Forms.RichTextBox();
            this.ofdOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.sfdEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.fdPolice = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_picture_quitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_picture_sauvgarder_sous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_picture_sauvgarder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_picture_nouveau_fichier)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichier_menu,
            this.edition_menu,
            this.formater_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichier_menu
            // 
            this.fichier_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveau_fichier_menu,
            this.ouvrir_fichier_menu,
            this.enregistrer_fichier_menu,
            this.quitter_fichier_menu});
            this.fichier_menu.Name = "fichier_menu";
            this.fichier_menu.Size = new System.Drawing.Size(54, 20);
            this.fichier_menu.Text = "Fichier";
            // 
            // nouveau_fichier_menu
            // 
            this.nouveau_fichier_menu.Name = "nouveau_fichier_menu";
            this.nouveau_fichier_menu.Size = new System.Drawing.Size(130, 22);
            this.nouveau_fichier_menu.Text = "Nouveau";
            // 
            // ouvrir_fichier_menu
            // 
            this.ouvrir_fichier_menu.Name = "ouvrir_fichier_menu";
            this.ouvrir_fichier_menu.Size = new System.Drawing.Size(130, 22);
            this.ouvrir_fichier_menu.Text = "Ouvrir";
            this.ouvrir_fichier_menu.Click += new System.EventHandler(this.ouvrir_fichier_menu_Click);
            // 
            // enregistrer_fichier_menu
            // 
            this.enregistrer_fichier_menu.Name = "enregistrer_fichier_menu";
            this.enregistrer_fichier_menu.Size = new System.Drawing.Size(130, 22);
            this.enregistrer_fichier_menu.Text = "Enregistrer";
            this.enregistrer_fichier_menu.Click += new System.EventHandler(this.enregistrer_fichier_menu_Click);
            // 
            // quitter_fichier_menu
            // 
            this.quitter_fichier_menu.Name = "quitter_fichier_menu";
            this.quitter_fichier_menu.Size = new System.Drawing.Size(130, 22);
            this.quitter_fichier_menu.Text = "Quitter";
            // 
            // edition_menu
            // 
            this.edition_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copier_edition_menu,
            this.couper_edition_menu,
            this.coller_edition_menu});
            this.edition_menu.Name = "edition_menu";
            this.edition_menu.Size = new System.Drawing.Size(56, 20);
            this.edition_menu.Text = "Edition";
            // 
            // copier_edition_menu
            // 
            this.copier_edition_menu.Name = "copier_edition_menu";
            this.copier_edition_menu.Size = new System.Drawing.Size(113, 22);
            this.copier_edition_menu.Text = "Copier";
            // 
            // couper_edition_menu
            // 
            this.couper_edition_menu.Name = "couper_edition_menu";
            this.couper_edition_menu.Size = new System.Drawing.Size(113, 22);
            this.couper_edition_menu.Text = "Couper";
            // 
            // coller_edition_menu
            // 
            this.coller_edition_menu.Name = "coller_edition_menu";
            this.coller_edition_menu.Size = new System.Drawing.Size(113, 22);
            this.coller_edition_menu.Text = "Coller";
            // 
            // formater_menu
            // 
            this.formater_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.justifier_formater_menu,
            this.police_formater_menu,
            this.caractère_formater_menu});
            this.formater_menu.Name = "formater_menu";
            this.formater_menu.Size = new System.Drawing.Size(67, 20);
            this.formater_menu.Text = "Formater";
            // 
            // justifier_formater_menu
            // 
            this.justifier_formater_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gauche_justifier_formater_menu,
            this.centre_justifier_formater_menu,
            this.droite_justifier_formater_menu});
            this.justifier_formater_menu.Name = "justifier_formater_menu";
            this.justifier_formater_menu.Size = new System.Drawing.Size(180, 22);
            this.justifier_formater_menu.Text = "Justifier";
            // 
            // gauche_justifier_formater_menu
            // 
            this.gauche_justifier_formater_menu.Name = "gauche_justifier_formater_menu";
            this.gauche_justifier_formater_menu.Size = new System.Drawing.Size(180, 22);
            this.gauche_justifier_formater_menu.Text = "Gauche";
            this.gauche_justifier_formater_menu.Click += new System.EventHandler(this.gauche_justifier_formater_menu_Click);
            // 
            // centre_justifier_formater_menu
            // 
            this.centre_justifier_formater_menu.Name = "centre_justifier_formater_menu";
            this.centre_justifier_formater_menu.Size = new System.Drawing.Size(180, 22);
            this.centre_justifier_formater_menu.Text = "Centre";
            this.centre_justifier_formater_menu.Click += new System.EventHandler(this.centre_justifier_formater_menu_Click);
            // 
            // droite_justifier_formater_menu
            // 
            this.droite_justifier_formater_menu.Name = "droite_justifier_formater_menu";
            this.droite_justifier_formater_menu.Size = new System.Drawing.Size(180, 22);
            this.droite_justifier_formater_menu.Text = "Droite";
            this.droite_justifier_formater_menu.Click += new System.EventHandler(this.droite_justifier_formater_menu_Click);
            // 
            // police_formater_menu
            // 
            this.police_formater_menu.Name = "police_formater_menu";
            this.police_formater_menu.Size = new System.Drawing.Size(124, 22);
            this.police_formater_menu.Text = "Police";
            // 
            // caractère_formater_menu
            // 
            this.caractère_formater_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gras_caractère_formater_menu,
            this.italique_caractère_formater_menu,
            this.souligné_caractère_formater_menu,
            this.barré_caractère_formater_menu});
            this.caractère_formater_menu.Name = "caractère_formater_menu";
            this.caractère_formater_menu.Size = new System.Drawing.Size(180, 22);
            this.caractère_formater_menu.Text = "Caractère";
            // 
            // gras_caractère_formater_menu
            // 
            this.gras_caractère_formater_menu.Name = "gras_caractère_formater_menu";
            this.gras_caractère_formater_menu.Size = new System.Drawing.Size(180, 22);
            this.gras_caractère_formater_menu.Text = "Gras";
            this.gras_caractère_formater_menu.Click += new System.EventHandler(this.gras_caractère_formater_menu_Click);
            // 
            // italique_caractère_formater_menu
            // 
            this.italique_caractère_formater_menu.Name = "italique_caractère_formater_menu";
            this.italique_caractère_formater_menu.Size = new System.Drawing.Size(180, 22);
            this.italique_caractère_formater_menu.Text = "Italique";
            this.italique_caractère_formater_menu.Click += new System.EventHandler(this.italique_caractère_formater_menu_Click);
            // 
            // souligné_caractère_formater_menu
            // 
            this.souligné_caractère_formater_menu.Name = "souligné_caractère_formater_menu";
            this.souligné_caractère_formater_menu.Size = new System.Drawing.Size(180, 22);
            this.souligné_caractère_formater_menu.Text = "Souligné";
            this.souligné_caractère_formater_menu.Click += new System.EventHandler(this.souligné_caractère_formater_menu_Click);
            // 
            // barré_caractère_formater_menu
            // 
            this.barré_caractère_formater_menu.Name = "barré_caractère_formater_menu";
            this.barré_caractère_formater_menu.Size = new System.Drawing.Size(180, 22);
            this.barré_caractère_formater_menu.Text = "Barré";
            this.barré_caractère_formater_menu.Click += new System.EventHandler(this.barré_caractère_formater_menu_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.btn_picture_quitter);
            this.imagePanel.Controls.Add(this.btn_picture_sauvgarder_sous);
            this.imagePanel.Controls.Add(this.btn_picture_sauvgarder);
            this.imagePanel.Controls.Add(this.btn_picture_nouveau_fichier);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagePanel.Location = new System.Drawing.Point(0, 24);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(800, 38);
            this.imagePanel.TabIndex = 1;
            // 
            // btn_picture_quitter
            // 
            this.btn_picture_quitter.Image = global::DecouverteWinForm.Properties.Resources.exit_icon;
            this.btn_picture_quitter.Location = new System.Drawing.Point(135, 1);
            this.btn_picture_quitter.Name = "btn_picture_quitter";
            this.btn_picture_quitter.Size = new System.Drawing.Size(38, 34);
            this.btn_picture_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_picture_quitter.TabIndex = 3;
            this.btn_picture_quitter.TabStop = false;
            this.btn_picture_quitter.Click += new System.EventHandler(this.btn_picture_quitter_Click);
            // 
            // btn_picture_sauvgarder_sous
            // 
            this.btn_picture_sauvgarder_sous.Image = global::DecouverteWinForm.Properties.Resources.save_under_icon;
            this.btn_picture_sauvgarder_sous.Location = new System.Drawing.Point(91, 1);
            this.btn_picture_sauvgarder_sous.Name = "btn_picture_sauvgarder_sous";
            this.btn_picture_sauvgarder_sous.Size = new System.Drawing.Size(38, 34);
            this.btn_picture_sauvgarder_sous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_picture_sauvgarder_sous.TabIndex = 2;
            this.btn_picture_sauvgarder_sous.TabStop = false;
            this.btn_picture_sauvgarder_sous.Click += new System.EventHandler(this.btn_picture_sauvgarder_sous_Click);
            // 
            // btn_picture_sauvgarder
            // 
            this.btn_picture_sauvgarder.Image = global::DecouverteWinForm.Properties.Resources.save_icon;
            this.btn_picture_sauvgarder.Location = new System.Drawing.Point(47, 1);
            this.btn_picture_sauvgarder.Name = "btn_picture_sauvgarder";
            this.btn_picture_sauvgarder.Size = new System.Drawing.Size(38, 35);
            this.btn_picture_sauvgarder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_picture_sauvgarder.TabIndex = 1;
            this.btn_picture_sauvgarder.TabStop = false;
            this.btn_picture_sauvgarder.Click += new System.EventHandler(this.btn_picture_sauvgarder_Click);
            // 
            // btn_picture_nouveau_fichier
            // 
            this.btn_picture_nouveau_fichier.Image = global::DecouverteWinForm.Properties.Resources.new_file_icon;
            this.btn_picture_nouveau_fichier.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_picture_nouveau_fichier.InitialImage")));
            this.btn_picture_nouveau_fichier.Location = new System.Drawing.Point(3, 1);
            this.btn_picture_nouveau_fichier.Name = "btn_picture_nouveau_fichier";
            this.btn_picture_nouveau_fichier.Size = new System.Drawing.Size(38, 34);
            this.btn_picture_nouveau_fichier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_picture_nouveau_fichier.TabIndex = 0;
            this.btn_picture_nouveau_fichier.TabStop = false;
            this.btn_picture_nouveau_fichier.Click += new System.EventHandler(this.btn_picture_nouveau_fichier_Click);
            // 
            // rtbTexte
            // 
            this.rtbTexte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTexte.Location = new System.Drawing.Point(0, 62);
            this.rtbTexte.Name = "rtbTexte";
            this.rtbTexte.Size = new System.Drawing.Size(800, 388);
            this.rtbTexte.TabIndex = 2;
            this.rtbTexte.Text = "";
            this.rtbTexte.TextChanged += new System.EventHandler(this.rtbTexte_TextChanged);
            // 
            // sfdEnregistrer
            // 
            this.sfdEnregistrer.FileName = "nom-du-fichier";
            // 
            // Editeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbTexte);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editeur";
            this.Text = "Editeur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_picture_quitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_picture_sauvgarder_sous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_picture_sauvgarder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_picture_nouveau_fichier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichier_menu;
        private System.Windows.Forms.ToolStripMenuItem nouveau_fichier_menu;
        private System.Windows.Forms.ToolStripMenuItem ouvrir_fichier_menu;
        private System.Windows.Forms.ToolStripMenuItem enregistrer_fichier_menu;
        private System.Windows.Forms.ToolStripMenuItem quitter_fichier_menu;
        private System.Windows.Forms.ToolStripMenuItem edition_menu;
        private System.Windows.Forms.ToolStripMenuItem copier_edition_menu;
        private System.Windows.Forms.ToolStripMenuItem couper_edition_menu;
        private System.Windows.Forms.ToolStripMenuItem coller_edition_menu;
        private System.Windows.Forms.ToolStripMenuItem formater_menu;
        private System.Windows.Forms.ToolStripMenuItem justifier_formater_menu;
        private System.Windows.Forms.ToolStripMenuItem gauche_justifier_formater_menu;
        private System.Windows.Forms.ToolStripMenuItem centre_justifier_formater_menu;
        private System.Windows.Forms.ToolStripMenuItem droite_justifier_formater_menu;
        private System.Windows.Forms.ToolStripMenuItem police_formater_menu;
        private System.Windows.Forms.ToolStripMenuItem caractère_formater_menu;
        private System.Windows.Forms.ToolStripMenuItem gras_caractère_formater_menu;
        private System.Windows.Forms.ToolStripMenuItem italique_caractère_formater_menu;
        private System.Windows.Forms.ToolStripMenuItem souligné_caractère_formater_menu;
        private System.Windows.Forms.ToolStripMenuItem barré_caractère_formater_menu;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox btn_picture_quitter;
        private System.Windows.Forms.PictureBox btn_picture_sauvgarder_sous;
        private System.Windows.Forms.PictureBox btn_picture_sauvgarder;
        private System.Windows.Forms.PictureBox btn_picture_nouveau_fichier;
        private System.Windows.Forms.RichTextBox rtbTexte;
        private System.Windows.Forms.OpenFileDialog ofdOuvrir;
        private System.Windows.Forms.SaveFileDialog sfdEnregistrer;
        private System.Windows.Forms.FontDialog fdPolice;
    }
}