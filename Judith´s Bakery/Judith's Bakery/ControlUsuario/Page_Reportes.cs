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
    public partial class Page_Reportes : UserControl
    {
        public Page_Reportes()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }

        private void Page_Reportes_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ReportesEmpleado re = new ReportesEmpleado();
            re.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.ClienteReport cli = new Judith_s_Bakery.Report.ClienteReport();
            cli.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.InventarioReport ir = new Judith_s_Bakery.Report.InventarioReport();
            ir.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.InventarioMateriaPrimaReport mp = new Judith_s_Bakery.Report.InventarioMateriaPrimaReport();
            mp.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            ReportesVentas re = new ReportesVentas();
            re.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.ProveedoresReport cli = new Judith_s_Bakery.Report.ProveedoresReport();
            cli.Show();
        }


        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            ReporteCompra rc = new ReporteCompra();
            rc.Show();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.PedidosReport pedidos = new Judith_s_Bakery.Report.PedidosReport();
            pedidos.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.VentasMensualesReport ventas = new Judith_s_Bakery.Report.VentasMensualesReport();
            ventas.Show();
        }
    }
}
