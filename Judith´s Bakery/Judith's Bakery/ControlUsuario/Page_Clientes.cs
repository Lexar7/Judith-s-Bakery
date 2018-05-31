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
using Microsoft.Office.Interop.Excel;



namespace Judith_s_Bakery
{
    public partial class Page_Clientes : UserControl
    {
        string dgv_id, dgv_nombre, dgv_direccion, dgv_telefono, dgv_dui, dgv_sexo, dgv_email;
        DataBase da = new DataBase();
        Validaciones val = new Validaciones();

        public Page_Clientes()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
       // Page_Clientes pc = new Page_Clientes();
        private void tb_buscar_Enter_1(object sender, EventArgs e)
        {
            if (tb_buscar.Text == "Buscar Cliente")
            {
                tb_buscar.Text = "";

                tb_buscar.ForeColor = Color.Black;
            }
        }

        private void tb_buscar_Leave_1(object sender, EventArgs e)
        {
            if (tb_buscar.Text == "")
            {
                tb_buscar.Text = "Buscar Cliente";

                tb_buscar.ForeColor = Color.DarkGray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lb_ayuda.Visible = true;
        }

        private void bt_clientes_Click(object sender, EventArgs e)
        {
            CrearModificarCliente cli = new CrearModificarCliente();
            cli.Show();
        }

        private void TablaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cada variable tendra el valor de la fila seleccionada con sus celdas
            dgv_id = Convert.ToString((Int32)TablaCliente.Rows[e.RowIndex].Cells[0].Value);
            dgv_nombre = (string)TablaCliente.Rows[e.RowIndex].Cells[1].Value;
            dgv_direccion = (string)TablaCliente.Rows[e.RowIndex].Cells[2].Value;
            dgv_telefono = (string)TablaCliente.Rows[e.RowIndex].Cells[3].Value;
            dgv_dui = (string)TablaCliente.Rows[e.RowIndex].Cells[4].Value;
            dgv_sexo = (string)TablaCliente.Rows[e.RowIndex].Cells[5].Value;
            dgv_email = (string)TablaCliente.Rows[e.RowIndex].Cells[6].Value;
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }

        private void Page_Clientes_Load(object sender, EventArgs e)
        {
            //Cargamos los datos a la tabla llamando nuestro metodo cargarDatos de nuestra clase DataBase
            da.cargarDatos("Select * From Cliente", TablaCliente);
        }

        private void Page_Clientes_Load_1(object sender, EventArgs e)
        {
            db.cargarDatos("Select * From Cliente", TablaCliente);
        }

        private void tb_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Boton modificar, creamos el contructor para poder llamar al Form CrearCliente
                //y mandamos a llamar los controles de nuestro Form CrearCliente
                //ponemos cuales queremos que sean visibles y cuales no
                CrearModificarCliente cli = new CrearModificarCliente();
                //OJO LOS CONTROLES DEL FORM CrearProveedor DEBEN DE ESTAR EN PUBLICO Y NO EN PRIVADO
                //PARA PODERLOS USAR EN OTROS FORMULARIOS
                cli.lb_id.Visible = true;
                cli.lb_numeroID.Visible = true;
                cli.bt_modificar.Visible = true;
                cli.lb_titulo.Text = "Modificar Cliente";
                //cu.cb_dia.Visible = false;
                //cu.cb_mes.Visible = false;
                //cu.cb_año.Visible = false;
                //cu.label2.Visible = false;
                cli.bt_crear.Visible = false;


                //Le mandamos a los controles del Form CrearProveedor el valor de la fila seleccionada con su contenido en cada celda
                cli.lb_numeroID.Text = dgv_id;
                cli.txtNombre.Text = dgv_nombre;
                cli.txtDireccion.Text = dgv_direccion;
                cli.txtTelefono.Text = dgv_telefono;
                cli.txtDUI.Text = dgv_dui;
                cli.cb_sexo.Text = dgv_sexo;
                cli.txtEmail.Text = dgv_email;
                cli.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione primero una celda de algún Cliente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            db.cargarDatos("Select * From Cliente", TablaCliente);
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al cliente " + dgv_nombre + "?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //ELIMINAR, SOLO SE NECESITAN CAMBIAR LOS PARAMETROS PARA USAR EN OTRA TABLA
                    // Le pasamos la varibale dgv_id para que tome el IdCliente de la fila seleccionada
                    if (db.Eliminar("Cliente", "IdCliente = " + dgv_id))
                    {
                        MessageBox.Show("Cliente eliminado de la base de Datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Volvemos a cargar los datos a la tabla
                        db.cargarDatos("Select * From Cliente", TablaCliente);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione primero una celda de algún Cliente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        public void BuscarCliente(string nombre)
        {
            SqlCommand cmd = new SqlCommand("select IdCliente, Nombre, Direccion, Telefono, DUI, Sexo, Email from Cliente where Nombre like '%" + nombre + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            TablaCliente.DataSource = dt;
        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string valorBuscando = tb_buscar.Text.ToString(); //Convertir valor del txt a cadena de texto
            BuscarCliente(valorBuscando); //Llamar al metodo y pasarle el parametro
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
             //Referencia Microsoft.Office.Interop.Excel en Visual Studio 2015
            //C:\Windows\assembly\GAC_MSIL\Microsoft.Office.Interop.Excel\15.0.0.0__71e9bce111e9429c for Visual Studio 2015

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            Range rng = ws.get_Range("A1:G1");
            rng.Interior.Color = XlRgbColor.rgbLightBlue;


            ws.Cells[1, 1] = "IdCliente";
            ws.Cells[1, 2] = "Nombre";
            ws.Cells[1, 3] = "Direccion";
            ws.Cells[1, 4] = "Telefono";
            ws.Cells[1, 5] = "DUI";
            ws.Cells[1, 6] = "Sexo";
            ws.Cells[1, 7] = "Email";
         
         
            for (int j = 2; j <= TablaCliente.Rows.Count+1; j++)
            {
                for (int i = 1; i <= 7; i++)
                {
                    ws.Cells[j, i] = TablaCliente.Rows[j - 2].Cells[i - 1].Value;
                }

            }
        }
     }
 
}
