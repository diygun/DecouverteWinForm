using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class EcranClavierSouris : Form
    {
        public EcranClavierSouris()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public int nbGauche = 0;
        public int nbDroit = 0;
        private void AfficherClic()
        {
            tbClicDroit.Text = nbDroit.ToString();
            tbClicGauche.Text = nbGauche.ToString();
        }
        private void pSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbPositionX.Text = e.Location.X.ToString();
            tbPositionY.Text = e.Location.Y.ToString();
        }
        private void pSouris_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                nbGauche += 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                nbDroit += 1;
            }
            AfficherClic();
        }
        private void bRAZ_Click(object sender, EventArgs e)
        {
            nbGauche = 0;
            nbDroit = 0;
            AfficherClic();
            lbClavier.Items.Clear();
        }

        private void EcranClavierSouris_KeyDown(object sender, KeyEventArgs e)
        {
            lbClavier.Items.Add(e.KeyCode);
        }

        private void EcranClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbClavier.Items.Add(e.KeyChar);
        }

        private void EcranClavierSouris_KeyUp(object sender, KeyEventArgs e)
        {
            lbClavier.Items.Add(e.KeyCode);

        }
    }
}
