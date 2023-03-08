
namespace DecouverteWinForm
{
    partial class APropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APropos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AppSpeech = new System.Windows.Forms.Label();
            this.VersionInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PremiereMAnipulation = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AppSpeech);
            this.panel1.Controls.Add(this.VersionInfo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.PremiereMAnipulation);
            this.panel1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 262);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 22F);
            this.label2.Location = new System.Drawing.Point(100, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Première Manipulations";
            // 
            // AppSpeech
            // 
            this.AppSpeech.AutoSize = true;
            this.AppSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AppSpeech.Location = new System.Drawing.Point(102, 184);
            this.AppSpeech.Name = "AppSpeech";
            this.AppSpeech.Size = new System.Drawing.Size(335, 40);
            this.AppSpeech.TabIndex = 6;
            this.AppSpeech.Text = "Et l\'appliaction se dit qu\'un jour, elle deviendra \n aussi grande que .NET";
            this.AppSpeech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VersionInfo
            // 
            this.VersionInfo.AutoSize = true;
            this.VersionInfo.Font = new System.Drawing.Font("Arial Narrow", 22F);
            this.VersionInfo.Location = new System.Drawing.Point(178, 73);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.Size = new System.Drawing.Size(288, 35);
            this.VersionInfo.TabIndex = 5;
            this.VersionInfo.Text = "Version sous alpha 1.0.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PremiereMAnipulation
            // 
            this.PremiereMAnipulation.AutoSize = true;
            this.PremiereMAnipulation.Font = new System.Drawing.Font("Arial Narrow", 22F);
            this.PremiereMAnipulation.Location = new System.Drawing.Point(178, 17);
            this.PremiereMAnipulation.Name = "PremiereMAnipulation";
            this.PremiereMAnipulation.Size = new System.Drawing.Size(273, 35);
            this.PremiereMAnipulation.TabIndex = 2;
            this.PremiereMAnipulation.Text = "Première Manipulations";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmer.Location = new System.Drawing.Point(150, 280);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(207, 34);
            this.btnConfirmer.TabIndex = 1;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // APropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 326);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "APropos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "A Propos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PremiereMAnipulation;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label VersionInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AppSpeech;
    }
}