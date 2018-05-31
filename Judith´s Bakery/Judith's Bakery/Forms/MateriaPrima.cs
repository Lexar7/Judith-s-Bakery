using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Judith_s_Bakery.Forms
{
    public partial class MateriaPrima : Form
    {
        public string dgv_id, dgv_nombre, dgv_precio, dgv_cantidad,dgv_medida, dgv_categoria, dgv_temporal,dgv_caducidad, dgv_activo;
        public MateriaPrima()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void bt_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lb_ayuda.Visible = true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void MateriaPrima_Load(object sender, EventArgs e)
        {
            db.cargarDatos("SELECT * FROM InventarioMateriaPrima WHERE Activo = 1", tablaMateria);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPrecios.Checked == false && rbNombre.Checked == false)
                {
                    MessageBox.Show("Seleccione primero lo que desea buscar, nombre o rango de precios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (rbPrecios.Checked == true)
                    {
                        db.BuscarRango("InventarioMateriaPrima", "Precio", Double.Parse(txtDesde.Text), Double.Parse(txtHasta.Text), tablaMateria);
                    }
                    else if (rbNombre.Checked == true)
                    {
                        db.BuscarporUnParametro("InventarioMateriaPrima", "Producto", txtNombre.Text, tablaMateria);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Escriba lo que quiere buscar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar == (char)Keys.Back) && (Char.IsPunctuation(e.KeyChar)))
            {
                MessageBox.Show("Por favor ingrese solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = false;
                return;
            }
        }
        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar == (char)Keys.Back) && (Char.IsPunctuation(e.KeyChar)))
            {
                MessageBox.Show("Por favor ingrese solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = false;
                return;
            }
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Buscar Producto")
            {
                txtNombre.Text = "";
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Buscar Producto";
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CrearModificarMateriaPrima mpf = new CrearModificarMateriaPrima();
                mpf.bt_crear.Visible = false;
                mpf.bt_modificar.Visible = true;
                mpf.lb_id.Visible = true;
                mpf.lb_numeroID.Visible = true;
                mpf.lb_numeroID.Text = dgv_id;
                mpf.txtPrecio.Text = dgv_precio;
                mpf.txtNombre.Text = dgv_nombre;
                mpf.txtCantidad.Text = dgv_cantidad;
                mpf.cbMedida.Text = dgv_medida;
                mpf.cbActivo.Text = "Activo";
                mpf.label1.Text = "Modificar Materia Prima";
                mpf.txtCantidad.Enabled = true;
                mpf.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione primero una celda de algún producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialMateriaPrima hmp = new HistorialMateriaPrima();
            this.Hide();
            hmp.Show();
            
        }

        private void txtDesde_Enter(object sender, EventArgs e)
        {
            if (txtDesde.Text == "Desde")
            {
                txtDesde.Text = "";
            }
        }

        private void txtDesde_Leave(object sender, EventArgs e)
        {
            if (txtDesde.Text == "")
            {
                txtDesde.Text = "Desde";
            }
        }
        private void txtHasta_Enter(object sender, EventArgs e)
        {
            if (txtHasta.Text == "Hasta")
            {
                txtHasta.Text = "";
            }
        }
        private void txtHasta_Leave(object sender, EventArgs e)
        {
            if (txtHasta.Text == "")
            {
                txtHasta.Text = "Hasta";
            }
        }
        private void btnVista_Click(object sender, EventArgs e)
        {
            db.cargarDatos("SELECT * FROM InventarioMateriaPrima WHERE Activo = 1", tablaMateria);
            txtNombre.Text = "Buscar Producto";
            txtHasta.Text = "Hasta";
            txtDesde.Text = "Desde";
      
        }
        private void bt_agregar_Click(object sender, EventArgs e)
        {
            CrearModificarMateriaPrima cmp = new CrearModificarMateriaPrima();
            cmp.Show();
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar la Materia Prima " + dgv_nombre + "?", "Eliminar la Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //ELIMINAR, SOLO SE NECESITAN CAMBIAR LOS PARAMETROS PARA USAR EN OTRA TABLA
                    // Le pasamos la varibale dgv_id para que tome el IdProducto de la fila seleccionada
                    if (db.Actualizar("InventarioMateriaPrima"," Activo = 0", "IdProducto = " + dgv_id))
                    {
                        MessageBox.Show("Producto eliminado, su estado pasara a inactivo=0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Volvemos a cargar los datos a la tabla
                        db.cargarDatos("SELECT InventarioMateriaPrima.IdProducto, InventarioMateriaPrima.Producto, InventarioMateriaPrima.Medida, InventarioMateriaPrima.Cantidad, InventarioMateriaPrima.Precio,  InventarioMateriaPrima.Caducidad, InventarioMateriaPrima.Activo FROM InventarioMateriaPrima where InventarioMateriaPrima.Activo=1", tablaMateria);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione primero una celda de algún Producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tablaMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_id = Convert.ToString((Int32)tablaMateria.Rows[e.RowIndex].Cells[0].Value);
            dgv_nombre = tablaMateria.Rows[e.RowIndex].Cells[1].Value.ToString();
            dgv_medida = tablaMateria.Rows[e.RowIndex].Cells[2].Value.ToString();
            dgv_cantidad = Convert.ToString((Decimal)tablaMateria.Rows[e.RowIndex].Cells[3].Value);
            dgv_precio = Convert.ToString((Decimal)tablaMateria.Rows[e.RowIndex].Cells[4].Value);
            dgv_caducidad = tablaMateria.Rows[e.RowIndex].Cells[5].Value.ToString();
            dgv_activo = tablaMateria.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void MateriaPrima_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
