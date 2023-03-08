
namespace DecouverteWinForm
{
    partial class EcranClavierSouris
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
            this.pSouris = new System.Windows.Forms.Panel();
            this.lClavier = new System.Windows.Forms.Label();
            this.lClicGauche = new System.Windows.Forms.Label();
            this.lClicDroit = new System.Windows.Forms.Label();
            this.lPositionX = new System.Windows.Forms.Label();
            this.lPositionY = new System.Windows.Forms.Label();
            this.lbClavier = new System.Windows.Forms.ListBox();
            this.bRAZ = new System.Windows.Forms.Button();
            this.tbClicGauche = new System.Windows.Forms.TextBox();
            this.tbClicDroit = new System.Windows.Forms.TextBox();
            this.tbPositionY = new System.Windows.Forms.TextBox();
            this.tbPositionX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pSouris
            // 
            this.pSouris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSouris.Location = new System.Drawing.Point(286, 84);
            this.pSouris.Name = "pSouris";
            this.pSouris.Size = new System.Drawing.Size(468, 361);
            this.pSouris.TabIndex = 0;
            this.pSouris.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pSouris_MouseClick);
            this.pSouris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pSouris_MouseMove);
            // 
            // lClavier
            // 
            this.lClavier.AutoSize = true;
            this.lClavier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClavier.Location = new System.Drawing.Point(12, 20);
            this.lClavier.Name = "lClavier";
            this.lClavier.Size = new System.Drawing.Size(142, 20);
            this.lClavier.TabIndex = 0;
            this.lClavier.Text = "Interception clavier";
            this.lClavier.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lClicGauche
            // 
            this.lClicGauche.AutoSize = true;
            this.lClicGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClicGauche.Location = new System.Drawing.Point(282, 24);
            this.lClicGauche.Name = "lClicGauche";
            this.lClicGauche.Size = new System.Drawing.Size(91, 20);
            this.lClicGauche.TabIndex = 1;
            this.lClicGauche.Text = "Clic gauche";
            this.lClicGauche.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lClicDroit
            // 
            this.lClicDroit.AutoSize = true;
            this.lClicDroit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClicDroit.Location = new System.Drawing.Point(396, 24);
            this.lClicDroit.Name = "lClicDroit";
            this.lClicDroit.Size = new System.Drawing.Size(69, 20);
            this.lClicDroit.TabIndex = 2;
            this.lClicDroit.Text = "Clic droit";
            this.lClicDroit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lPositionX
            // 
            this.lPositionX.AutoSize = true;
            this.lPositionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPositionX.Location = new System.Drawing.Point(511, 24);
            this.lPositionX.Name = "lPositionX";
            this.lPositionX.Size = new System.Drawing.Size(80, 20);
            this.lPositionX.TabIndex = 3;
            this.lPositionX.Text = "Position X";
            this.lPositionX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lPositionY
            // 
            this.lPositionY.AutoSize = true;
            this.lPositionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPositionY.Location = new System.Drawing.Point(626, 24);
            this.lPositionY.Name = "lPositionY";
            this.lPositionY.Size = new System.Drawing.Size(80, 20);
            this.lPositionY.TabIndex = 4;
            this.lPositionY.Text = "Position Y";
            this.lPositionY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbClavier
            // 
            this.lbClavier.FormattingEnabled = true;
            this.lbClavier.Location = new System.Drawing.Point(16, 56);
            this.lbClavier.Name = "lbClavier";
            this.lbClavier.Size = new System.Drawing.Size(244, 355);
            this.lbClavier.TabIndex = 5;
            // 
            // bRAZ
            // 
            this.bRAZ.Location = new System.Drawing.Point(16, 417);
            this.bRAZ.Name = "bRAZ";
            this.bRAZ.Size = new System.Drawing.Size(244, 28);
            this.bRAZ.TabIndex = 6;
            this.bRAZ.Text = "Remise à zéro";
            this.bRAZ.UseVisualStyleBackColor = true;
            this.bRAZ.Click += new System.EventHandler(this.bRAZ_Click);
            // 
            // tbClicGauche
            // 
            this.tbClicGauche.Location = new System.Drawing.Point(286, 56);
            this.tbClicGauche.Name = "tbClicGauche";
            this.tbClicGauche.Size = new System.Drawing.Size(87, 20);
            this.tbClicGauche.TabIndex = 7;
            // 
            // tbClicDroit
            // 
            this.tbClicDroit.Location = new System.Drawing.Point(400, 56);
            this.tbClicDroit.Name = "tbClicDroit";
            this.tbClicDroit.Size = new System.Drawing.Size(87, 20);
            this.tbClicDroit.TabIndex = 8;
            // 
            // tbPositionY
            // 
            this.tbPositionY.Location = new System.Drawing.Point(630, 56);
            this.tbPositionY.Name = "tbPositionY";
            this.tbPositionY.Size = new System.Drawing.Size(87, 20);
            this.tbPositionY.TabIndex = 9;
            // 
            // tbPositionX
            // 
            this.tbPositionX.Location = new System.Drawing.Point(515, 56);
            this.tbPositionX.Name = "tbPositionX";
            this.tbPositionX.Size = new System.Drawing.Size(87, 20);
            this.tbPositionX.TabIndex = 10;
            // 
            // EcranClavierSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.tbPositionX);
            this.Controls.Add(this.tbPositionY);
            this.Controls.Add(this.tbClicDroit);
            this.Controls.Add(this.tbClicGauche);
            this.Controls.Add(this.bRAZ);
            this.Controls.Add(this.lbClavier);
            this.Controls.Add(this.lPositionY);
            this.Controls.Add(this.lPositionX);
            this.Controls.Add(this.lClicDroit);
            this.Controls.Add(this.lClicGauche);
            this.Controls.Add(this.lClavier);
            this.Controls.Add(this.pSouris);
            this.Name = "EcranClavierSouris";
            this.Text = "Ecran Clavier Souris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EcranClavierSouris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pSouris;
        private System.Windows.Forms.Label lClavier;
        private System.Windows.Forms.Label lClicGauche;
        private System.Windows.Forms.Label lClicDroit;
        private System.Windows.Forms.Label lPositionX;
        private System.Windows.Forms.Label lPositionY;
        private System.Windows.Forms.ListBox lbClavier;
        private System.Windows.Forms.Button bRAZ;
        private System.Windows.Forms.TextBox tbClicGauche;
        private System.Windows.Forms.TextBox tbClicDroit;
        private System.Windows.Forms.TextBox tbPositionY;
        private System.Windows.Forms.TextBox tbPositionX;
    }
}