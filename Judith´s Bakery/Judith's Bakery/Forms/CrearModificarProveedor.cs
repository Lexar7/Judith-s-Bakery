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
    public partial class CrearModificarProveedor : Form
    {

        DataBase db = new DataBase();
        Page_Proveedor proveedor = new Page_Proveedor();
        Validaciones val = new Validaciones();
        public CrearModificarProveedor()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_crear_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    if (db.SiExiste("Proveedor", "NIT", txtNIT.Text) == false)
                    {
                        MessageBox.Show("Ya existe un proveedor con el mismo NIT, por favor ingrese un proveedor diferente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //AGREGAR PROVEEDOR, SOLO ES NECESARIO CAMBIAR EL COMANDO PARA USARLOS EN OTRA TABLA Y LISTO
                        string agregar = "insert into Proveedor values( '" + txtNombre.Text + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text + "','" + txtFax.Text + "','" + txtNIT.Text + "','" + txtNumRegistro.Text + "', '" + txtServicio.Text + "','" + txtEmail.Text + "')";
                        //llamamos a la clase DataBase con el metodo Insertar y le pasamos el parametro
                        if (db.Insertar(agregar))
                        {
                            MessageBox.Show("Proveedor agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el proveedor, seleccione Cancelar y vuelva a intentarlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void CrearModificarProveedor_Load(object sender, EventArgs e)
        {
         
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    //MODIFICAR PROVEEDOR, SOLO ES NECESARIO CAMBIAR EL COMANDO PARA USARLO EN OTRA TABLA Y LISTO
                    //Escribimos los campos que queremos modificar
                    string actualizar = "Nombre= '" + txtNombre.Text + "', Direccion = '" + txtDireccion.Text + "', Telefono = '" + txtTelefono.Text + "', FAX = '" + txtFax.Text + "', NIT = '" + txtNIT.Text + "', Num_Registro = '" + txtNumRegistro.Text + "', Servicio = '" + txtServicio.Text + "', Email = '" + txtEmail.Text + "'";
                    //le pasamos los parametros de nuestro metodo Actualizar que se encuentra en la clase DataBase
                    if (db.Actualizar("Proveedor", actualizar, "IdProveedor =" + lb_numeroID.Text))
                    {
                        MessageBox.Show("Proveedor actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo modificar el proveedor, seleccione Cancelar y vuelva a intentarlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debes de escribir el nombre del proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.LineIdleColor = Color.Red;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Length > 9)
            {
                MessageBox.Show("No puede ingresar más de 9 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefono.Focus();
            }
        }

        private void txtFax_Leave(object sender, EventArgs e)
        {
            if (txtFax.Text.Length > 9)
            {
                MessageBox.Show("No puede ingresar más de 9 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFax.Focus();
            }
        }

        private void txtNIT_Leave(object sender, EventArgs e)
        {
            if (txtNIT.Text.Length > 17)
            {
                MessageBox.Show("No puede ingresar más de 17 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNIT.Focus();
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Numeros(e);
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Numeros(e);
        }

        private void txtNumRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Numeros(e);
        }

        public bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                txtNombre.LineIdleColor = Color.Red;
                MessageBox.Show("Debe de escribir el nombre del proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtDireccion.Text == "")
            {
                ok = false;
                txtDireccion.LineIdleColor = Color.Red;
                MessageBox.Show("Escriba la dirección del proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtTelefono.Text == "")
            {
                ok = false;
                txtTelefono.LineIdleColor = Color.Red;
                MessageBox.Show("Escriba un teléfono de contacto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtNIT.Text == "")
            {
                ok = false;
                txtNIT.LineIdleColor = Color.Red;
                MessageBox.Show("Escriba el NIT del proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtNumRegistro.Text == "")
            {
                ok = false;
                txtNumRegistro.LineIdleColor = Color.Red;
                MessageBox.Show("Escriba el número de registro del proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }

        private void CrearModificarProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }          
}
