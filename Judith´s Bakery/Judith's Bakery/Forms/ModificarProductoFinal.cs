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
    public partial class ModificarProductoFinal : Form
    {
        DataBase db = new DataBase();
        ProductoFinal pf = new ProductoFinal();
        Validaciones val = new Validaciones();
        int activo;
        public ModificarProductoFinal()
        {
            InitializeComponent();
        }

        private void ModificarProductoFinal_Load(object sender, EventArgs e)
        {
            db.llenarItems(cbCategoria, "SELECT Categoria FROM Categoria", "Categoria");
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            pf.Show();
            this.Close();
        }

        private void bt_crear_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    //MODIGICAR EMPLEADO, SOLO ES NECESARIO CAMBIAR EL COMANDO PARA USARLO EN OTRA TABLA Y LISTO
                    //Escribimos los campos que queremos modificar
                    string actualizar = "Nom_Producto= '" + txtNombre.Text + "', Precio = '" + txtPrecio.Text + "', Cantidad = '" + txtCantidad.Text + "', IdCategoria = '" + traerIDcategoria(cbCategoria.Text) + "', Activo = '" + obtenerEstado() + "' ";
                    //le pasamos los parametros de nuestro metodo Actualizar que se encuentra en la clase DataBase
                    if (db.Actualizar("InventarioProducto", actualizar, "IdProducto =" + lb_numeroID.Text))
                    {

                        MessageBox.Show("Producto actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        pf.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el producto, seleccione Cancelar y vuelva a intentarlo" + ex, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int obtenerEstado()
        {
            if (cbActivo.Text == "Activo")
            {
                activo = 1;
            }
            else
            {
                activo = 0;
            }
            return Convert.ToInt32(activo);
        }

        //OBTENER ID CATEGORIA
        public int traerIDcategoria(string categoria)
        {
            //Vamos a traer el Id y nombre de la categoria para saber quien es
            SqlCommand cmd = new SqlCommand("Select IdCategoria, Categoria from Categoria WHERE Categoria = @categoria ", DataBase.Conexion());
            cmd.Parameters.AddWithValue("categoria", categoria); //Igualamos id con el parametro IdCategoria
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosEnteros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosPrecios(e);
        }

        public bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                txtNombre.LineIdleColor = Color.Red;
                MessageBox.Show("Debe de escribir el nombre del producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtPrecio.Text == "")
            {
                ok = false;
                txtPrecio.LineIdleColor = Color.Red;
                MessageBox.Show("Debe de escribir el precio del producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtCantidad.Text == "")
            {
                ok = false;
                txtCantidad.LineIdleColor = Color.Red;
                MessageBox.Show("Escriba la cantidad producida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbCategoria.Text == "Categoria")
            {
                ok = false;
                MessageBox.Show("Debe escoger una categoria", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }

        private void ModificarProductoFinal_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
