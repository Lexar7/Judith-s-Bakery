using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judith_s_Bakery.Forms
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int contador;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador >= 300)
            {
                timer1.Enabled = false;
                this.Hide();
                InicioSesion login = new InicioSesion();
                login.Show();
            }
        }
    }
}
