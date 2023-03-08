
namespace DecouverteWinForm
{
    partial class EcranSpirographe
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
            this.gbParametrage = new System.Windows.Forms.GroupBox();
            this.btnFond = new System.Windows.Forms.Button();
            this.btnTrait = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbProfondeur = new System.Windows.Forms.TrackBar();
            this.tbSommet = new System.Windows.Forms.TrackBar();
            this.tbDensite = new System.Windows.Forms.TrackBar();
            this.lProfondeur = new System.Windows.Forms.Label();
            this.lDensite = new System.Windows.Forms.Label();
            this.lSommets = new System.Windows.Forms.Label();
            this.cdCouleur = new System.Windows.Forms.ColorDialog();
            this.gbParametrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametrage
            // 
            this.gbParametrage.Controls.Add(this.btnFond);
            this.gbParametrage.Controls.Add(this.btnTrait);
            this.gbParametrage.Controls.Add(this.btnGo);
            this.gbParametrage.Controls.Add(this.tbProfondeur);
            this.gbParametrage.Controls.Add(this.tbSommet);
            this.gbParametrage.Controls.Add(this.tbDensite);
            this.gbParametrage.Controls.Add(this.lProfondeur);
            this.gbParametrage.Controls.Add(this.lDensite);
            this.gbParametrage.Controls.Add(this.lSommets);
            this.gbParametrage.Location = new System.Drawing.Point(12, 12);
            this.gbParametrage.Name = "gbParametrage";
            this.gbParametrage.Size = new System.Drawing.Size(191, 337);
            this.gbParametrage.TabIndex = 1;
            this.gbParametrage.TabStop = false;
            this.gbParametrage.Text = "Parametrage";
            // 
            // btnFond
            // 
            this.btnFond.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFond.Location = new System.Drawing.Point(107, 291);
            this.btnFond.Name = "btnFond";
            this.btnFond.Size = new System.Drawing.Size(78, 40);
            this.btnFond.TabIndex = 5;
            this.btnFond.Text = "Fond";
            this.btnFond.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFond.UseVisualStyleBackColor = true;
            // 
            // btnTrait
            // 
            this.btnTrait.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTrait.Location = new System.Drawing.Point(6, 291);
            this.btnTrait.Name = "btnTrait";
            this.btnTrait.Size = new System.Drawing.Size(78, 40);
            this.btnTrait.TabIndex = 4;
            this.btnTrait.Text = "trait";
            this.btnTrait.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrait.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(6, 222);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(179, 35);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "GO !";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbProfondeur
            // 
            this.tbProfondeur.Location = new System.Drawing.Point(6, 171);
            this.tbProfondeur.Maximum = 80;
            this.tbProfondeur.Minimum = 20;
            this.tbProfondeur.Name = "tbProfondeur";
            this.tbProfondeur.Size = new System.Drawing.Size(179, 45);
            this.tbProfondeur.TabIndex = 2;
            this.tbProfondeur.Value = 20;
            // 
            // tbSommet
            // 
            this.tbSommet.Location = new System.Drawing.Point(6, 43);
            this.tbSommet.Maximum = 8;
            this.tbSommet.Minimum = 3;
            this.tbSommet.Name = "tbSommet";
            this.tbSommet.Size = new System.Drawing.Size(179, 45);
            this.tbSommet.TabIndex = 0;
            this.tbSommet.Value = 3;
            // 
            // tbDensite
            // 
            this.tbDensite.Location = new System.Drawing.Point(6, 107);
            this.tbDensite.Maximum = 20;
            this.tbDensite.Minimum = 5;
            this.tbDensite.Name = "tbDensite";
            this.tbDensite.Size = new System.Drawing.Size(179, 45);
            this.tbDensite.TabIndex = 1;
            this.tbDensite.Value = 5;
            // 
            // lProfondeur
            // 
            this.lProfondeur.AutoSize = true;
            this.lProfondeur.Location = new System.Drawing.Point(10, 155);
            this.lProfondeur.Name = "lProfondeur";
            this.lProfondeur.Size = new System.Drawing.Size(154, 13);
            this.lProfondeur.TabIndex = 2;
            this.lProfondeur.Text = "Profoindeur de dessin (20 à 80)";
            // 
            // lDensite
            // 
            this.lDensite.AutoSize = true;
            this.lDensite.Location = new System.Drawing.Point(10, 91);
            this.lDensite.Name = "lDensite";
            this.lDensite.Size = new System.Drawing.Size(135, 13);
            this.lDensite.TabIndex = 1;
            this.lDensite.Text = "Densité de dessins (5 à 20)";
            // 
            // lSommets
            // 
            this.lSommets.AutoSize = true;
            this.lSommets.Location = new System.Drawing.Point(10, 27);
            this.lSommets.Name = "lSommets";
            this.lSommets.Size = new System.Drawing.Size(136, 13);
            this.lSommets.TabIndex = 0;
            this.lSommets.Text = "Nombre de sommets (3 à 8)";
            // 
            // EcranSpirographe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbParametrage);
            this.Name = "EcranSpirographe";
            this.Text = "EcranSpirographe";
            this.gbParametrage.ResumeLayout(false);
            this.gbParametrage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametrage;
        private System.Windows.Forms.Button btnFond;
        private System.Windows.Forms.Button btnTrait;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TrackBar tbProfondeur;
        private System.Windows.Forms.TrackBar tbSommet;
        private System.Windows.Forms.TrackBar tbDensite;
        private System.Windows.Forms.Label lProfondeur;
        private System.Windows.Forms.Label lDensite;
        private System.Windows.Forms.Label lSommets;
        private System.Windows.Forms.ColorDialog cdCouleur;
    }
}