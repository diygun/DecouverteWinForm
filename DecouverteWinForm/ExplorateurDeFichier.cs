using System;
using System.IO;
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
    public partial class ExplorateurDeFichier : Form
    {
        public ExplorateurDeFichier()
        {
            InitializeComponent();
            LireDisques();
        }

        #region methodes
        public void LireDisques()
        {
            tvRepertoire.BeginUpdate();
            String[] drives = Environment.GetLogicalDrives();
            //string drive;
            foreach (string drive in drives)
            {
                TreeNode parentNode = tvRepertoire.Nodes.Add(drive);
                try
                {
                    LireRepertoires(drive, parentNode);

                }
                catch (Exception)
                {
                }
                finally
                {
                }
            }

            tvRepertoire.EndUpdate();
        }

        public void LireRepertoires(string drive, TreeNode parentNode)
        {
            //string[] dirs = Directory.GetDirectories(drive);
            DirectoryInfo[] dirs = new DirectoryInfo(drive).GetDirectories();

            foreach (DirectoryInfo dir in dirs)
            {
                TreeNode childNode = parentNode.Nodes.Add(dir.Name);
                LireRepertoires(dir.FullName, childNode);
            }
        }


        #endregion
        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lvFichiers.Items.Clear();
            LireFichier(e.Node.FullPath);
        }
        public void LireFichier(string path)
        {
            try
            {
                DirectoryInfo repertoir = new DirectoryInfo(path);
                FileInfo[] fichiers = repertoir.GetFiles();
                foreach (FileInfo fichier in fichiers)
                {
                    //string fle = Path.GetDirectoryName(fichier.FullName);
                    ListViewItem item = new ListViewItem(Path.GetFileName(fichier.FullName));
                    item.SubItems.Add(fichier.Length.ToString());
                    item.SubItems.Add(fichier.CreationTime.ToString());
                    item.SubItems.Add(fichier.LastWriteTime.ToString());
                    lvFichiers.Items.Add(item);
                }
            }
            catch (Exception)
            {
            }
            finally
            {

            }

        }

    }
}
