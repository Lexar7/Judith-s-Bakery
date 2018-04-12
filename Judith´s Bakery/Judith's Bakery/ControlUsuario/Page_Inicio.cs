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
    public partial class Page_Inicio : UserControl
    {
        public Page_Inicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }

        private void bunifuImageButton2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_MouseEnter(object sender, EventArgs e)
        {
            lbUsuarios.ForeColor = Color.Orange;
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            lbUsuarios.ForeColor = Color.Black;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Empleados user = new Empleados();
            user.Show();
        }
    }
}
