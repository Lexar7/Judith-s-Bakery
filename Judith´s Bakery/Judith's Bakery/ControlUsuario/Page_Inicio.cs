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
using System.Data.SqlClient;

namespace Judith_s_Bakery
{
    public partial class Page_Inicio : UserControl
    {
        DataBase db = new DataBase();
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
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("¿Desea cerrar sesión?", "Judith's Bakery", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                DataBase.Conexion().Close();
                Application.Restart();
            }

            //InicioSesion login = new InicioSesion();
            //login.Show();
            //this.Close();       
        }

        private void bunifuImageButton1_MouseEnter_1(object sender, EventArgs e)
        {
            lblCerrarS.ForeColor = Color.Orange;
        }

        private void CerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            lblCerrarS.ForeColor = Color.Black;
        }
        private void Page_Inicio_Load(object sender, EventArgs e)
        {
            db.cargarDatos("select Pedidos.IdPedido, Cliente.Nombre as 'Cliente', Pedidos.FechaEntrega from Cliente inner join Pedidos on Cliente.IdCliente = Pedidos.IdCliente where Pedidos.Entregado = 0", tablaHistorial);
            db.cargarDatos("SELECT Producto, Caducidad FROM InventarioMateriaPrima WHERE Caducidad<= DATEADD(dd,2,GETDATE())",tablaCaducidad);
        }


        public void traerInformacionPedido(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select Pedidos.IdPedido, Cliente.Nombre as 'Cliente', InventarioProducto.Nom_Producto as 'Producto', DetallePedido.Cantidad, (DetallePedido.Cantidad * DetallePedido.Precio_Uni) as 'Total', DetallePedido.Descuento,Pedidos.FechaPedido, Pedidos.FechaEntrega from InventarioProducto inner join DetallePedido on InventarioProducto.IdProducto = DetallePedido.IdProducto  inner join Pedidos on Pedidos.IdPedido = DetallePedido.IdPedido  inner join Cliente on Cliente.IdCliente = Pedidos.IdCliente WHERE Pedidos.IdPedido = @id ", DataBase.Conexion());
                cmd.Parameters.AddWithValue("id", id); //Igualamos id con el parametro IdEmpleado
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1) //Si es igual a 1 es porque existen filas en la tabla
                {
                    MessageBox.Show("Cliente: " + dt.Rows[0][1].ToString() + "\nProducto: " + dt.Rows[0][2].ToString() + "\nCantidad: " + dt.Rows[0][3].ToString() + "\nTotal a pagar: " + dt.Rows[0][4].ToString() + "\nDescuento: " + dt.Rows[0][5].ToString() + "\nFecha Pedido: " + dt.Rows[0][6].ToString() + "\nFecha Entrega: " + dt.Rows[0][7].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Id de pedido incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DataBase.Conexion().Close(); //Cerramos conexion con la base de datos
            }
        }

        private void tablaHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            traerInformacionPedido((Int32)tablaHistorial.Rows[e.RowIndex].Cells[0].Value);
        }

        private void Page_Inicio_KeyUp(object sender, KeyEventArgs e)
        {
            
            
        }
    }
}
