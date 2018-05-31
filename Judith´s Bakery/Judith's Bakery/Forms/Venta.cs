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
    public partial class Venta : Form
    {
        DataBase db = new DataBase();
        Validaciones val = new Validaciones();

        public Venta()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }
        private void bt_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            db.llenarItems(cbProducto, "SELECT Nom_Producto FROM InventarioProducto WHERE Activo=1", "Nom_Producto");
            db.llenarItems(cbCliente, "SELECT Nombre FROM Cliente", "Nombre");
            db.llenarItems(cbTipoPago, "SELECT Tipo FROM TiposDePago", "Tipo");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                decimal dgv_total = 0;
                DataGridViewRow fila = new DataGridViewRow();

                fila.CreateCells(tablaVenta);
                //agregamos los datos de los controles a la tabla en sus respectivas celdas
                fila.Cells[0].Value = cbCliente.Text;
                fila.Cells[1].Value = cbProducto.Text;
                fila.Cells[2].Value = txtPrecio.Text;
                fila.Cells[3].Value = txtCantidad.Text;
                fila.Cells[4].Value = txtDescuento.Text;
                fila.Cells[5].Value = cbTipoPago.Text;
                dgv_total = Convert.ToDecimal(txtPrecio.Text) * Convert.ToDecimal(txtCantidad.Text);
                fila.Cells[6].Value = dgv_total - ((dgv_total * Convert.ToDecimal(txtDescuento.Text) / 100));

                tablaVenta.Rows.Add(fila);

                cbCliente.Text = "Cliente";
                cbProducto.Text = "Producto";
                cbTipoPago.Text = "Tipo De Pago";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                txtDescuento.Text = "";

                //calcular el total de todos los productos
                decimal lb_total = 0;
                foreach (DataGridViewRow row in tablaVenta.Rows) //recorera la columna que le indiquemos
                {
                    lb_total += Convert.ToDecimal(row.Cells["SubTotal"].Value); //recorremos toda la columna llamado SubTotal y sumamos su valores
                }

                lbTotal.Text = "$ " + Convert.ToString(lb_total);
                
            }
            else
            {

            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                tablaVenta.Rows.Remove(tablaVenta.CurrentRow);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay elementos que quitar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (tablaVenta.Rows.Count == 0)
            {
                MessageBox.Show("Aún no agregas nada para vender", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand comandoVenta = new SqlCommand("insert into Venta values(@idCliente, '" + InicioSesion.IDEmpleadoSesion + "', '" + DateTime.Now.ToString("dd/MM/yyyy") + "', '" + DateTime.Now.ToLongTimeString() + "', @idTipoPago)", DataBase.Conexion());
                try
                {
                    foreach (DataGridViewRow row in tablaVenta.Rows)
                    {
                        comandoVenta.Parameters.Clear();

                        comandoVenta.Parameters.AddWithValue("@idCliente", traerIDCliente(Convert.ToString(row.Cells["Cliente"].Value)));
                        comandoVenta.Parameters.AddWithValue("@idTipoPago", traerIDtipopago(Convert.ToString(row.Cells["TipoPago"].Value)));

                        comandoVenta.ExecuteNonQuery();

                        SqlCommand comandoDetalleVenta = new SqlCommand("insert into DetalleVenta values(" + traerIDventa() + ", @idProducto, @cantidad, @precio, @descuento)", DataBase.Conexion());

                        comandoDetalleVenta.Parameters.Clear();

                        comandoDetalleVenta.Parameters.AddWithValue("@idProducto", traerIDproducto(Convert.ToString(row.Cells["Producto"].Value)));
                        comandoDetalleVenta.Parameters.AddWithValue("@cantidad", (Convert.ToString(row.Cells["Cantidad"].Value)));
                        comandoDetalleVenta.Parameters.AddWithValue("@precio", (Convert.ToString(row.Cells["Precio"].Value)));
                        comandoDetalleVenta.Parameters.AddWithValue("@descuento", (Convert.ToString(row.Cells["Descuento"].Value)));

                        comandoDetalleVenta.ExecuteNonQuery();

                        string actualizar = "Cantidad-= '" + (Convert.ToString(row.Cells["Cantidad"].Value)) + "' ";
                        db.Actualizar("InventarioProducto", actualizar, "IdProducto =" + traerIDproducto(Convert.ToString(row.Cells["Producto"].Value)));
                    }
                    MessageBox.Show("Venta realizada con exito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tablaVenta.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la venta. " + ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //TRAER EL ID DEL CLIENTE
        public int traerIDCliente(string nombre)
        {
            //Vamos a traer el Id y nombre del empleado para saber quien es
            SqlCommand cmd = new SqlCommand("Select IdCliente, Nombre from Cliente WHERE Nombre = @nombre ", DataBase.Conexion());
            cmd.Parameters.AddWithValue("nombre", nombre); //Igualamos id con el parametro IdEmpleado
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        //TRAER EL ID DEL TIPO DE PAGO
        public int traerIDtipopago(string tipo)
        {
            //Vamos a traer el Id y nombre del empleado para saber quien es
            SqlCommand cmd = new SqlCommand("Select IdTipoPago, Tipo from TiposDePago WHERE Tipo = @tipo ", DataBase.Conexion());
            cmd.Parameters.AddWithValue("tipo", tipo); //Igualamos id con el parametro IdEmpleado
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        //TRAER EL ID DEL PRODUCTO
        public int traerIDproducto(string producto)
        {
            //Vamos a traer el Id y nombre del empleado para saber quien es
            SqlCommand cmd = new SqlCommand("Select IdProducto, Nom_Producto from InventarioProducto WHERE Nom_Producto = @producto ", DataBase.Conexion());
            cmd.Parameters.AddWithValue("producto", producto); //Igualamos id con el parametro IdEmpleado
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        //TRAER EL ID DE VENTA
        public int traerIDventa()
        {
            //Vamos a traer el Id, tomamos el ultimo valor agregado
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdVenta FROM Venta ORDER BY IdVenta DESC", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lb_ayuda.Visible = true;
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comando = "Select Precio from InventarioProducto where Nom_Producto='" + cbProducto.Text + "' ";
            SqlCommand cmd = new SqlCommand(comando, DataBase.Conexion());
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                txtPrecio.Text = leer["Precio"].ToString();
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialVenta hv = new HistorialVenta();
            hv.Show();
            this.Hide();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosEnteros(e);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosEnteros(e);
        }

        public bool ValidarCampos()
        {
            bool ok = true;
            if (cbCliente.Text == "Cliente")
            {
                ok = false;
                MessageBox.Show("Seleccione un Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cbProducto.Text == "Producto")
            {
                ok = false;
                MessageBox.Show("Seleccione un producto, si no encuentre el producto que busca cree un nuevo producto en el modulo de Producto Final", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtCantidad.Text == "")
            {
                ok = false;
                txtCantidad.LineIdleColor = Color.Red;
                MessageBox.Show("Escriba la cantidad a comprar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbTipoPago.Text == "Tipo De Pago")
            {
                ok = false;
                MessageBox.Show("Seleccione el tipo de pago a realizar la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }

        private void Venta_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {
                
                this.Close();
            }
        }
    }
}
