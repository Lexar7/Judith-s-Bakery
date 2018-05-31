using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Judith_s_Bakery.Forms;

namespace Judith_s_Bakery
{
    public partial class Page_Ayuda : UserControl
    {
        public Page_Ayuda()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcercaDe ad = new AcercaDe();
            ad.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SoporteTecnico st = new SoporteTecnico();
            st.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            BackUp bu = new BackUp();
            bu.Show();
        }
    }
}
