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
    public partial class Page_Invetario : UserControl
    {
        public Page_Invetario()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }

        private void bt_usuarios_MouseEnter(object sender, EventArgs e)
        {
            lbProducto.ForeColor = Color.Orange;
        }

        private void bt_usuarios_MouseLeave(object sender, EventArgs e)
        {
            lbProducto.ForeColor = Color.Black;
        }

        private void bunifuImageButton1_MouseEnter(object sender, EventArgs e)
        {
            lbMateria.ForeColor = Color.Orange;
        }

        private void btMateria_MouseLeave(object sender, EventArgs e)
        {
            lbMateria.ForeColor = Color.Black;
        }
        private void btMateria_Click(object sender, EventArgs e)
        {
            MateriaPrima mp = new MateriaPrima();
            mp.Show();
        }

        private void btnCompra_MouseEnter(object sender, EventArgs e)
        {
            lbCompra.ForeColor = Color.Orange;
        }
        private void btnCompra_MouseLeave(object sender, EventArgs e)
        {
            lbCompra.ForeColor = Color.Black;
        }

        private void btnVenta_MouseEnter(object sender, EventArgs e)
        {
            lbVenta.ForeColor = Color.Orange;
        }

        private void btnVenta_MouseLeave(object sender, EventArgs e)
        {
            lbVenta.ForeColor = Color.Black;
        }

        private void btnPedidos_MouseEnter(object sender, EventArgs e)
        {
            lbPedidos.ForeColor = Color.Orange;
        }

        private void btnPedidos_MouseLeave(object sender, EventArgs e)
        {
            lbPedidos.ForeColor = Color.Black;
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Venta vt = new Venta();
            vt.Show();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            Compra cp = new Compra();
            cp.Show();
        }

        private void btProducto_Click(object sender, EventArgs e)
        {
            ProductoFinal pf = new ProductoFinal();
            pf.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos p = new Pedidos();
            p.Show();
        }
    }
}
