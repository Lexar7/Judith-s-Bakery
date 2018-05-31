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
using System.Text.RegularExpressions;

namespace Judith_s_Bakery.Forms
{
    public partial class CrearEmpleado : Form
    {
        DataBase db = new DataBase();
        Empleados emp = new Empleados();
        Encriptar_Desencriptar enc = new Encriptar_Desencriptar();
        Validaciones val = new Validaciones();
        int activo;
        public CrearEmpleado()
        {
            InitializeComponent();
            //cb_año.Text = "Año";
            //tener los años en el cb_año hasta la actualidad
            //cb_año.DataSource = Enumerable.Range(1910, DateTime.Now.Year - 1910 + 1).ToList();
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    if (txtSueldo.Text == "")
                    {
                        txtSueldo.Text = 0.00.ToString();
                        if (db.SiExiste("Empleado", "DUI", txtDUI.Text) == false)
                        {
                            MessageBox.Show("Ya existe un empleado con el mismo DUI, por favor ingrese un empleado diferente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //AGREGAR EMPLEADO, SOLO ES NECESARIO CAMBIAR EL COMANDO PARA USARLOS EN OTRA TABLA Y LISTO
                            string agregar = "insert into Empleado values( '" + txtNombre.Text + "', '" + txtDireccion.Text + "', '" + txtEmail.Text + "', '" + txtTelefono.Text + "','" + cb_sexo.Text + "','" + txtDUI.Text + "','" + txtNIT.Text + "','" + txtSueldo.Text + "', '" + txtUser.Text + "','" + enc.EncryptKey(tb_contraseña.Text) + "', '" + cb_cargo.Text + "', '" + obtenerEstado() + "')";
                            //llamamos a la clase DataBase con el metodo Insertar y le pasamos el parametro
                            if (db.Insertar(agregar))
                            {
                                insertarImagen(traerIDventa(), pictureBox1);
                                MessageBox.Show("Empleado agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                emp.Show();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo agregar el empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        //AGREGAR EMPLEADO, SOLO ES NECESARIO CAMBIAR EL COMANDO PARA USARLO EN OTRA TABLA Y LISTO
                        string agregar = "insert into Empleado values( '" + txtNombre.Text + "', '" + txtDireccion.Text + "', '" + txtEmail.Text + "', '" + txtTelefono.Text + "','" + cb_sexo.Text + "','" + txtDUI.Text + "','" + txtNIT.Text + "','" + txtSueldo.Text + "', '" + txtUser.Text + "','" + enc.EncryptKey(tb_contraseña.Text) + "', '" + cb_cargo.Text + "', '" + obtenerEstado() + "')";
                        //llamamos a la clase DataBase con el metodo Insertar y le pasamos el parametro
                        if (db.Insertar(agregar))
                        {
                            insertarImagen(traerIDventa(), pictureBox1);
                            MessageBox.Show("Empleado agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            emp.Show();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {

                }
            }                             
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el empleado, seleccione Cancelar y vuelva a intentarlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int obtenerEstado()
        {
            if (cb_activo.Text=="Activo")
            {
                activo = 1;
            }
            else
            {
                activo = 0;
            }
            return Convert.ToInt32(activo);
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        public string insertarImagen(int id, PictureBox pbImagen)
        {
            string mensaje = "Se inserto la imagen";
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into FotoEmpleado(IdEmpleado, Foto) values(@id,@Imagen)", DataBase.Conexion());
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@Imagen", SqlDbType.Image);

                cmd.Parameters["@id"].Value = id;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mensaje = "No se inserto la imagen: " + ex.ToString();
            }
            return mensaje;
        }

        //TRAER EL ID DE EMPLEADO
        public int traerIDventa()
        {
            //Vamos a traer el Id, tomamos el ultimo valor agregado
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdEmpleado FROM Empleado ORDER BY IdEmpleado DESC", DataBase.Conexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            emp.Show();
        }

        private void tb_contraseña_Enter_1(object sender, EventArgs e)
        {
            if (tb_contraseña.Text == "Contraseña")
            {
                tb_contraseña.Text = "";
                tb_contraseña.ForeColor = Color.Black;
                tb_contraseña.isPassword = true;
            }
        }

        private void tb_contraseña_Leave_1(object sender, EventArgs e)
        {
            if (tb_contraseña.Text == "")
            {
                tb_contraseña.Text = "Contraseña";
                tb_contraseña.ForeColor = Color.Gray;
                tb_contraseña.isPassword = false;
            }
        }


        //VALIDACIONES
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);   
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Numeros(e);
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Numeros(e);
        }

        private void txtNIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Numeros(e);
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosPrecios(e);
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Length > 9)
            {
                MessageBox.Show("No puede ingresar más de 9 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefono.Focus();
            }        
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (val.validarEmail(txtEmail.Text))
            {

            }
            else
            {
                MessageBox.Show("Correo no valido, el correo debe poseer un formato: nombre@dominio.com. "
                    + "Por favor ingrese un correo valido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.LineIdleColor = Color.Red;
            }
        }

        private void txtDUI_Leave(object sender, EventArgs e)
        {
            string sentencia = "^[0-9]{8}-[0-9]{1}$";
            if (Regex.IsMatch(txtDUI.Text, sentencia))
            {

            }
            else
            {
                MessageBox.Show("Debe de ingresar un formato de DUI correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDUI.LineIdleColor = Color.Red;
            }
        }
        private void txtNIT_Leave(object sender, EventArgs e)
        {
            string sentencia = "^[0-9]{4}-[0-9]{6}-[0-9]{3}-[0-9]{1}$";
            if (Regex.IsMatch(txtNIT.Text, sentencia))
            {

            }
            else
            {
                MessageBox.Show("Debe de ingresar un formato de NIT correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNIT.LineIdleColor = Color.Red;
            }
        }
        public bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                txtNombre.LineIdleColor = Color.Red;
                MessageBox.Show("Debe de escribir el nombre del empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtTelefono.Text == "")
            {
                ok = false;
                txtTelefono.LineIdleColor = Color.Red;
                MessageBox.Show("Escriba un teléfono de contacto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cb_sexo.Text == "Sexo")
            {
                ok = false;
                MessageBox.Show("Debe poner un género en sexo Masculino (M) o Femenino (F)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cb_cargo.Text == "Cargo")
            {
                ok = false;
                MessageBox.Show("Debe poner poner un cargo Administrador o Empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ok;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debes de escribir el nombre del empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.LineIdleColor = Color.Red;
            }
        }
        private void txtDUI_Enter(object sender, EventArgs e)
        {
            lblFormato.Visible = true;
            lblCorrecto.Visible = true;
            lblFormato.Text = "Formato correcto a ingresar de DUI:";
            lblCorrecto.Text = "########-#";
        }

        private void txtNIT_Enter(object sender, EventArgs e)
        {
            lbFormato2.Visible = true;
            lbCorrecto2.Visible = true;
            lbFormato2.Text = "Formato correcto a ingresar de NIT:";
            lbCorrecto2.Text = "####-######-###-#";
        }

        private void CrearEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
