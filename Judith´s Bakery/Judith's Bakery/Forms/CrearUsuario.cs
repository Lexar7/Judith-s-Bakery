using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Judith_s_Bakery.Forms
{
   
    public partial class CrearUsuario : Form
    {
        DataBase db = new DataBase();
        Usuarios user = new Usuarios();
        Encriptar_Desencriptar enc = new Encriptar_Desencriptar();
        

        public CrearUsuario()
        {
            InitializeComponent();
            cb_año.Text = "Año";
            //tener los años en el cb_año hasta la actualidad
            cb_año.DataSource = Enumerable.Range(1910, DateTime.Now.Year - 1910 + 1).ToList();
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

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

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into Usuarios values( '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDireccion.Text + "', '" + cb_dia.Text + "-" + cb_mes.Text + "-" + cb_año.Text + "', " + txtTelefono.Text + ", '" + txtUser.Text + "','" + enc.EncryptKey(tb_contraseña.Text) + "', '" + cb_cargo.Text + "')";
            if (db.Insertar(agregar))//llamamos a la clase DataBase con el metodo Insertar y le pasamos el parametro
            {
                MessageBox.Show("Usuario agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);             
                this.Close();
                user.Show();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            user.Show();
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            //Escribimos los campos que queremos modificar
            string actualizar = "Nombre= '" + txtNombre.Text + "', Apellido = '" + txtApellido.Text + "', Direccion = '" + txtDireccion.Text + "', Telefono = '" + txtTelefono.Text + "', Usuario='" + txtUser.Text + "', Contraseña= '" + enc.EncryptKey(tb_contraseña.Text) + "', Cargo='" + cb_cargo.Text + "'";
            if (db.Actualizar("Usuarios", actualizar, "IdUsuario =" + lb_numeroID.Text))//le pasamos los parametros de nuestro metodo Actualizar que se encuentra en la clase DataBase
            {
                MessageBox.Show("Usuario actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                user.Show();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
