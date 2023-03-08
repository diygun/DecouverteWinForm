
namespace DecouverteWinForm
{
    partial class ProgressBar
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
            this.progressBarIndex = new System.Windows.Forms.ProgressBar();
            this.btnExecuter = new System.Windows.Forms.Button();
            this.ProgressBarIndexPrincipale = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.ProgressBarIndexSecondaire = new System.Windows.Forms.Label();
            this.progressBarSecondaire = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBarIndex
            // 
            this.progressBarIndex.ForeColor = System.Drawing.Color.Lime;
            this.progressBarIndex.Location = new System.Drawing.Point(12, 53);
            this.progressBarIndex.Name = "progressBarIndex";
            this.progressBarIndex.Size = new System.Drawing.Size(310, 43);
            this.progressBarIndex.Step = 1;
            this.progressBarIndex.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarIndex.TabIndex = 0;
            // 
            // btnExecuter
            // 
            this.btnExecuter.Location = new System.Drawing.Point(12, 225);
            this.btnExecuter.Name = "btnExecuter";
            this.btnExecuter.Size = new System.Drawing.Size(143, 52);
            this.btnExecuter.TabIndex = 1;
            this.btnExecuter.Text = "Executer";
            this.btnExecuter.UseVisualStyleBackColor = true;
            this.btnExecuter.Click += new System.EventHandler(this.btnExecuter_Click);
            // 
            // ProgressBarIndexPrincipale
            // 
            this.ProgressBarIndexPrincipale.AutoSize = true;
            this.ProgressBarIndexPrincipale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBarIndexPrincipale.ForeColor = System.Drawing.Color.Lime;
            this.ProgressBarIndexPrincipale.Location = new System.Drawing.Point(8, 30);
            this.ProgressBarIndexPrincipale.Name = "ProgressBarIndexPrincipale";
            this.ProgressBarIndexPrincipale.Size = new System.Drawing.Size(105, 20);
            this.ProgressBarIndexPrincipale.TabIndex = 2;
            this.ProgressBarIndexPrincipale.Text = "Index Principale";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(179, 225);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(143, 52);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // ProgressBarIndexSecondaire
            // 
            this.ProgressBarIndexSecondaire.AutoSize = true;
            this.ProgressBarIndexSecondaire.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBarIndexSecondaire.ForeColor = System.Drawing.Color.Lime;
            this.ProgressBarIndexSecondaire.Location = new System.Drawing.Point(8, 128);
            this.ProgressBarIndexSecondaire.Name = "ProgressBarIndexSecondaire";
            this.ProgressBarIndexSecondaire.Size = new System.Drawing.Size(115, 20);
            this.ProgressBarIndexSecondaire.TabIndex = 5;
            this.ProgressBarIndexSecondaire.Text = "Index Secondaire";
            // 
            // progressBarSecondaire
            // 
            this.progressBarSecondaire.ForeColor = System.Drawing.Color.Lime;
            this.progressBarSecondaire.Location = new System.Drawing.Point(12, 151);
            this.progressBarSecondaire.Name = "progressBarSecondaire";
            this.progressBarSecondaire.Size = new System.Drawing.Size(310, 43);
            this.progressBarSecondaire.Step = 1;
            this.progressBarSecondaire.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSecondaire.TabIndex = 7;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 296);
            this.Controls.Add(this.progressBarSecondaire);
            this.Controls.Add(this.ProgressBarIndexSecondaire);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.ProgressBarIndexPrincipale);
            this.Controls.Add(this.btnExecuter);
            this.Controls.Add(this.progressBarIndex);
            this.Name = "ProgressBar";
            this.Text = "ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarIndex;
        private System.Windows.Forms.Button btnExecuter;
        private System.Windows.Forms.Label ProgressBarIndexPrincipale;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label ProgressBarIndexSecondaire;
        private System.Windows.Forms.ProgressBar progressBarSecondaire;
    }
}