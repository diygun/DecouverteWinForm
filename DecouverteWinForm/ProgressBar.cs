using System;
using System.Threading;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void btnExecuter_Click(object sender, EventArgs e)
        {

            Random nbrHasard = new Random();
            int nbrFichier = nbrHasard.Next(5, 10);
            progressBarIndex.Maximum = nbrFichier;
            //progressBarIndex.Minimum = 0;
            //progressBarIndex.Step = 1;

            //progressBarSecondaire.Step = 1;

            for (int i = 0; i < nbrFichier; i++)
            {
                int tailleFichier = nbrHasard.Next(5, 10);
                int tsleep = nbrHasard.Next(5, 10);

                progressBarSecondaire.Maximum = tailleFichier;
                //progressBarSecondaire.Minimum = 0;
                progressBarSecondaire.Value = 0;
                for (int j = 0; j < tailleFichier; j++)
                {

                    Thread.Sleep(200);
                    if (j == tailleFichier - 1)
                    {
                        progressBarSecondaire.Value = progressBarSecondaire.Maximum;
                    }
                    else
                    {
                        progressBarSecondaire.Value = j + 2;
                        progressBarSecondaire.Value = j + 1;

                    }
                }
                progressBarIndex.Value = i + 1;
                //progressBarSecondaire.Value++ ;
                //Thread.Sleep(500);
            }

            //progressBarIndex.Value = nbrFichier;
            //progressBarSecondaire.Value = tailleFichier;


            /*
            Random nbrHasard = new Random();
            int nbrFichier = nbrHasard.Next(5, 10);
            progressBarIndex.Maximum = nbrFichier;
            progressBarIndex.Minimum = 0;

            int tailleFichier = nbrHasard.Next(5, 10);
            progressBarSecondaire.Maximum = tailleFichier;
            progressBarSecondaire.Minimum = 0;

            for (int i = 0; i <= nbrFichier; i++)
            {
                progressBarIndex.Value = i;

                for (int j = 0; j <= tailleFichier; j++)
                {
                    progressBarSecondaire.PerformStep();
                    Thread.Sleep(200);
                }
                progressBarSecondaire.Value = 0;


                if (i == nbrFichier)
                {
                    progressBarSecondaire.Value = tailleFichier;
                }
                Thread.Sleep(400);

            }
*/
        }
    }
}
