using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judith_s_Bakery.Forms
{
    public partial class HistorialPedidos : Form
    {
        DataBase db = new DataBase();
        Pedidos p = new Pedidos();
        string dgv_id;
        public HistorialPedidos()
        {
            InitializeComponent();
        }

        private void HistorialPedidos_Load(object sender, EventArgs e)
        {
            db.cargarDatos("select Pedidos.IdPedido, InventarioProducto.Nom_Producto as 'Producto', DetallePedido.Cantidad, DetallePedido.Precio_Uni as 'Precio', DetallePedido.Descuento, CONVERT(decimal(18,2),(DetallePedido.Cantidad * DetallePedido.Precio_Uni) - (((DetallePedido.Cantidad * DetallePedido.Precio_Uni)* DetallePedido.Descuento) / 100)) as 'Total Pagado', Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.Entregado, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetallePedido on InventarioProducto.IdProducto = DetallePedido.IdProducto inner join Pedidos on Pedidos.IdPedido = DetallePedido.IdPedido inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente inner join Empleado on Empleado.IdEmpleado = Pedidos.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Pedidos.IdTipoPago ORDER BY Pedidos.FechaPedido desc", tablaHistorial);
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            p.Show();
        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            p.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            db.cargarDatos("select Pedidos.IdPedido, InventarioProducto.Nom_Producto as 'Producto', DetallePedido.Cantidad, DetallePedido.Precio_Uni as 'Precio', DetallePedido.Descuento, CONVERT(decimal(18,2),(DetallePedido.Cantidad * DetallePedido.Precio_Uni) - (((DetallePedido.Cantidad * DetallePedido.Precio_Uni)* DetallePedido.Descuento) / 100)) as 'Total Pagado', Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.Entregado, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetallePedido on InventarioProducto.IdProducto = DetallePedido.IdProducto inner join Pedidos on Pedidos.IdPedido = DetallePedido.IdPedido inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente inner join Empleado on Empleado.IdEmpleado = Pedidos.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Pedidos.IdTipoPago ORDER BY Pedidos.FechaPedido desc", tablaHistorial);

            txtProducto.Text = "Buscar Producto";
            txtCliente.Text = "Buscar Cliente";
            txtFecha.Text = "dd/mm/aaaa";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbProducto.Checked == false && rbEntregados.Checked == false && rbNoEntregados.Checked == false && rbCliente.Checked == false && rbFecha.Checked == false)
            {
                MessageBox.Show("Seleccione primero lo que desea buscar, nombre, cliente, entregados, no entregados o fecha", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rbProducto.Checked == true)
                {
                    BuscarProducto(txtProducto.Text.ToString()); //Llamar al metodo y pasarle el parametro
                }
                else if (rbCliente.Checked == true)
                {
                    BuscarCliente(txtCliente.Text.ToString());
                }
                else if (rbFecha.Checked == true)
                {
                    BuscarXFecha(txtFecha.Text.ToString());
                }
            }
        }

        public void BuscarProducto(string nombre)
        {
            SqlCommand cmd = new SqlCommand("select InventarioProducto.Nom_Producto as 'Producto', DetallePedido.Cantidad, DetallePedido.Precio_Uni as 'Precio', DetallePedido.Descuento, Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.Entregado, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetallePedido on InventarioProducto.IdProducto = DetallePedido.IdProducto inner join Pedidos on Pedidos.IdPedido = DetallePedido.IdPedido inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente inner join Empleado on Empleado.IdEmpleado = Pedidos.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Pedidos.IdTipoPago where InventarioProducto.Nom_Producto like '%" + nombre + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }
        public void BuscarEntregado()
        {
            SqlCommand cmd = new SqlCommand("select InventarioProducto.Nom_Producto as 'Producto', DetallePedido.Cantidad, DetallePedido.Precio_Uni as 'Precio', DetallePedido.Descuento, Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.Entregado, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetallePedido on InventarioProducto.IdProducto = DetallePedido.IdProducto inner join Pedidos on Pedidos.IdPedido = DetallePedido.IdPedido inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente inner join Empleado on Empleado.IdEmpleado = Pedidos.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Pedidos.IdTipoPago where Pedidos.Entregado = 1", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }
        public void BuscarNoEntregado()
        {
            SqlCommand cmd = new SqlCommand("select InventarioProducto.Nom_Producto as 'Producto', DetallePedido.Cantidad, DetallePedido.Precio_Uni as 'Precio', DetallePedido.Descuento, Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.Entregado, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetallePedido on InventarioProducto.IdProducto = DetallePedido.IdProducto inner join Pedidos on Pedidos.IdPedido = DetallePedido.IdPedido inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente inner join Empleado on Empleado.IdEmpleado = Pedidos.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Pedidos.IdTipoPago where Pedidos.Entregado = 0", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }
        public void BuscarCliente(string nombre)
        {
            SqlCommand cmd = new SqlCommand("select InventarioProducto.Nom_Producto as 'Producto', DetallePedido.Cantidad, DetallePedido.Precio_Uni as 'Precio', DetallePedido.Descuento, Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.Entregado, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetallePedido on InventarioProducto.IdProducto = DetallePedido.IdProducto inner join Pedidos on Pedidos.IdPedido = DetallePedido.IdPedido inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente inner join Empleado on Empleado.IdEmpleado = Pedidos.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Pedidos.IdTipoPago where Cliente.Nombre like '%" + nombre + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }
        public void BuscarXFecha(string fecha)
        {
            SqlCommand cmd = new SqlCommand("select InventarioProducto.Nom_Producto as 'Producto', DetallePedido.Cantidad, DetallePedido.Precio_Uni as 'Precio', DetallePedido.Descuento, Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.Entregado, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetallePedido on InventarioProducto.IdProducto = DetallePedido.IdProducto inner join Pedidos on Pedidos.IdPedido = DetallePedido.IdPedido inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente inner join Empleado on Empleado.IdEmpleado = Pedidos.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Pedidos.IdTipoPago where Pedidos.FechaPedido like '%" + fecha + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }

        private void txtProducto_Enter(object sender, EventArgs e)
        {
            if (txtProducto.Text == "Buscar Producto")
            {
                txtProducto.Text = "";
            }
        }

        private void txtCliente_Enter(object sender, EventArgs e)
        {
            if (txtCliente.Text == "Buscar Cliente")
            {
                txtCliente.Text = "";
            }
        }

        private void txtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "dd/mm/aaaa")
            {
                txtFecha.Text = "";
            }
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (txtProducto.Text == "")
            {
                txtProducto.Text = "Buscar Producto";
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                txtCliente.Text = "Buscar Cliente";
            }
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "dd/mm/aaaa";
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //Referencia Microsoft.Office.Interop.Excel en Visual Studio 2015
            //C:\Windows\assembly\GAC_MSIL\Microsoft.Office.Interop.Excel\15.0.0.0__71e9bce111e9429c for Visual Studio 2015

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            Range rng = ws.get_Range("A1:L1");
            rng.Interior.Color = XlRgbColor.rgbLightBlue;

            ws.Cells[1, 1] = "IdPedido";
            ws.Cells[1, 2] = "Producto";
            ws.Cells[1, 3] = "Cantida";
            ws.Cells[1, 4] = "Precio";
            ws.Cells[1, 5] = "Descuento";
            ws.Cells[1, 6] = "Cliente";
            ws.Cells[1, 7] = "Empleado";
            ws.Cells[1, 8] = "FechaPedido";
            ws.Cells[1, 9] = "FechaEntrega";
            ws.Cells[1, 10] = "Entregado";
            ws.Cells[1, 11] = "Tipo de pago";

            for (int j = 2; j <= tablaHistorial.Rows.Count + 1; j++)
            {
                for (int i = 1; i <= 11; i++)
                {
                    ws.Cells[j, i] = tablaHistorial.Rows[j - 2].Cells[i - 1].Value;
                }

            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnEntregado.BackColor = Color.Orange;
            btnEntregado.ForeColor = Color.White;
        }

        private void btnEntregado_MouseLeave(object sender, EventArgs e)
        {
            btnEntregado.BackColor = Color.White;
            btnEntregado.ForeColor = Color.Black;
        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            try
            {
                string actualizar = "Entregado = 1";
                if (db.Actualizar("Pedidos", actualizar, "IdPedido =" + dgv_id))
                {
                    MessageBox.Show("Se ha confirmado la entregado del pedido!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.cargarDatos("select Pedidos.IdPedido, InventarioProducto.Nom_Producto as 'Producto', DetallePedido.Cantidad, DetallePedido.Precio_Uni as 'Precio', DetallePedido.Descuento, Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.Entregado, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetallePedido on InventarioProducto.IdProducto = DetallePedido.IdProducto inner join Pedidos on Pedidos.IdPedido = DetallePedido.IdPedido inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente inner join Empleado on Empleado.IdEmpleado = Pedidos.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Pedidos.IdTipoPago ORDER BY Pedidos.FechaPedido desc", tablaHistorial);
                }
                else
                {
                    MessageBox.Show("Error al confirmar entrega", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione primero una entrega", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tablaHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cada variable tendra el valor de la fila seleccionada con sus celdas
            dgv_id = Convert.ToString((Int32)tablaHistorial.Rows[e.RowIndex].Cells[0].Value);
        }

        private void rbNoEntregados_CheckedChanged(object sender, EventArgs e)
        {
            BuscarNoEntregado();
        }

        private void rbEntregados_CheckedChanged_1(object sender, EventArgs e)
        {
            BuscarEntregado();
        }

        private void HistorialPedidos_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
