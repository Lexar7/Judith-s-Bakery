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
    public partial class Compra : Form
    {
        
        DataBase db = new DataBase();
        Validaciones val = new Validaciones();
        public Compra()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            db.llenarItems(cbProducto, "SELECT Producto FROM InventarioMateriaPrima WHERE Activo=1", "Producto");
            db.llenarItems(cbProveedor, "SELECT Nombre FROM Proveedor", "Nombre");
            db.llenarItems(cbTipoPago, "SELECT Tipo FROM TiposDePago", "Tipo");
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }
     
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                decimal dgv_total = 0;
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(tablaCompra);
                //agregamos los datos de los controles a la tabla en sus respectivas celdas
                fila.Cells[0].Value = cbProveedor.Text;
                fila.Cells[1].Value = cbProducto.Text;
                fila.Cells[2].Value = txtPrecio.Text;
                fila.Cells[3].Value = txtCantidad.Text;
                fila.Cells[4].Value = txtDescuento.Text;
                fila.Cells[5].Value = cbTipoPago.Text;
                dgv_total = Convert.ToDecimal(txtPrecio.Text) * Convert.ToDecimal(txtCantidad.Text);
                fila.Cells[6].Value = dgv_total - ((dgv_total * Convert.ToDecimal(txtDescuento.Text) / 100));

                tablaCompra.Rows.Add(fila);

                cbProveedor.Text = "Proveedor";
                cbProducto.Text = "Producto";
                cbTipoPago.Text = "Tipo De Pago";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                txtDescuento.Text = "";

                //calcular el total de todos los productos
                decimal lb_total = 0;
                foreach (DataGridViewRow row in tablaCompra.Rows) //recorera la columna que le indiquemos
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
                tablaCompra.Rows.Remove(tablaCompra.CurrentRow);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay elementos que quitar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (tablaCompra.Rows.Count == 0)
            {
                MessageBox.Show("Aún no agregas nada para comprar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand comandoCompra = new SqlCommand("insert into Compra values(@idProveedor, '" + InicioSesion.IDEmpleadoSesion + "', '" + DateTime.Now.ToString("dd/MM/yyyy") + "', '" + DateTime.Now.ToLongTimeString() + "', @idTipoPago)", DataBase.Conexion());
                try
                {
                    foreach (DataGridViewRow row in tablaCompra.Rows)
                    {
                        comandoCompra.Parameters.Clear();

                        comandoCompra.Parameters.AddWithValue("@idProveedor", traerIDproveedor(Convert.ToString(row.Cells["Proveedor"].Value)));
                        comandoCompra.Parameters.AddWithValue("@idTipoPago", traerIDtipopago(Convert.ToString(row.Cells["TipoPago"].Value)));

                        comandoCompra.ExecuteNonQuery();

                        SqlCommand comandoDetalleCompra = new SqlCommand("insert into DetalleCompra values(" + traerIDcompra() + ", @idProducto, @cantidad, @precio, @descuento)", DataBase.Conexion());

                        comandoDetalleCompra.Parameters.Clear();

                        comandoDetalleCompra.Parameters.AddWithValue("@idProducto", traerIDproducto(Convert.ToString(row.Cells["Producto"].Value)));
                        comandoDetalleCompra.Parameters.AddWithValue("@cantidad", (Convert.ToString(row.Cells["Cantidad"].Value)));
                        comandoDetalleCompra.Parameters.AddWithValue("@precio", (Convert.ToString(row.Cells["Precio"].Value)));
                        comandoDetalleCompra.Parameters.AddWithValue("@descuento", (Convert.ToString(row.Cells["Descuento"].Value)));

                        comandoDetalleCompra.ExecuteNonQuery();

                        string actualizar = "Cantidad+= '" + (Convert.ToString(row.Cells["Cantidad"].Value)) + "' ";
                        db.Actualizar("InventarioMateriaPrima", actualizar, "IdProducto =" + traerIDproducto(Convert.ToString(row.Cells["Producto"].Value)));
                    }
                    MessageBox.Show("Compra realizada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tablaCompra.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la compra" + ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //TRAER EL ID DEL PROVEEDOR
        public int traerIDproveedor(string nombre)
        {
                //Vamos a traer el Id y nombre del empleado para saber quien es
                SqlCommand cmd = new SqlCommand("Select IdProveedor, Nombre from Proveedor WHERE Nombre = @nombre ", DataBase.Conexion());
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
            SqlCommand cmd = new SqlCommand("Select IdProducto, Producto from InventarioMateriaPrima WHERE Producto = @producto ", DataBase.Conexion());
            cmd.Parameters.AddWithValue("producto", producto); //Igualamos id con el parametro IdEmpleado
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        //TRAER EL ID DE COMPRA
        public int traerIDcompra()
        {
            //Vamos a traer el Id, tomamos el ultimo valor agregado
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdCompra FROM Compra ORDER BY IdCompra DESC", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lb_ayuda.Visible = true;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialCompras hc = new HistorialCompras();
            hc.Show();
            this.Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosPrecios(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosPrecios(e);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosEnteros(e);
        }

        public bool ValidarCampos()
        {
            bool ok = true;
            if (cbProveedor.Text == "Proveedor")
            {
                ok = false;
                MessageBox.Show("Seleccione un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbProducto.Text == "Producto")
            {
                ok = false;
                MessageBox.Show("Seleccione un producto, si no encuentre el producto que busca cree un nuevo producto en el modulo de Materia Prima", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtPrecio.Text == "")
            {
                ok = false;
                txtPrecio.LineIdleColor = Color.Red;
                MessageBox.Show("Escriba el costo del producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Seleccione el tipo de pago a realizar la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }

        private void Compra_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
