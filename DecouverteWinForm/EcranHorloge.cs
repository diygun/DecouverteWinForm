using System;
using System.Drawing;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class EcranHorloge : Form
    {
        public EcranHorloge()
        {
            InitializeComponent();

        }
        public string tmps = DateTime.Now.ToString("HH:mm:ss");


        public int heure;
        public int minutes;
        public int secondes;

        public Pen pen = new Pen(Color.Blue, 2);

        Color cHeure = Color.Red;
        Color cMinutes = Color.Green;
        Color cSecondes = Color.Yellow;

        private void chrono_Tick(object sender, EventArgs e)
        {
            heure = int.Parse(DateTime.Now.ToString("HH"));
            minutes = int.Parse(DateTime.Now.ToString("mm"));
            secondes = int.Parse(DateTime.Now.ToString("ss"));
            this.Text = DateTime.Now.ToString("HH:mm:ss");

            Graphics g = this.CreateGraphics();
            g.Clear(BackColor);

            int xCentre = ClientSize.Width / 2;
            int yCentre = ClientSize.Height / 2;
            int rayon = Math.Min(ClientSize.Width, ClientSize.Height / 2);
            rayon = 9 * rayon / 10;
            //g.DrawEllipse(pen, 2);

            int[] sX = new int[21];
            int[] sY = new int[21];
            int i;
            for (i = 9; i < 21; i++) // if i = 9 -> MIDI 
            {
                sX[i] = (int)(xCentre + rayon * Math.Cos(i * 2 * Math.PI / 12));
                sY[i] = (int)(yCentre + rayon * Math.Sin(i * 2 * Math.PI / 12));
                g.DrawEllipse(pen, sX[i], sY[i], 10, 10);
                if (i % 3 == 0)
                {
                    g.DrawEllipse(new Pen(Color.Black, 2), sX[i], sY[i], 10, 10);
                }
                if (i == (heure % 12) + 9)
                {
                    g.DrawLine(
                        new Pen(cHeure),
                        xCentre, yCentre,
                        (int)(xCentre + rayon * Math.Cos(i * (Math.PI / 6) + (Math.PI / 6) * (Math.PI / (double)minutes / 60))),
                        (int)(yCentre + rayon * Math.Sin(i * (Math.PI / 6) + (Math.PI / 6) * (Math.PI / (double)minutes / 60)))
                        );
                }
            }


            //g.DrawLine(
            //    new Pen(cHeure),
            //    xCentre, yCentre,
            //    (int)(xCentre + rayon * Math.Cos((heure - 3) * (Math.PI / 6) + (Math.PI / 6) * (Math.PI / (double)minutes / 60))),
            //    (int)(yCentre + rayon * Math.Sin((heure - 3) * (Math.PI / 6) + (Math.PI / 6) * (Math.PI / (double)minutes / 60)))
            //    );


            g.DrawLine(
                new Pen(Color.Black),
                xCentre, yCentre,
                (int)(xCentre + rayon * Math.Cos((minutes - 15) * 2 * Math.PI / 60)),
                (int)(yCentre + rayon * Math.Sin((minutes - 15) * 2 * Math.PI / 60))
                );

            g.DrawLine(
                new Pen(Color.Black),
                xCentre, yCentre,
                (int)(xCentre + rayon * Math.Cos((secondes - 15) * 2 * Math.PI / 60)),
                (int)(yCentre + rayon * Math.Sin((secondes - 15) * 2 * Math.PI / 60))
                );


            //for (i = 9; i < 729; i++)
            //{
            //    scX = (int)(xCentre + rayon * Math.Cos(i * 2 * Math.PI / 720));
            //    scY = (int)(yCentre + rayon * Math.Sin(i * 2 * Math.PI / 720));
            //    if (i == (heure % 720 + 69 ))
            //    {
            //        g.DrawLine(new Pen(cMinutes), scX, scY, xCentre, yCentre);
            //    }
            //}
            //for (i = 9; i < 729; i++)
            //{
            //    scX = (int)(xCentre + rayon * Math.Cos(i * 2 * Math.PI / 720));
            //    scY = (int)(yCentre + rayon * Math.Sin(i * 2 * Math.PI / 720));
            //    if (i == (heure % 720 + 69))
            //    {
            //        g.DrawLine(new Pen(cMinutes), scX, scY, xCentre, yCentre);
            //    }
            //}

        }

        private void EcranHorloge_Load(object sender, EventArgs e)
        {
            chrono.Start();

        }
    }
}
