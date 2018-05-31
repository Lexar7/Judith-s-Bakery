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
    public partial class HistorialEntradaSalida : Form
    {
        DataBase db = new DataBase();
        public HistorialEntradaSalida()
        {
            InitializeComponent();
        }

        private void HistorialEntradaSalida_Load(object sender, EventArgs e)
        {
            //Cargamos los datos a la tabla llamando nuestro metodo cargarDatos de nuestra clase DataBase
            //db.cargarDatos("SELECT Empleado.Nombre, Asistencia.Fecha, Asistencia.Entrada, Asistencia.Salida FROM Empleado inner join Asistencia ON Empleado.IdEmpleado = Asistencia.IdEmpleado ORDER BY Asistencia.Fecha asc, Asistencia.Entrada asc, Asistencia.Salida asc", tablaHistorial);
            db.cargarDatos("SELECT Empleado.Nombre,  Asistencia.Fecha, Asistencia.Entrada, Asistencia.Salida FROM Empleado inner join Asistencia ON Empleado.IdEmpleado = Asistencia.IdEmpleado ORDER BY Asistencia.Fecha DESC", tablaHistorial);

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; // Minimiza la ventana
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Buscar Empleado")
            {
                txtNombre.Text = "";
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Buscar Empleado";
            }
        }

        private void txtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "dd/mm/aaaa")
            {
                txtFecha.Text = "";
            }
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "dd/mm/aaaa";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbNombre.Checked == false && rbFecha.Checked==false)
            {
                MessageBox.Show("Seleccione primero lo que desea buscar, nombre o fecha", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rbNombre.Checked == true)
                {
                    BuscarNombreEmpleado(txtNombre.Text.ToString()); //Llamar al metodo y pasarle el parametro
                }
                else if (rbFecha.Checked == true)
                {
                    BuscarXFecha(txtFecha.Text.ToString());
                }
            }
        }

        public void BuscarNombreEmpleado(string nombre)
        {
            SqlCommand cmd = new SqlCommand("SELECT Empleado.Nombre, Asistencia.Fecha, Asistencia.Entrada, Asistencia.Salida FROM Empleado INNER JOIN Asistencia ON Empleado.IdEmpleado = Asistencia.IdEmpleado where Empleado.Nombre like '%" + nombre + "%'" , DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }
        public void BuscarXFecha(string fecha)
        {
            SqlCommand cmd = new SqlCommand("SELECT Empleado.Nombre, Asistencia.Fecha, Asistencia.Entrada, Asistencia.Salida FROM Empleado INNER JOIN Asistencia ON Empleado.IdEmpleado = Asistencia.IdEmpleado where Asistencia.Fecha = '" + fecha + "' ", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }

        private void pbAyuda_Click(object sender, EventArgs e)
        {
            lb_ayuda.Visible = true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //Referencia Microsoft.Office.Interop.Excel en Visual Studio 2015
            //C:\Windows\assembly\GAC_MSIL\Microsoft.Office.Interop.Excel\15.0.0.0__71e9bce111e9429c for Visual Studio 2015

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            Range rng = ws.get_Range("A1:M1");
            rng.Interior.Color = XlRgbColor.rgbLightBlue;


            ws.Cells[1, 1] = "Nombre";
            ws.Cells[1, 2] = "Fecha";
            ws.Cells[1, 3] = "Entrada";
            ws.Cells[1, 4] = "Salida";

            for (int j = 2; j <= tablaHistorial.Rows.Count + 1; j++)
            {
                for (int i = 1; i <= 4; i++)
                {
                    ws.Cells[j, i] = tablaHistorial.Rows[j - 2].Cells[i - 1].Value;
                }

            }
        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            //Cargamos los datos a la tabla llamando nuestro metodo cargarDatos de nuestra clase DataBase
            db.cargarDatos("SELECT Empleado.Nombre, Asistencia.Fecha, Asistencia.Entrada, Asistencia.Salida FROM Empleado inner join Asistencia ON Empleado.IdEmpleado = Asistencia.IdEmpleado ORDER BY Asistencia.Fecha DESC", tablaHistorial);
            txtNombre.Text = "Buscar Empleado";
            txtFecha.Text = "dd/mm/aaaa";

        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HistorialEntradaSalida_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
