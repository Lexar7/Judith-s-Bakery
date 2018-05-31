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
    public partial class HistorialProductoFinal : Form
    {
        ProductoFinal pf = new ProductoFinal();
        DataBase db = new DataBase();
        string dgv_id;

        public HistorialProductoFinal()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            pf.Show();
        }

        private void HistorialProductoFinal_Load(object sender, EventArgs e)
        {
            //Cargamos los datos a la tabla llamando nuestro metodo cargarDatos de nuestra clase DataBase
            db.cargarDatos("SELECT InventarioProducto.IdProducto, InventarioProducto.Nom_Producto as 'Producto', InventarioProducto.Precio, InventarioProducto.Cantidad, Categoria.Categoria, InventarioProducto.Activo FROM InventarioProducto inner join Categoria on InventarioProducto.IdCategoria=Categoria.IdCategoria", tablaHistorial);

        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            db.cargarDatos("SELECT InventarioProducto.IdProducto, InventarioProducto.Nom_Producto as 'Producto', InventarioProducto.Precio, InventarioProducto.Cantidad, Categoria.Categoria, InventarioProducto.Activo FROM InventarioProducto inner join Categoria on InventarioProducto.IdCategoria=Categoria.IdCategoria", tablaHistorial);
        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            pf.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void rbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            db.cargarDatos("SELECT InventarioProducto.IdProducto, InventarioProducto.Nom_Producto as 'Producto', InventarioProducto.Precio, InventarioProducto.Cantidad, Categoria.Categoria, InventarioProducto.Activo FROM InventarioProducto inner join Categoria on InventarioProducto.IdCategoria=Categoria.IdCategoria where InventarioProducto.Activo=1", tablaHistorial);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            db.cargarDatos("SELECT InventarioProducto.IdProducto, InventarioProducto.Nom_Producto as 'Producto', InventarioProducto.Precio, InventarioProducto.Cantidad, Categoria.Categoria, InventarioProducto.Activo FROM InventarioProducto inner join Categoria on InventarioProducto.IdCategoria=Categoria.IdCategoria where InventarioProducto.Activo=0", tablaHistorial);

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
            

            for (int j = 2; j <= tablaHistorial.Rows.Count + 1; j++)
            {
                for (int i = 1; i <= 6; i++)
                {
                    ws.Cells[j, i] = tablaHistorial.Rows[j - 2].Cells[i - 1].Value;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string actualizar = "Activo = 1";
                if (db.Actualizar("InventarioProducto", actualizar, "IdProducto =" + dgv_id))
                {
                    MessageBox.Show("El producto ahora esta activo!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.cargarDatos("SELECT InventarioProducto.IdProducto, InventarioProducto.Nom_Producto as 'Producto', InventarioProducto.Precio, InventarioProducto.Cantidad, Categoria.Categoria, InventarioProducto.Activo FROM InventarioProducto inner join Categoria on InventarioProducto.IdCategoria=Categoria.IdCategoria", tablaHistorial);
                }
                else
                {
                    MessageBox.Show("Error al activar producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione primero un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tablaHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cada variable tendra el valor de la fila seleccionada con sus celdas
            dgv_id = Convert.ToString((Int32)tablaHistorial.Rows[e.RowIndex].Cells[0].Value);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBuscando = txtNombre.Text.ToString(); //Convertir valor del txt a cadena de texto
            BuscarProducto(valorBuscando); //Llamar al metodo y pasarle el parametro

        }

        public void BuscarProducto(string nombre)
        {
            SqlCommand cmd = new SqlCommand("SELECT InventarioProducto.IdProducto, InventarioProducto.Nom_Producto as 'Producto', InventarioProducto.Precio, InventarioProducto.Cantidad, Categoria.Categoria, InventarioProducto.Activo FROM InventarioProducto inner join Categoria on InventarioProducto.IdCategoria=Categoria.IdCategoria where InventarioProducto.Nom_Producto like '%" + nombre + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Buscar Producto")
            {
                txtNombre.Text = "";

                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Buscar Producto";

                txtNombre.ForeColor = Color.DarkGray;
            }
        }

        private void HistorialProductoFinal_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
