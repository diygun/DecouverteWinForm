using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class EcranSpirographe : Form
    {
        public EcranSpirographe()
        {
            InitializeComponent();
        }


        Color cTrait = Color.Blue;
        Color cFond = Color.Green;

        public GraphicsPath gpSauvegarde = null;



        private void btnFond_Click(object sender, EventArgs e)
        {
            cdCouleur.Color = cFond;
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                cFond = cdCouleur.Color;
                Invalidate();
            }
        }

        private void EcranSpirographe_Paint(object sender, PaintEventArgs e)
        {
            /*
            Pen pen = new Pen(cTrait, 3);
            Brush brush = new SolidBrush(cFond);

            Graphics g = this.CreateGraphics();
            g.FillRectangle(brush, 24 + gbParametrage.Width, 0, this.Width - gbParametrage.Width, this.Height);
            */
            if (gpSauvegarde != null)

            {

                e.Graphics.FillRectangle(

                 new SolidBrush(cFond),

                 new Rectangle(new Point(248, 0), ClientSize));

                e.Graphics.DrawPath(new Pen(cTrait), gpSauvegarde);

            }
        }

        /*
        Pen pen = new Pen(cTrait, 3);
        Brush brush = new SolidBrush(cTrait);

        Graphics g = this.CreateGraphics();
        g.DrawLine(pen, 10, 10 );
        */



        private void btnGo_Click(object sender, EventArgs e)
        {
            int i;
            int nS = tbSommet.Value;
            int nD = tbDensite.Value;
            int nP = 100 - tbProfondeur.Value;
            gpSauvegarde = new GraphicsPath();
            Graphics gr = CreateGraphics();

            gr.FillRectangle(
                new SolidBrush(cFond),
                new Rectangle(24 + gbParametrage.Width, 0, ClientSize.Width, ClientSize.Height)
                );
            int xCentre = 24 + gbParametrage.Width + (ClientSize.Width - 24 - gbParametrage.Width) / 2;
            int yCentre = ClientSize.Height / 2;
            int rayon = Math.Min((ClientSize.Width - 24 - gbParametrage.Width), ClientSize.Height / 2);
            rayon = 9 * rayon / 10; // pour ne pas aller sur les bord on laisse un padding de 10%(soit on prend 90%)
            int[] sX = new int[1 + nS];
            int[] sY = new int[1 + nS];
            for (i = 0; i < nS; i++)
            {
                sX[i] = (int)(xCentre + rayon * Math.Cos(i * 2 * Math.PI / nS));
                sY[i] = (int)(yCentre + rayon * Math.Sin(i * 2 * Math.PI / nS));
            }
            sX[nS] = sX[0]; // je boucle l boucle et je revient au point de depart du cercle trig.
            sY[nS] = sY[0];

            //int x1, y2, x3, y4;
            while (d(sX[0], sY[0], xCentre, yCentre) > rayon * nP / 100) // nP ou nD ??
            {
                for (i = 1; i <= nS; i++)
                {
                    gr.DrawLine(new Pen(cTrait), sX[i - 1], sY[i - 1], sX[i], sY[i]);
                    gpSauvegarde.AddLine(sX[i - 1], sY[i - 1], sX[i], sY[i]);
                    Application.DoEvents();
                    Thread.Sleep(15);
                }

                for (i = 0; i < nS; i++)
                {
                    sX[i] = sX[i] + (sX[i + 1] - sX[i]) / nD;
                    sY[i] = sY[i] + (sY[i + 1] - sY[i]) / nD;


                }
                sX[nS] = sX[0]; // je boucle l boucle et je revient au point de depart du cercle trig.
                sY[nS] = sY[0];
            }

        }



        private double d(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        private void btnTrait_Click(object sender, EventArgs e)
        {

        }
    }
}

