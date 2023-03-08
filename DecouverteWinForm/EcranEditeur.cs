using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class EcranEditeur : Form
    {
        public EcranEditeur()
        {
            InitializeComponent();
        }
        public string sFichier = null;
        bool bModifier = false;

        public void FichierEnregistrer()
        {
            if (sFichier != null)
            {
                rtbTexte.SaveFile(sFichier, RichTextBoxStreamType.RichText);
                bModifier = false;
            }
            else // si c'est == null
            {
                sfdEnregistrer.Filter = "RTF Files|*.rtf";
                sFichier = sfdEnregistrer.FileName;
                if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
                {
                    rtbTexte.SaveFile(sfdEnregistrer.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        public void VerifierSauver()
        {

            if (bModifier == true)
            {
                var result = MessageBox.Show("Voulez vous enregistrer les modifications ?", "Sauvgarder...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FichierEnregistrer();
                    bModifier = false;
                }

            }
        }
        private void btn_picture_nouveau_fichier_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            if (bModifier == true)
            {
                rtbTexte.Clear();
                bModifier = false;
            }
        }
        private void enregistrer_fichier_menu_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }
        private void btn_picture_sauvgarder_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            bModifier = true;
        }

        private void btn_picture_sauvgarder_sous_Click(object sender, EventArgs e)
        {
            sfdEnregistrer.Filter = "RTF Files|*.rtf";
            sFichier = sfdEnregistrer.FileName;
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                rtbTexte.SaveFile(sfdEnregistrer.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void btn_picture_quitter_Click(object sender, EventArgs e)
        {
            VerifierSauver();
        }

        private void ouvrir_fichier_menu_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            rtbTexte.Clear();
            bModifier = false;

            ofdOuvrir.DefaultExt = "*.rtf";
            ofdOuvrir.Filter = "RTF Files|*.rtf";

            if (ofdOuvrir.ShowDialog() == DialogResult.OK && ofdOuvrir.FileName.Length >0)
            {
                rtbTexte.LoadFile(ofdOuvrir.FileName);
            }

        }

        private void gauche_justifier_formater_menu_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centre_justifier_formater_menu_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void droite_justifier_formater_menu_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void gras_caractère_formater_menu_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionFont = new Font(this.rtbTexte.Font, FontStyle.Bold);
        }

        private void italique_caractère_formater_menu_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionFont = new Font(this.rtbTexte.Font, FontStyle.Italic);
        }

        private void souligné_caractère_formater_menu_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionFont = new Font(this.rtbTexte.Font, FontStyle.Underline);
        }

        private void barré_caractère_formater_menu_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionFont = new Font(this.rtbTexte.Font, FontStyle.Strikeout);
        }
    }
}
