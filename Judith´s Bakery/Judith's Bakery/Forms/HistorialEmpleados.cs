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
    public partial class HistorialEmpleados : Form
    {
        DataBase db = new DataBase();
        Empleados emp = new Empleados();
        Validaciones val = new Validaciones();
        string dgv_id;
        public HistorialEmpleados()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            emp.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void HistorialEmpleados_Load(object sender, EventArgs e)
        {
            //Cargamos los datos a la tabla llamando nuestro metodo cargarDatos de nuestra clase DataBase
            db.cargarDatos("SELECT * FROM Empleado", tablaHistorial);

        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            db.cargarDatos("SELECT * FROM Empleado", tablaHistorial);
        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            emp.Show();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBuscando = txtEmpleado.Text.ToString(); //Convertir valor del txt a cadena de texto
            BuscarUser(valorBuscando); //Llamar al metodo y pasarle el parametro

        }

        public void BuscarUser(string nombre)
        {
            SqlCommand cmd = new SqlCommand("select IdEmpleado, Nombre, Direccion, Email, Telefono, Sexo, DUI, NIT, Sueldo, Usuario, Contraseña, Cargo, Activo from Empleado where Nombre like '%" + nombre + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            tablaHistorial.DataSource = dt;
        }

        private void rbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            db.cargarDatos("SELECT * FROM Empleado WHERE Activo = 1", tablaHistorial);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            db.cargarDatos("SELECT * FROM Empleado WHERE Activo = 0", tablaHistorial);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string actualizar = "Activo = 1";
                if (db.Actualizar("Empleado", actualizar, "IdEmpleado =" + dgv_id))
                {
                    MessageBox.Show("El empleados ahora esta activo!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.cargarDatos("SELECT * FROM Empleado", tablaHistorial);
                }
                else
                {
                    MessageBox.Show("Error al activar empleados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione primero un empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tablaHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cada variable tendra el valor de la fila seleccionada con sus celdas
            dgv_id = Convert.ToString((Int32)tablaHistorial.Rows[e.RowIndex].Cells[0].Value);

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

        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);   
        }

        private void txtEmpleado_Enter(object sender, EventArgs e)
        {
            if (txtEmpleado.Text == "Buscar Empleado")
            {
                txtEmpleado.Text = "";

                txtEmpleado.ForeColor = Color.Black;
            }
        }

        private void txtEmpleado_Leave(object sender, EventArgs e)
        {
            if (txtEmpleado.Text == "")
            {
                txtEmpleado.Text = "Buscar Empleado";

                txtEmpleado.ForeColor = Color.DarkGray;
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

            Range rng = ws.get_Range("A1:M1");
            rng.Interior.Color = XlRgbColor.rgbLightBlue;


            ws.Cells[1, 1] = "IdEmpleado";
            ws.Cells[1, 2] = "Nombre";
            ws.Cells[1, 3] = "Direccion";
            ws.Cells[1, 4] = "Email";
            ws.Cells[1, 5] = "Telefono";
            ws.Cells[1, 6] = "Sexo";
            ws.Cells[1, 7] = "DUI";
            ws.Cells[1, 8] = "NIT";
            ws.Cells[1, 9] = "Sueldo";
            ws.Cells[1, 10] = "Usuario";
            ws.Cells[1, 11] = "Contraseña";
            ws.Cells[1, 12] = "Cargo";
            ws.Cells[1, 13] = "Activo";

            for (int j = 2; j <= tablaHistorial.Rows.Count + 1; j++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    ws.Cells[j, i] = tablaHistorial.Rows[j - 2].Cells[i - 1].Value;
                }

            }
        }

        private void HistorialEmpleados_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    
    }
}
