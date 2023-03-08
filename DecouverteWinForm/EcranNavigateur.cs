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
    public partial class EcranNavigateur : Form
    {
        public EcranNavigateur()
        {
            InitializeComponent();
            chromiumWebBrowser.Load("https://www.google.com/maps/place/Rue+Sohet,+4000+Li%C3%A8ge/");
        }
    }
}
