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
    public partial class CrearProductoFinal : Form
    {
        int activo;
        DataBase db = new DataBase();
        ProductoFinal pf = new ProductoFinal();
        Validaciones val = new Validaciones();

        public CrearProductoFinal()
        {
            InitializeComponent();
        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (db.SiExiste("InventarioProducto", "Nom_Producto", txtNombre.Text) == false)
                {
                    MessageBox.Show("Ya hay un producto con este nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int categoria = cb_categoria.SelectedIndex + 1;
                    int estado = cb_activo.SelectedIndex + 1;
                    string agregar = "INSERT INTO InventarioProducto VALUES('" + txtNombre.Text + "'," + txtPrecio.Text + "," + txtCantidad.Text + "," + categoria + "," + obtenerEstado() + ")";
                    if (db.Insertar(agregar))
                    {
                        MessageBox.Show("Producto Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        pf.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el Producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {

            }
        }

        private void CrearProductoFinal_Load(object sender, EventArgs e)
        {
            cb_categoria.DataSource = DataBase.ObtenerCategoria();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoFinal pf = new ProductoFinal();
            pf.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            lb_ayuda.Visible = true;
        }

        public int obtenerEstado()
        {
            if (cb_activo.Text == "Activo")
            {
                activo = 1;
            }
            else
            {
                activo = 0;
            }
            return Convert.ToInt32(activo);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosPrecios(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosEnteros(e);
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
            if (cb_categoria.Text == "Categoria")
            {
                ok = false;
                MessageBox.Show("Debe escoger una categoria", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }

        private void CrearProductoFinal_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
