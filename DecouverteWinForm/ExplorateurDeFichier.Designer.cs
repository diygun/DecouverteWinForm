
namespace DecouverteWinForm
{
    partial class ExplorateurDeFichier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorateurDeFichier));
            this.tsCommandes = new System.Windows.Forms.ToolStrip();
            this.tsbQuitter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbApparence = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsaPetitesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaGrandesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaListe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMessage = new System.Windows.Forms.StatusStrip();
            this.slMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.scSeparateur = new System.Windows.Forms.SplitContainer();
            this.tvRepertoire = new System.Windows.Forms.TreeView();
            this.lvFichiers = new System.Windows.Forms.ListView();
            this.NOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAIL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CREA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MODI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilTreeView = new System.Windows.Forms.ImageList(this.components);
            this.ilGrand = new System.Windows.Forms.ImageList(this.components);
            this.ilPetit = new System.Windows.Forms.ImageList(this.components);
            this.tsCommandes.SuspendLayout();
            this.ssMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSeparateur)).BeginInit();
            this.scSeparateur.Panel1.SuspendLayout();
            this.scSeparateur.Panel2.SuspendLayout();
            this.scSeparateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCommandes
            // 
            this.tsCommandes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuitter,
            this.toolStripSeparator1,
            this.tsddbApparence});
            this.tsCommandes.Location = new System.Drawing.Point(0, 0);
            this.tsCommandes.Name = "tsCommandes";
            this.tsCommandes.Size = new System.Drawing.Size(1073, 25);
            this.tsCommandes.TabIndex = 0;
            this.tsCommandes.Text = "toolStrip1";
            // 
            // tsbQuitter
            // 
            this.tsbQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQuitter.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuitter.Image")));
            this.tsbQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuitter.Name = "tsbQuitter";
            this.tsbQuitter.Size = new System.Drawing.Size(23, 22);
            this.tsbQuitter.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddbApparence
            // 
            this.tsddbApparence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbApparence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsaPetitesIcones,
            this.tsaGrandesIcones,
            this.tsaListe,
            this.tsaDetail});
            this.tsddbApparence.Image = ((System.Drawing.Image)(resources.GetObject("tsddbApparence.Image")));
            this.tsddbApparence.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbApparence.Name = "tsddbApparence";
            this.tsddbApparence.Size = new System.Drawing.Size(29, 22);
            this.tsddbApparence.Text = "toolStripDropDownButton1";
            // 
            // tsaPetitesIcones
            // 
            this.tsaPetitesIcones.Name = "tsaPetitesIcones";
            this.tsaPetitesIcones.Size = new System.Drawing.Size(154, 22);
            this.tsaPetitesIcones.Text = "Petites icônes";
            // 
            // tsaGrandesIcones
            // 
            this.tsaGrandesIcones.Name = "tsaGrandesIcones";
            this.tsaGrandesIcones.Size = new System.Drawing.Size(154, 22);
            this.tsaGrandesIcones.Text = "Grandes icônes";
            // 
            // tsaListe
            // 
            this.tsaListe.Name = "tsaListe";
            this.tsaListe.Size = new System.Drawing.Size(154, 22);
            this.tsaListe.Text = "Liste";
            // 
            // tsaDetail
            // 
            this.tsaDetail.Name = "tsaDetail";
            this.tsaDetail.Size = new System.Drawing.Size(154, 22);
            this.tsaDetail.Text = "Detail";
            // 
            // ssMessage
            // 
            this.ssMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slMessage});
            this.ssMessage.Location = new System.Drawing.Point(0, 484);
            this.ssMessage.Name = "ssMessage";
            this.ssMessage.Size = new System.Drawing.Size(1073, 22);
            this.ssMessage.TabIndex = 1;
            this.ssMessage.Text = "statusStrip1";
            // 
            // slMessage
            // 
            this.slMessage.Name = "slMessage";
            this.slMessage.Size = new System.Drawing.Size(85, 17);
            this.slMessage.Text = "Chargement ...";
            // 
            // scSeparateur
            // 
            this.scSeparateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSeparateur.Location = new System.Drawing.Point(0, 25);
            this.scSeparateur.Name = "scSeparateur";
            // 
            // scSeparateur.Panel1
            // 
            this.scSeparateur.Panel1.Controls.Add(this.tvRepertoire);
            // 
            // scSeparateur.Panel2
            // 
            this.scSeparateur.Panel2.Controls.Add(this.lvFichiers);
            this.scSeparateur.Size = new System.Drawing.Size(1073, 459);
            this.scSeparateur.SplitterDistance = 506;
            this.scSeparateur.TabIndex = 2;
            // 
            // tvRepertoire
            // 
            this.tvRepertoire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRepertoire.Location = new System.Drawing.Point(0, 0);
            this.tvRepertoire.Name = "tvRepertoire";
            this.tvRepertoire.Size = new System.Drawing.Size(506, 459);
            this.tvRepertoire.TabIndex = 0;
            this.tvRepertoire.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRepertoire_AfterSelect);
            // 
            // lvFichiers
            // 
            this.lvFichiers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NOM,
            this.TAIL,
            this.CREA,
            this.MODI});
            this.lvFichiers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFichiers.HideSelection = false;
            this.lvFichiers.Location = new System.Drawing.Point(0, 0);
            this.lvFichiers.Name = "lvFichiers";
            this.lvFichiers.Size = new System.Drawing.Size(563, 459);
            this.lvFichiers.TabIndex = 0;
            this.lvFichiers.UseCompatibleStateImageBehavior = false;
            this.lvFichiers.View = System.Windows.Forms.View.Details;
            // 
            // NOM
            // 
            this.NOM.Text = "Nom";
            this.NOM.Width = 120;
            // 
            // TAIL
            // 
            this.TAIL.Text = "Taille";
            this.TAIL.Width = 124;
            // 
            // CREA
            // 
            this.CREA.Text = "Date de creation";
            this.CREA.Width = 120;
            // 
            // MODI
            // 
            this.MODI.Text = "Date de modification";
            this.MODI.Width = 157;
            // 
            // ilTreeView
            // 
            this.ilTreeView.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilTreeView.ImageSize = new System.Drawing.Size(16, 16);
            this.ilTreeView.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilGrand
            // 
            this.ilGrand.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilGrand.ImageSize = new System.Drawing.Size(16, 16);
            this.ilGrand.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilPetit
            // 
            this.ilPetit.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilPetit.ImageSize = new System.Drawing.Size(16, 16);
            this.ilPetit.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ExplorateurDeFichier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 506);
            this.Controls.Add(this.scSeparateur);
            this.Controls.Add(this.ssMessage);
            this.Controls.Add(this.tsCommandes);
            this.Name = "ExplorateurDeFichier";
            this.Text = "ExplorateurDeFichier";
            this.tsCommandes.ResumeLayout(false);
            this.tsCommandes.PerformLayout();
            this.ssMessage.ResumeLayout(false);
            this.ssMessage.PerformLayout();
            this.scSeparateur.Panel1.ResumeLayout(false);
            this.scSeparateur.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSeparateur)).EndInit();
            this.scSeparateur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCommandes;
        private System.Windows.Forms.ToolStripButton tsbQuitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbApparence;
        private System.Windows.Forms.ToolStripMenuItem tsaPetitesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsaGrandesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsaListe;
        private System.Windows.Forms.ToolStripMenuItem tsaDetail;
        private System.Windows.Forms.StatusStrip ssMessage;
        private System.Windows.Forms.ToolStripStatusLabel slMessage;
        private System.Windows.Forms.SplitContainer scSeparateur;
        private System.Windows.Forms.ListView lvFichiers;
        private System.Windows.Forms.TreeView tvRepertoire;
        private System.Windows.Forms.ColumnHeader NOM;
        private System.Windows.Forms.ColumnHeader TAIL;
        private System.Windows.Forms.ColumnHeader CREA;
        private System.Windows.Forms.ColumnHeader MODI;
        private System.Windows.Forms.ImageList ilTreeView;
        private System.Windows.Forms.ImageList ilGrand;
        private System.Windows.Forms.ImageList ilPetit;
    }
}