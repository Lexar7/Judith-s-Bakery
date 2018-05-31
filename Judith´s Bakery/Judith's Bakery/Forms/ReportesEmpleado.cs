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
    public partial class ReportesEmpleado : Form
    {
        public ReportesEmpleado()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.AsistenciaReport ae = new Judith_s_Bakery.Report.AsistenciaReport();
            ae.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.AsistenciaTotalReport tr = new Judith_s_Bakery.Report.AsistenciaTotalReport();
            tr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Judith_s_Bakery.Report.EmpleadoReport emp = new Judith_s_Bakery.Report.EmpleadoReport();
            emp.Show();
        }
    }
}
