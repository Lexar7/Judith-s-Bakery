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

namespace Judith_s_Bakery.ControlUsuario
{
    public partial class Page_Empleados : UserControl
    {
        DataBase db = new DataBase();
        Validaciones val = new Validaciones();

        public Page_Empleados()
        {
            InitializeComponent();
        }

        private void bt_usuarios_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            emp.Show();
        }

        private void bt_usuarios_MouseEnter(object sender, EventArgs e)
        {
            lbUsuarios.ForeColor = Color.Orange;
        }

        private void bt_usuarios_MouseLeave(object sender, EventArgs e)
        {
            lbUsuarios.ForeColor = Color.Black;
        }
        private void btnHistorial_MouseEnter(object sender, EventArgs e)
        {
            lbHistorial.ForeColor = Color.Orange;
        }
        private void btnHistorial_MouseLeave(object sender, EventArgs e)
        {
            lbHistorial.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString();
        }


        public void traerEmpleado(int id)
        {
            try
            {
                //Vamos a traer el Id y nombre del empleado para saber quien es
                SqlCommand cmd = new SqlCommand("Select IdEmpleado, Nombre from Empleado WHERE IdEmpleado = @id ", DataBase.Conexion());
                cmd.Parameters.AddWithValue("id", id); //Igualamos id con el parametro IdEmpleado
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1) //Si es igual a 1 es porque existen filas en la tabla
                {
                    MessageBox.Show("Usted es el empleado "+ dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Id de empleado incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DataBase.Conexion().Close(); //Cerramos conexion con la base de datos
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                verImagen(pictureBox2, Convert.ToInt32(txtId.Text));
                traerEmpleado(Convert.ToInt32(txtId.Text));
                //AGREGAR ASISTENCIA, SOLO ES NECESARIO CAMBIAR EL COMANDO PARA USARLO EN OTRA TABLA Y LISTO
                string agregar = "insert into Asistencia values( '" + Convert.ToInt32(txtId.Text) + "', '" + DateTime.Now.ToString("dd/MM/yyyy") + "', '" + DateTime.Now.ToLongTimeString() + "', '')";
                //llamamos a la clase DataBase con el metodo Insertar y le pasamos el parametro
                if (db.Insertar(agregar))
                {
                    MessageBox.Show("Su hora de entrada es: " + DateTime.Now.ToLongTimeString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtId.Text = "";
                    pictureBox2.Image = Properties.Resources.multiple_users_silhouette;
                }
                else
                {
                    MessageBox.Show("No se registro su hora de entrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtId.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha guardado nada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            try
            {
                verImagen(pictureBox2, Convert.ToInt32(txtId.Text));
                traerEmpleado(Convert.ToInt32(txtId.Text));
                //MODIGICAR ASISTENCIA, SOLO ES NECESARIO CAMBIAR EL COMANDO PARA USARLO EN OTRA TABLA Y LISTO
                //Escribimos los campos que queremos modificar
                string actualizar = "Salida = '" + DateTime.Now.ToLongTimeString() + "' ";
                //le pasamos los parametros de nuestro metodo Actualizar que se encuentra en la clase DataBase
                if (db.Actualizar("Asistencia", actualizar, "Fecha = '" + DateTime.Now.ToString("dd/MM/yyyy") + "' and IdEmpleado = '" + Convert.ToInt32(txtId.Text) + "' "))
                {
                    MessageBox.Show("Su hora de salida es: " + DateTime.Now.ToLongTimeString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtId.Text = "";
                    pictureBox2.Image = Properties.Resources.multiple_users_silhouette;
                }
                else
                {
                    MessageBox.Show("No se guardar su hora de salida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtId.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha guardado nada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialEntradaSalida historial = new HistorialEntradaSalida();
            historial.Show();
        }

        private void Page_Empleados_Load(object sender, EventArgs e)
        {
            
        }

        //METODO PARA VER LA IMAGEN 
        public void verImagen(PictureBox pbFoto, int id)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Foto from FotoEmpleado where IdEmpleado = '" + id + "'", DataBase.Conexion());
                DataSet ds = new DataSet();
                da.Fill(ds, "FotoEmpleado");
                byte[] datos = new byte[0];
                DataRow dr = ds.Tables["FotoEmpleado"].Rows[0];
                datos = (byte[])dr["Foto"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception)
            {
                MessageBox.Show("Este empleado no tiene fotografia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosEnteros(e);
        }
    }
}
