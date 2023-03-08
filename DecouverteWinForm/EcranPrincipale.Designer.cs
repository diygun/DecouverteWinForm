
using System.Windows.Forms;

namespace DecouverteWinForm
{
    partial class EcranPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranPrincipale));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAfficherFenaitre = new System.Windows.Forms.Button();
            this.btnNomCustom = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Controles_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Controles_Liste_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Controles_Editeur_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Controles_BarreDeProgra_MEnu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Controles_Quitter_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Application_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Application_Editeur_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Application_Spirographe_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Application_Horloge_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Application_Monitoring_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Application_ExplorateurDeFichier_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Aide_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Aide_APropos_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(46, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliquer sur ce bouton pour afficher la nouvelle fenaitre";
            // 
            // btnAfficherFenaitre
            // 
            this.btnAfficherFenaitre.Location = new System.Drawing.Point(399, 396);
            this.btnAfficherFenaitre.Name = "btnAfficherFenaitre";
            this.btnAfficherFenaitre.Size = new System.Drawing.Size(201, 98);
            this.btnAfficherFenaitre.TabIndex = 1;
            this.btnAfficherFenaitre.Text = "Afficher Fenaitre";
            this.btnAfficherFenaitre.UseVisualStyleBackColor = true;
            this.btnAfficherFenaitre.Click += new System.EventHandler(this.btnAfficherFenaitre_Click);
            // 
            // btnNomCustom
            // 
            this.btnNomCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomCustom.Location = new System.Drawing.Point(674, 310);
            this.btnNomCustom.Name = "btnNomCustom";
            this.btnNomCustom.Size = new System.Drawing.Size(220, 74);
            this.btnNomCustom.TabIndex = 2;
            this.btnNomCustom.Text = "Ce bouton a un nom personallisée";
            this.btnNomCustom.UseVisualStyleBackColor = true;
            this.btnNomCustom.Click += new System.EventHandler(this.btnNomCustom_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Controles_Menu,
            this.Application_Menu,
            this.Aide_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Controles_Menu
            // 
            this.Controles_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Controles_Liste_Menu,
            this.Controles_Editeur_Menu,
            this.Controles_BarreDeProgra_MEnu,
            this.toolStripSeparator1,
            this.Controles_Quitter_Menu});
            this.Controles_Menu.Name = "Controles_Menu";
            this.Controles_Menu.Size = new System.Drawing.Size(70, 20);
            this.Controles_Menu.Text = "Contrôles";
            // 
            // Controles_Liste_Menu
            // 
            this.Controles_Liste_Menu.Name = "Controles_Liste_Menu";
            this.Controles_Liste_Menu.Size = new System.Drawing.Size(176, 22);
            this.Controles_Liste_Menu.Text = "Liste";
            this.Controles_Liste_Menu.Click += new System.EventHandler(this.Controles_Liste_Menu_Click);
            // 
            // Controles_Editeur_Menu
            // 
            this.Controles_Editeur_Menu.Name = "Controles_Editeur_Menu";
            this.Controles_Editeur_Menu.Size = new System.Drawing.Size(176, 22);
            this.Controles_Editeur_Menu.Text = "Editeur";
            this.Controles_Editeur_Menu.Click += new System.EventHandler(this.Controles_Editeur_Menu_Click);
            // 
            // Controles_BarreDeProgra_MEnu
            // 
            this.Controles_BarreDeProgra_MEnu.Name = "Controles_BarreDeProgra_MEnu";
            this.Controles_BarreDeProgra_MEnu.Size = new System.Drawing.Size(176, 22);
            this.Controles_BarreDeProgra_MEnu.Text = "Barre d progression";
            this.Controles_BarreDeProgra_MEnu.Click += new System.EventHandler(this.Controles_BarreDeProgra_MEnu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // Controles_Quitter_Menu
            // 
            this.Controles_Quitter_Menu.Name = "Controles_Quitter_Menu";
            this.Controles_Quitter_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.Controles_Quitter_Menu.Size = new System.Drawing.Size(176, 22);
            this.Controles_Quitter_Menu.Text = "Quitter";
            this.Controles_Quitter_Menu.Click += new System.EventHandler(this.Controles_Quitter_Menu_Click);
            // 
            // Application_Menu
            // 
            this.Application_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Application_Editeur_Menu,
            this.Application_Spirographe_Menu,
            this.Application_Horloge_Menu,
            this.Application_Monitoring_Menu,
            this.Application_ExplorateurDeFichier_Menu});
            this.Application_Menu.Name = "Application_Menu";
            this.Application_Menu.Size = new System.Drawing.Size(85, 20);
            this.Application_Menu.Text = "Applications";
            // 
            // Application_Editeur_Menu
            // 
            this.Application_Editeur_Menu.Name = "Application_Editeur_Menu";
            this.Application_Editeur_Menu.Size = new System.Drawing.Size(208, 22);
            this.Application_Editeur_Menu.Text = "Editeur";
            this.Application_Editeur_Menu.Click += new System.EventHandler(this.Application_Editeur_Menu_Click);
            // 
            // Application_Spirographe_Menu
            // 
            this.Application_Spirographe_Menu.Name = "Application_Spirographe_Menu";
            this.Application_Spirographe_Menu.Size = new System.Drawing.Size(208, 22);
            this.Application_Spirographe_Menu.Text = "Spirographe";
            this.Application_Spirographe_Menu.Click += new System.EventHandler(this.spirographeToolStripMenuItem_Click);
            // 
            // Application_Horloge_Menu
            // 
            this.Application_Horloge_Menu.Name = "Application_Horloge_Menu";
            this.Application_Horloge_Menu.Size = new System.Drawing.Size(208, 22);
            this.Application_Horloge_Menu.Text = "Horloge";
            this.Application_Horloge_Menu.Click += new System.EventHandler(this.horlogeToolStripMenuItem_Click);
            // 
            // Application_Monitoring_Menu
            // 
            this.Application_Monitoring_Menu.Name = "Application_Monitoring_Menu";
            this.Application_Monitoring_Menu.Size = new System.Drawing.Size(208, 22);
            this.Application_Monitoring_Menu.Text = "Monitoring Clavier Souris";
            this.Application_Monitoring_Menu.Click += new System.EventHandler(this.Application_Monitoring_Menu_Click);
            // 
            // Application_ExplorateurDeFichier_Menu
            // 
            this.Application_ExplorateurDeFichier_Menu.Name = "Application_ExplorateurDeFichier_Menu";
            this.Application_ExplorateurDeFichier_Menu.Size = new System.Drawing.Size(208, 22);
            this.Application_ExplorateurDeFichier_Menu.Text = "Explorateur de fichier";
            this.Application_ExplorateurDeFichier_Menu.Click += new System.EventHandler(this.Application_ExplorateurDeFichier_Menu_Click);
            // 
            // Aide_Menu
            // 
            this.Aide_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Aide_APropos_Menu});
            this.Aide_Menu.Name = "Aide_Menu";
            this.Aide_Menu.Size = new System.Drawing.Size(43, 20);
            this.Aide_Menu.Text = "Aide";
            // 
            // Aide_APropos_Menu
            // 
            this.Aide_APropos_Menu.Name = "Aide_APropos_Menu";
            this.Aide_APropos_Menu.Size = new System.Drawing.Size(122, 22);
            this.Aide_APropos_Menu.Text = "A Propos";
            this.Aide_APropos_Menu.Click += new System.EventHandler(this.Aide_APropos_Menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // EcranPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1051, 591);
            this.Controls.Add(this.btnNomCustom);
            this.Controls.Add(this.btnAfficherFenaitre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "EcranPrincipale";
            this.Text = "Ecran Principale";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button btnAfficherFenaitre;




        private const int CP_NOCLOSE_BUTTON = 0x200;
        private Button btnNomCustom;
        private Label label1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Controles_Menu;
        private ToolStripMenuItem Controles_Liste_Menu;
        private ToolStripMenuItem Controles_BarreDeProgra_MEnu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem Controles_Quitter_Menu;
        private ToolStripMenuItem Application_Menu;
        private ToolStripMenuItem Application_Editeur_Menu;
        private ToolStripMenuItem Aide_Menu;
        private ToolStripMenuItem Aide_APropos_Menu;

        // BLOQUE LA FERMETURE DE LA FENETRE
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams myCp = base.CreateParams;
        //        myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
        //        return myCp;
        //    }
        //}
        #endregion

        private ToolStripMenuItem Controles_Editeur_Menu;
        private ToolStripMenuItem Application_Spirographe_Menu;
        private ToolStripMenuItem Application_Horloge_Menu;
        private ToolStripMenuItem Application_Monitoring_Menu;
        private ToolStripMenuItem Application_ExplorateurDeFichier_Menu;
    }
}

