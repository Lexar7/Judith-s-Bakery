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
    public partial class Page_Proveedor : UserControl
    {
        DataBase db = new DataBase();
        Validaciones val = new Validaciones();
        string dgv_id, dgv_nombre, dgv_direccion, dgv_telefono, dgv_NumRegistro, dgv_email, dgv_FAX, dgv_NIT, dgv_servicio ;
        public Page_Proveedor()
        {
            InitializeComponent();
        }
              
        private void Page_Clientes_Load(object sender, EventArgs e)
        {
            //Cargamos los datos a la tabla llamando nuestro metodo cargarDatos de nuestra clase DataBase
            db.cargarDatos("Select * From Proveedor", TablaProveedor);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lb_ayuda.Visible = true;
        }

        private void lb_ayuda_Click(object sender, EventArgs e)
        {

        }

        private void bt_usuarios_Click(object sender, EventArgs e)
        {
            CrearModificarProveedor cp = new CrearModificarProveedor();
            cp.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string valorBuscando = tb_buscar.Text.ToString(); //Convertir valor del txt a cadena de texto
            BuscarProveedor(valorBuscando); //Llamar al metodo y pasarle el parametro
        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            db.cargarDatos("Select * From Proveedor", TablaProveedor);
        }

        private void tb_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        public void BuscarProveedor(string nombre)
        {
            SqlCommand cmd = new SqlCommand("select IdProveedor, Nombre, Direccion, Telefono, FAX, NIT, Num_Registro, Servicio, Email from Proveedor where Nombre like '%" + nombre + "%'", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            TablaProveedor.DataSource = dt;
        }

        private void tb_buscar_Enter(object sender, EventArgs e)
        {
            if (tb_buscar.Text == "Buscar Proveedor")
            {
                tb_buscar.Text = "";

                tb_buscar.ForeColor = Color.Black;
            }
        }

        private void tb_buscar_Leave(object sender, EventArgs e)
        {
            if (tb_buscar.Text == "")
            {
                tb_buscar.Text = "Buscar Proveedor";

                tb_buscar.ForeColor = Color.DarkGray;
            }
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            try
            {              
                //Boton modificar, creamos el contructor para poder llamar al Form CrearProveedor
                //y mandamos a llamar los controles de nuestro Form CrearProveedor
                //ponemos cuales queremos que sean visibles y cuales no
                CrearModificarProveedor cp = new CrearModificarProveedor();
                //OJO LOS CONTROLES DEL FORM CrearProveedor DEBEN DE ESTAR EN PUBLICO Y NO EN PRIVADO
                //PARA PODERLOS USAR EN OTROS FORMULARIOS
                cp.lb_id.Visible = true;
                cp.lb_numeroID.Visible = true;
                cp.bt_modificar.Visible = true;
                cp.lb_titulo.Text = "Modificar Proveedor";
                //cu.cb_dia.Visible = false;
                //cu.cb_mes.Visible = false;
                //cu.cb_año.Visible = false;
                //cu.label2.Visible = false;
                cp.bt_crear.Visible = false;


                //Le mandamos a los controles del Form CrearProveedor el valor de la fila seleccionada con su contenido en cada celda
                cp.lb_numeroID.Text = dgv_id;
                cp.txtNombre.Text = dgv_nombre;
                cp.txtDireccion.Text = dgv_direccion;
                cp.txtTelefono.Text = dgv_telefono;             
                cp.txtFax.Text = dgv_FAX;
                cp.txtNIT.Text = dgv_NIT;
                cp.txtNumRegistro.Text = dgv_NumRegistro;
                cp.txtServicio.Text = dgv_servicio;
                cp.txtEmail.Text = dgv_email;
                cp.Show();
                            
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione primero una celda de algún Proveedor.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TablaProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cada variable tendra el valor de la fila seleccionada con sus celdas
            dgv_id = Convert.ToString((Int32)TablaProveedor.Rows[e.RowIndex].Cells[0].Value);
            dgv_nombre = (string)TablaProveedor.Rows[e.RowIndex].Cells[1].Value;
            dgv_direccion = (string)TablaProveedor.Rows[e.RowIndex].Cells[2].Value;
            dgv_telefono = (string)TablaProveedor.Rows[e.RowIndex].Cells[3].Value;
            dgv_FAX = (string)TablaProveedor.Rows[e.RowIndex].Cells[4].Value;
            dgv_NIT = (string)TablaProveedor.Rows[e.RowIndex].Cells[5].Value;
            dgv_NumRegistro = (string)TablaProveedor.Rows[e.RowIndex].Cells[6].Value;
            dgv_servicio = (string)TablaProveedor.Rows[e.RowIndex].Cells[7].Value;
            dgv_email = (string)TablaProveedor.Rows[e.RowIndex].Cells[8].Value;
        }

        private void TablaProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al proveedor " + dgv_nombre + "?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //ELIMINAR, SOLO SE NECESITAN CAMBIAR LOS PARAMETROS PARA USAR EN OTRA TABLA
                    // Le pasamos la varibale dgv_id para que tome el IdEmpleado de la fila seleccionada
                    if (db.Eliminar("Proveedor", "IdProveedor = " + dgv_id))
                    {
                        MessageBox.Show("Proveedor eliminado de la base de Datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Volvemos a cargar los datos a la tabla
                        db.cargarDatos("Select * From Proveedor", TablaProveedor);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione primero una celda de algún Proveedor.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             //Referencia Microsoft.Office.Interop.Excel en Visual Studio 2015
            //C:\Windows\assembly\GAC_MSIL\Microsoft.Office.Interop.Excel\15.0.0.0__71e9bce111e9429c for Visual Studio 2015

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            Range rng = ws.get_Range("A1:I1");
            rng.Interior.Color = XlRgbColor.rgbLightBlue;


            ws.Cells[1, 1] = "IdProveedor";
            ws.Cells[1, 2] = "Nombre";
            ws.Cells[1, 3] = "Direccion";
            ws.Cells[1, 4] = "Telefono";
            ws.Cells[1, 5] = "FAX";
            ws.Cells[1, 6] = "NIT";
            ws.Cells[1, 7] = "Num_Registro";
            ws.Cells[1, 8] = "Servicio";
            ws.Cells[1, 9] = "Email";
           


            for (int j = 2; j <= TablaProveedor.Rows.Count+1; j++)
            {
                for (int i = 1; i <= 9; i++)
                {
                    ws.Cells[j, i] = TablaProveedor.Rows[j - 2].Cells[i - 1].Value;
                }

            }
        }

        private void Page_Proveedor_KeyUp(object sender, KeyEventArgs e)
        {

        }


        }
    }

