using System;
using System.Drawing;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class EcranPrincipale : Form
    {
        public EcranPrincipale()
        {
            InitializeComponent();
        }

        public void AfficheMessageNonImpl()
        {
            MessageBox.Show("Methode non-implemente !", "Fonctionnalité à venir", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnAfficherFenaitre_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Splache();
            form2.Closed += (s, args) => this.Close(); // permet de Close le form1 quand le form2 est fermée
            form2.Show();
        }
        public bool compteurImage = false;

        private void btnNomCustom_Click(object sender, EventArgs e)
        {
            //pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            if (this.compteurImage == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\diyar\Pictures\IMAGE2.png");/// Capture d’écran 2021-11-01 191958.png
                this.compteurImage = false;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\diyar\Pictures\20210820_194702.jpg");
                this.compteurImage = true;
            }

        }

        private void Controles_Quitter_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Controles_Liste_Menu_Click(object sender, EventArgs e)
        {
            var menuListe = new EcranListe();
            menuListe.Show();
        }

        private void Controles_BarreDeProgra_MEnu_Click(object sender, EventArgs e)
        {
            var progressBar = new ProgressBar();
            progressBar.Show();
        }

        private void Application_Editeur_Menu_Click(object sender, EventArgs e)
        {
            var editeur = new EcranEditeur();
            editeur.Show();
        }

        private void Aide_APropos_Menu_Click(object sender, EventArgs e)
        {
            var apropos = new APropos();
            apropos.Show();
        }

        private void Controles_Editeur_Menu_Click(object sender, EventArgs e)
        {
            var editeur = new EcranEditeur();
            editeur.Show();
        }

        private void spirographeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var spirographe = new EcranSpirographe();
            spirographe.Show();
        }

        private void horlogeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var horloge = new EcranHorloge();
            horloge.Show();
        }

        private void Application_Monitoring_Menu_Click(object sender, EventArgs e)
        {
            var ecranSourisClavier = new EcranClavierSouris();
            ecranSourisClavier.Show();
        }


        private void Application_ExplorateurDeFichier_Menu_Click(object sender, EventArgs e)
        {
            var ecranExplorateurDeFichier = new ExplorateurDeFichier();
            ecranExplorateurDeFichier.Show();
        }







        /*

        Object sender c'est un parametre qui contient la references de l'objet qui appel l'evenement.
        Un bouton appel 
        
        EventsArgs e c'est un parametre qui contient les données de l'evenement.

         */
    }
}
