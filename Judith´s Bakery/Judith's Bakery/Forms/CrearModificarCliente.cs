using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judith_s_Bakery.Forms
{
    public partial class CrearModificarCliente : Form
    {

        DataBase db = new DataBase();
        Validaciones val = new Validaciones();
        public CrearModificarCliente()
        {
            InitializeComponent();
        }

        private void bt_crear_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    if (db.SiExiste("Cliente", "DUI", txtDUI.Text) == false)
                    {
                        MessageBox.Show("Ya existe un cliente con el mismo DUI, por favor ingrese un cliente diferente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //AGREGAR CLIENTE, SOLO ES NECESARIO CAMBIAR EL COMANDO PARA USARLOS EN OTRA TABLA Y LISTO
                        string agregar = "insert into Cliente values( '" + txtNombre.Text + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text + "','" + txtDUI.Text + "','" + cb_sexo.Text + "','" + txtEmail.Text + "')";
                        //llamamos a la clase DataBase con el metodo Insertar y le pasamos el parametro
                        if (db.Insertar(agregar))
                        {
                            MessageBox.Show("Cliente agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {

                }                
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el cliente, seleccione Cancelar y vuelva a intentarlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
             try
            {
                if (ValidarCampos())
                {
                    //MODIFICAR PROVEEDOR, SOLO ES NECESARIO CAMBIAR EL COMANDO PARA USARLO EN OTRA TABLA Y LISTO
                    //Escribimos los campos que queremos modificar
                    string actualizar = "Nombre= '" + txtNombre.Text + "', Direccion = '" + txtDireccion.Text + "', Telefono = '" + txtTelefono.Text + "',  DUI = '" + txtDUI.Text + "', Sexo = '" + cb_sexo.Text + "', Email = '" + txtEmail.Text + "'";
                    //le pasamos los parametros de nuestro metodo Actualizar que se encuentra en la clase DataBase
                    if (db.Actualizar("Cliente", actualizar, "IdCliente =" + lb_numeroID.Text))
                    {
                        MessageBox.Show("Cliente actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debes de escribir el nombre del empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.LineIdleColor = Color.Red;
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
            if (txtDUI.Text.Length > 10)
            {
                MessageBox.Show("No puede ingresar más de 10 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDUI.Focus();
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

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
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

        public bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                txtNombre.LineIdleColor = Color.Red;
                MessageBox.Show("Debe de escribir el nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtTelefono.Text == "")
            {
                ok = false;
                txtTelefono.LineIdleColor = Color.Red;
                MessageBox.Show("Escriba un teléfono de contacto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }

        private void CrearModificarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
