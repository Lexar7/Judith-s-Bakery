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
    public partial class ModificarEmpleado : Form
    {
        DataBase db = new DataBase();
        Empleados emp = new Empleados();
        Encriptar_Desencriptar enc = new Encriptar_Desencriptar();
        Validaciones val = new Validaciones();
        int activo;
        public ModificarEmpleado()
        {
            InitializeComponent();
        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {
            verImagen(pictureBox1, Convert.ToInt32(lb_numeroID.Text));
        }

        //METODO PARA ACTUALIZAR IMAGEN
        public string actualizarImagen(int id, PictureBox pbImagen)
        {
            string mensaje = "Se inserto la imagen";
            try
            {
                SqlCommand cmd = new SqlCommand("Update FotoEmpleado set Foto = @Imagen where IdEmpleado = @id", DataBase.Conexion());
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
                MessageBox.Show("No se pudo consultar la imagen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            actualizarImagen(Convert.ToInt32(lb_numeroID.Text), pictureBox1);

            try
            {
                if (ValidarCampos())
                {
                    //MODIGICAR EMPLEADO, SOLO ES NECESARIO CAMBIAR EL COMANDO PARA USARLO EN OTRA TABLA Y LISTO
                    //Escribimos los campos que queremos modificar
                    string actualizar = "Nombre= '" + txtNombre.Text + "', Direccion = '" + txtDireccion.Text + "', Email = '" + txtEmail.Text + "', Telefono = '" + txtTelefono.Text + "', Sexo = '" + cb_sexo.Text + "', DUI = '" + txtDUI.Text + "', NIT = '" + txtNIT.Text + "', Sueldo = '" + txtSueldo.Text + "', Usuario = '" + txtUser.Text + "', Contraseña = '" + enc.EncryptKey(tb_contraseña.Text) + "', Cargo = '" + cb_cargo.Text + "', Activo = '" + obtenerEstado() + "'";
                    //le pasamos los parametros de nuestro metodo Actualizar que se encuentra en la clase DataBase
                    if (db.Actualizar("Empleado", actualizar, "IdEmpleado =" + lb_numeroID.Text))
                    {

                        MessageBox.Show("Empleado actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        emp.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo modificar el empleado, seleccione Cancelar y vuelva a intentarlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            emp.Show();
        }

        private void tb_contraseña_Enter(object sender, EventArgs e)
        {
            if (tb_contraseña.Text == "Contraseña")
            {
                tb_contraseña.Text = "";
                tb_contraseña.ForeColor = Color.Black;
                tb_contraseña.isPassword = true;
            }
        }

        private void tb_contraseña_Leave(object sender, EventArgs e)
        {
            if (tb_contraseña.Text == "")
            {
                tb_contraseña.Text = "Contraseña";
                tb_contraseña.ForeColor = Color.Gray;
                tb_contraseña.isPassword = false;
            }
        }

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
                lblFormato.Visible = false;
                lblCorrecto.Visible = false;
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
                lbFormato2.Visible = false;
                lbCorrecto2.Visible = false;
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

        private void ModificarEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {
                this.Close();
            }
        }
    }
}
