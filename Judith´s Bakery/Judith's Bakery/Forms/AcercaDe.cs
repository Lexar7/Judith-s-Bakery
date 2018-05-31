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
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {
            
            tablaInformacion.Rows.Add("Módulo Empleados", "1.0.0");
            tablaInformacion.Rows.Add("Módulo Proveedores", "1.0.0");
            tablaInformacion.Rows.Add("Módulo Clientes", "1.0.0");
            tablaInformacion.Rows.Add("Módulo Inventario", "1.0.0");
            tablaInformacion.Rows.Add("Módulo Compra", "1.0.0");
            tablaInformacion.Rows.Add("Módulo Venta", "1.0.0");
            tablaInformacion.Rows.Add("Módulo Pedidos", "1.0.0");
            tablaInformacion.Rows.Add("Módulo Reportes", "1.0.0");

        }

        private void Cerrar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            button2.BackColor = Color.Firebrick;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.White;
        }

        private void AcercaDe_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
