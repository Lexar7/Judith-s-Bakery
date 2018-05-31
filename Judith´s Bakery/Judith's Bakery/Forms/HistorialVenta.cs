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
    public partial class HistorialVenta : Form
    {
        DataBase db = new DataBase();
        Venta v = new Venta();
        public HistorialVenta()
        {
            InitializeComponent();
        }

        private void HistorialVenta_Load(object sender, EventArgs e)
        {
            //Cargamos los datos a la tabla llamando nuestro metodo cargarDatos de nuestra clase DataBase
            db.cargarDatos("select InventarioProducto.Nom_Producto as 'Producto', DetalleVenta.Cantidad, DetalleVenta.Precio_Uni as 'Precio', DetalleVenta.Descuento, CONVERT(decimal(18,2),(DetalleVenta.Cantidad * DetalleVenta.Precio_Uni) - (((DetalleVenta.Cantidad * DetalleVenta.Precio_Uni)* DetalleVenta.Descuento) / 100)) as 'Total Pagado', Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Venta.FechaVenta, Venta.Hora, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetalleVenta on InventarioProducto.IdProducto = DetalleVenta.IdProducto inner join Venta on Venta.IdVenta = DetalleVenta.IdVenta inner join Cliente on Cliente.IdCliente = Venta.IdCliente inner join Empleado on Empleado.IdEmpleado = Venta.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Venta.IdTipoPago ORDER BY Venta.FechaVenta desc, Venta.Hora desc", tablaHistorial);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            v.Show();
        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            v.Show();
        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            //Cargamos los datos a la tabla llamando nuestro metodo cargarDatos de nuestra clase DataBase
            db.cargarDatos("select InventarioProducto.Nom_Producto as 'Producto', DetalleVenta.Cantidad, DetalleVenta.Precio_Uni as 'Precio', DetalleVenta.Descuento, CONVERT(decimal(18,2),(DetalleVenta.Cantidad * DetalleVenta.Precio_Uni) - (((DetalleVenta.Cantidad * DetalleVenta.Precio_Uni)* DetalleVenta.Descuento) / 100)) as 'Total Pagado', Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Venta.FechaVenta, Venta.Hora, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetalleVenta on InventarioProducto.IdProducto = DetalleVenta.IdProducto inner join Venta on Venta.IdVenta = DetalleVenta.IdVenta inner join Cliente on Cliente.IdCliente = Venta.IdCliente inner join Empleado on Empleado.IdEmpleado = Venta.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Venta.IdTipoPago ORDER BY Venta.FechaVenta desc, Venta.Hora desc", tablaHistorial);

            txtProducto.Text = "Buscar Producto";
            txtEmpleado.Text = "Buscar Empleado";
            txtCliente.Text = "Buscar Cliente";
            txtFecha.Text = "dd/mm/aaaa";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbProducto.Checked == false && rbEmpleado.Checked == false && rbCliente.Checked == false && rbFecha.Checked == false)
            {
                MessageBox.Show("Seleccione primero lo que desea buscar, nombre o fecha", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rbProducto.Checked == true)
                {
                    BuscarProducto(txtProducto.Text.ToString()); //Llamar al metodo y pasarle el parametro
                }
                else if (rbEmpleado.Checked == true)
                {
                    BuscarNombreEmpleado(txtEmpleado.Text.ToString());
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
            SqlCommand cmd = new SqlCommand("select InventarioProducto.Nom_Producto as 'Producto', DetalleVenta.Cantidad, DetalleVenta.Precio_Uni as 'Precio', DetalleVenta.Descuento, Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Venta.FechaVenta, Venta.Hora, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetalleVenta on InventarioProducto.IdProducto = DetalleVenta.IdProducto inner join Venta on Venta.IdVenta = DetalleVenta.IdVenta inner join Cliente on Cliente.IdCliente = Venta.IdCliente inner join Empleado on Empleado.IdEmpleado = Venta.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Venta.IdTipoPago where InventarioProducto.Nom_Producto like '%" + nombre + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }
        public void BuscarNombreEmpleado(string nombre)
        {
            SqlCommand cmd = new SqlCommand("select InventarioProducto.Nom_Producto as 'Producto', DetalleVenta.Cantidad, DetalleVenta.Precio_Uni as 'Precio', DetalleVenta.Descuento, Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Venta.FechaVenta, Venta.Hora, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetalleVenta on InventarioProducto.IdProducto = DetalleVenta.IdProducto inner join Venta on Venta.IdVenta = DetalleVenta.IdVenta inner join Cliente on Cliente.IdCliente = Venta.IdCliente inner join Empleado on Empleado.IdEmpleado = Venta.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Venta.IdTipoPago where Empleado.Nombre like '%" + nombre + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }
        public void BuscarCliente(string nombre)
        {
            SqlCommand cmd = new SqlCommand("select InventarioProducto.Nom_Producto as 'Producto', DetalleVenta.Cantidad, DetalleVenta.Precio_Uni as 'Precio', DetalleVenta.Descuento, Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Venta.FechaVenta, Venta.Hora, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetalleVenta on InventarioProducto.IdProducto = DetalleVenta.IdProducto inner join Venta on Venta.IdVenta = DetalleVenta.IdVenta inner join Cliente on Cliente.IdCliente = Venta.IdCliente inner join Empleado on Empleado.IdEmpleado = Venta.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Venta.IdTipoPago where Cliente.Nombre like '%" + nombre + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }
        public void BuscarXFecha(string fecha)
        {
            SqlCommand cmd = new SqlCommand("select InventarioProducto.Nom_Producto as 'Producto', DetalleVenta.Cantidad, DetalleVenta.Precio_Uni as 'Precio', DetalleVenta.Descuento, Cliente.Nombre as 'Cliente', Empleado.Nombre as 'Empleado', Venta.FechaVenta, Venta.Hora, TiposDePago.Tipo as 'Tipo de pago' from InventarioProducto inner join DetalleVenta on InventarioProducto.IdProducto = DetalleVenta.IdProducto inner join Venta on Venta.IdVenta = DetalleVenta.IdVenta inner join Cliente on Cliente.IdCliente = Venta.IdCliente inner join Empleado on Empleado.IdEmpleado = Venta.IdEmpleado inner join TiposDePago on TiposDePago.IdTipoPago = Venta.IdTipoPago where Venta.FechaVenta like '%" + fecha + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtProducto.Text == "Buscar Producto")
            {
                txtProducto.Text = "";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtEmpleado.Text == "Buscar Empleado")
            {
                txtEmpleado.Text = "";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
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

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtProducto.Text == "")
            {
                txtProducto.Text = "Buscar Producto";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtEmpleado.Text == "")
            {
                txtEmpleado.Text = "Buscar Empleado";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
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

            Range rng = ws.get_Range("A1:I1");
            rng.Interior.Color = XlRgbColor.rgbLightBlue;


            ws.Cells[1, 1] = "Producto";
            ws.Cells[1, 2] = "Cantida";
            ws.Cells[1, 3] = "Precio";
            ws.Cells[1, 4] = "Descuento";
            ws.Cells[1, 5] = "Cliente";
            ws.Cells[1, 6] = "Empleado";
            ws.Cells[1, 7] = "FechaVenta";
            ws.Cells[1, 8] = "Hora";
            ws.Cells[1, 9] = "Tipo de pago";

            for (int j = 2; j <= tablaHistorial.Rows.Count + 1; j++)
            {
                for (int i = 1; i <= 9; i++)
                {
                    ws.Cells[j, i] = tablaHistorial.Rows[j - 2].Cells[i - 1].Value;
                }

            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MAS VENDIDOS
            db.cargarDatos("SELECT InventarioProducto.Nom_Producto as 'Producto', SUM(DetalleVenta.Cantidad) as 'Cantidad', DetalleVenta.Precio_Uni FROM InventarioProducto inner join DetalleVenta on InventarioProducto.IdProducto = DetalleVenta.IdProducto GROUP BY InventarioProducto.Nom_Producto, DetalleVenta.Precio_Uni ORDER BY 'Cantidad' DESC", tablaHistorial);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MAS VENDIDOS
            db.cargarDatos("SELECT InventarioProducto.Nom_Producto as 'Producto', SUM(DetalleVenta.Cantidad) as 'Cantidad', DetalleVenta.Precio_Uni FROM InventarioProducto inner join DetalleVenta on InventarioProducto.IdProducto = DetalleVenta.IdProducto GROUP BY InventarioProducto.Nom_Producto, DetalleVenta.Precio_Uni ORDER BY 'Cantidad' ASC", tablaHistorial);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
        }

        private void HistorialVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
