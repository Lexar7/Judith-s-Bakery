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
    public partial class ProductoFinal : Form
    {
        public string dgv_id, dgv_nombre, dgv_precio, dgv_cantidad, dgv_categoria,dgv_temporal, dgv_activo;
        DataBase db = new DataBase();

        public ProductoFinal()
        {
            InitializeComponent();
        }

        
        private void ProductoFinal_Load(object sender, EventArgs e)
        {
            db.cargarDatos("SELECT IdProducto, Nom_Producto AS 'Producto', Precio, Cantidad, Categoria, Activo FROM InventarioProducto INNER JOIN Categoria ON Categoria.IdCategoria= InventarioProducto.IdCategoria WHERE Activo=1 GROUP BY IdProducto, Nom_Producto, Precio, Cantidad, Categoria, Activo", tablaProducto);
        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_usuarios_Click(object sender, EventArgs e)
        {
            CrearProductoFinal cpf = new CrearProductoFinal();
            cpf.Show();
            this.Close();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
                if (rbNombre.Checked == false && rbPrecios.Checked == false)
                {
                    MessageBox.Show("Seleccione primero lo que desea buscar, nombre o rango de precios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (rbPrecios.Checked == true)
                    {
                        BuscarProductoPrecios(Convert.ToDecimal(txtDesde.Text), Convert.ToDecimal(txtHasta.Text));
                    }
                    else if (rbNombre.Checked == true)
                    {
                        BuscarProducto(txtNombre.Text);
                    }
                }
        }

        public void BuscarProducto(string nombre)
        {
            SqlCommand cmd = new SqlCommand("SELECT InventarioProducto.IdProducto, InventarioProducto.Nom_Producto as 'Producto', InventarioProducto.Precio, InventarioProducto.Cantidad, Categoria.Categoria, InventarioProducto.Activo FROM InventarioProducto inner join Categoria on InventarioProducto.IdCategoria=Categoria.IdCategoria where InventarioProducto.Nom_Producto like '%" + nombre + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaProducto.DataSource = dt;
        }

        public void BuscarProductoPrecios(decimal desde, decimal hasta)
        {
            SqlCommand cmd = new SqlCommand("SELECT InventarioProducto.IdProducto, InventarioProducto.Nom_Producto as 'Producto', InventarioProducto.Precio, InventarioProducto.Cantidad, Categoria.Categoria, InventarioProducto.Activo FROM InventarioProducto inner join Categoria on InventarioProducto.IdCategoria=Categoria.IdCategoria where InventarioProducto.Precio between " + desde + " and " + hasta + " and InventarioProducto.Activo=1", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaProducto.DataSource = dt;
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
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialProductoFinal hpf = new HistorialProductoFinal();
            this.Hide();
            hpf.Show();

        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            //Referencia Microsoft.Office.Interop.Excel en Visual Studio 2015
            //C:\Windows\assembly\GAC_MSIL\Microsoft.Office.Interop.Excel\15.0.0.0__71e9bce111e9429c for Visual Studio 2015

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            Range rng = ws.get_Range("A1:F1");
            rng.Interior.Color = XlRgbColor.rgbLightBlue;


            ws.Cells[1, 1] = "IdProducto";
            ws.Cells[1, 2] = "Producto";
            ws.Cells[1, 3] = "Precio";
            ws.Cells[1, 4] = "Cantidad";
            ws.Cells[1, 5] = "Categoria";
            ws.Cells[1, 6] = "Activo";


            for (int j = 2; j <= tablaProducto.Rows.Count + 1; j++)
            {
                for (int i = 1; i <= 6; i++)
                {
                    ws.Cells[j, i] = tablaProducto.Rows[j - 2].Cells[i - 1].Value;
                }

            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lb_ayuda.Visible = true;
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al producto " + dgv_nombre + "?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //ELIMINAR, SOLO SE NECESITAN CAMBIAR LOS PARAMETROS PARA USAR EN OTRA TABLA
                    // Le pasamos la varibale dgv_id para que tome el IdProducto de la fila seleccionada
                    if (db.Actualizar("InventarioProducto","Activo=0", "IdProducto = " + dgv_id))
                    {
                        MessageBox.Show("Producto eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Volvemos a cargar los datos a la tabla
                        db.cargarDatos("SELECT InventarioProducto.IdProducto, InventarioProducto.Nom_Producto as 'Producto', InventarioProducto.Precio_Uni, InventarioProducto.Cantidad, Categoria.Categoria, InventarioProducto.Activo FROM InventarioProducto inner join Categoria on InventarioProducto.IdCategoria=Categoria.IdCategoria where InventarioProducto.Activo=1", tablaProducto);
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
        private void tablaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_id = Convert.ToString((Int32)tablaProducto.Rows[e.RowIndex].Cells[0].Value);
            dgv_nombre = (string)tablaProducto.Rows[e.RowIndex].Cells[1].Value;
            dgv_precio = Convert.ToString((Decimal)tablaProducto.Rows[e.RowIndex].Cells[2].Value);
            dgv_cantidad = Convert.ToString((Int32)tablaProducto.Rows[e.RowIndex].Cells[3].Value);
            dgv_categoria= (string)tablaProducto.Rows[e.RowIndex].Cells[4].Value;
            //dgv_activo = Convert.ToString((Boolean)tablaProducto.Rows[e.RowIndex].Cells[5].Value);
            //dgv_categoria = Int32.Parse(dgv_temporal).ToString();
            //DataBase.index = dgv_categoria;
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
        private void btnVista_Click(object sender, EventArgs e)
        {
            db.cargarDatos("SELECT IdProducto, Nom_Producto AS 'Producto', Precio, Cantidad, Categoria, Activo FROM InventarioProducto INNER JOIN Categoria ON Categoria.IdCategoria=InventarioProducto.IdCategoria WHERE Activo=1 GROUP BY IdProducto, Nom_Producto, Precio, Cantidad, Categoria, Activo", tablaProducto);
            txtNombre.Text = "Buscar Producto";
            txtHasta.Text = "Hasta";
            txtDesde.Text = "Desde";
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarProductoFinal mpf = new ModificarProductoFinal();
                mpf.lb_numeroID.Text = dgv_id;
                mpf.txtPrecio.Text = dgv_precio;
                mpf.txtNombre.Text = dgv_nombre;
                mpf.txtCantidad.Text = dgv_cantidad;
                mpf.cbCategoria.Text = dgv_categoria;
                mpf.cbActivo.Text = "Activo";
                mpf.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione primero una celda de algún producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ProductoFinal_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
