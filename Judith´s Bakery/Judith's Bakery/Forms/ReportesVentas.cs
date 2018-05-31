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
    public partial class ReportesVentas : Form
    {
        public ReportesVentas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.VentasFechaReport mp = new Judith_s_Bakery.Report.VentasFechaReport();
            mp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.VentasReporte ventas = new Judith_s_Bakery.Report.VentasReporte();
            ventas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.VentasMensualesReport ventas = new Judith_s_Bakery.Report.VentasMensualesReport();
            ventas.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
