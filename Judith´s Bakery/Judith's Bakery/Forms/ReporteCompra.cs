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
    public partial class ReporteCompra : Form
    {
        public ReporteCompra()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.ComprasDiariasReport ae = new Judith_s_Bakery.Report.ComprasDiariasReport();
            ae.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.ComprasMensualesReport ae = new Judith_s_Bakery.Report.ComprasMensualesReport();
            ae.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.CompraReport ae = new Judith_s_Bakery.Report.CompraReport();
            ae.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
