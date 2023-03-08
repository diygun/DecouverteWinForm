using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class EcranListe : Form
    {
        public EcranListe()
        {
            InitializeComponent();
            activerGrBox(false);
        }
        public string NomFichier;

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int smLire = 0x0199;
        private const int smEcrire = 0x019A;



        public void activerGrBox(bool etat)
        {
            textBoxNom.Text = "";
            listePersonnes.SelectedIndex = -1;
            grBoxDetailPersonne.Enabled = etat;
        }
        private void btnConfirmerDetPersonne_Click(object sender, EventArgs e)
        {
            string genrePersonne = comboBoxQualite.Text;
            string nomPersonne = textBoxNom.Text;
            int endpos = listePersonnes.Items.Add(genrePersonne + " " + nomPersonne);
            activerGrBox(false);

            SendMessage(listePersonnes.Handle, (int)smEcrire ,endpos , listePersonnes.Items.Count);
        }

        private void btnAnnulerDetPersonne_Click(object sender, EventArgs e)
        {
            activerGrBox(false);
        }
        private void btnAjouterDetPersonne_Click(object sender, EventArgs e)
        {
            activerGrBox(true);
        }
        private void btnSupprimerPersonne_Click(object sender, EventArgs e)
        {
            if (listePersonnes.SelectedItem != null)
            {
                MessageBox.Show("Selection : " + listePersonnes.SelectedIndex);
                listePersonnes.Items.Remove(listePersonnes.SelectedItem);

                int premier = SendMessage(listePersonnes.Handle, smLire, listePersonnes.SelectedIndex, 0);
                for (int i = 0; i < listePersonnes.Items.Count; i++)
                {
                    int dernier = SendMessage(listePersonnes.Handle, smLire, i, 0);
                    if (premier<dernier)
                    {
                        SendMessage(listePersonnes.Handle, smEcrire, i, dernier - 1);
                    }
                }
            }

        }
        private void btnOuvrirDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ouvrir = new OpenFileDialog();
            ouvrir.Filter = "Fichier texte (*.txt)|*.*";
            //ouvrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //ouvrir.RestoreDirectory = true;
            if (ouvrir.ShowDialog() == DialogResult.OK)
            {
                NomFichier = ouvrir.FileName;
                string[] lines = File.ReadAllLines(NomFichier/*repertoire*/);

                listePersonnes.Items.Clear();
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] exp = lines[i].Split('#');
                    listePersonnes.Items.Add(exp[0]);
                    SendMessage(listePersonnes.Handle, smEcrire, i, int.Parse(exp[1]));
                }
            }
        }
        private void btnEnregistrerPErsonne_Click(object sender, EventArgs e)
        {
            SaveFileDialog enregistrer = new SaveFileDialog();
            enregistrer.Filter = "Fichier texte (*.txt)|*.*";
            enregistrer.FilterIndex = 1;
            //enregistrer.RestoreDirectory = true;

            if (enregistrer.ShowDialog() == DialogResult.OK)
            {
                NomFichier = enregistrer.FileName;
                using (StreamWriter writer = new StreamWriter(NomFichier/*enregistrer.FileName*/))
                {
                    for (int i = 0; i < listePersonnes.Items.Count; i++)
                    {
                        writer.WriteLine(listePersonnes.Items[i].ToString() + " " + "#" +  SendMessage(listePersonnes.Handle, smLire, i, 0));
                    }
                }
            }
        }

        private void listePersonnes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listePersonnes.SelectedItem != null)
            {
                string nomSelectedItem = listePersonnes.SelectedItem.ToString();
                int index = listePersonnes.SelectedIndex;

                MessageBox.Show(
                    "Index virtuelle : " + SendMessage(listePersonnes.Handle, smLire, listePersonnes.SelectedIndex, 0) + "\n" +
                    "Nom : " + nomSelectedItem + "\n" +
                    "Index : " + index.ToString(),
                    "Listes",
                    MessageBoxButtons.OK
                    );

            }
        }
    }
}
