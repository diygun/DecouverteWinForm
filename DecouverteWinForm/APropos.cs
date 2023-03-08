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
    public partial class APropos : Form
    {
        public APropos()
        {
            InitializeComponent();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Cursor = new Cursor("C:\\Users\\diyar\\Pictures\\curseurPerso.cur");
        }
    }
}
