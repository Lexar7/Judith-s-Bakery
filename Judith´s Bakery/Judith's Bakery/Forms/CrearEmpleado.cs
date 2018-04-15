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
   
    public partial class CrearEmpleado : Form
    {
        DataBase db = new DataBase();
        Empleados emp = new Empleados();
        Encriptar_Desencriptar enc = new Encriptar_Desencriptar();
        

        public CrearEmpleado()
        {
            InitializeComponent();
            //cb_año.Text = "Año";
            //tener los años en el cb_año hasta la actualidad
           //cb_año.DataSource = Enumerable.Range(1910, DateTime.Now.Year - 1910 + 1).ToList();
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

            string agregar = "insert into Empleado values( '" + txtNombre.Text + "', '" + txtDireccion.Text + "', '" + txtEmail.Text + "', '" + txtTelefono.Text + "','" + cb_sexo.Text + "','" + txtDUI.Text + "','" + txtNIT.Text + "','" + txtSueldo.Text + "', '" + txtUser.Text + "','" + enc.EncryptKey(tb_contraseña.Text) + "', '" + cb_cargo.Text + "', '" + cb_activo.Text + "')";
            //llamamos a la clase DataBase con el metodo Insertar y le pasamos el parametro
            if (db.Insertar(agregar))
            {
                MessageBox.Show("Empleado agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);             
                this.Close();
                emp.Show();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            emp.Show();
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            //Escribimos los campos que queremos modificar
            string actualizar = "Nombre= '" + txtNombre.Text + "', Direccion = '" + txtDireccion.Text + "', Email = '" + txtEmail.Text + "', Telefono = '" + txtTelefono.Text + "', Usuario='" + txtUser.Text + "', Contraseña= '" + enc.EncryptKey(tb_contraseña.Text) + "', Cargo='" + cb_cargo.Text + "', Activo = '" + cb_activo.Text + "'";
            if (db.Actualizar("Empleado", actualizar, "IdEmpleado =" + lb_numeroID.Text))//le pasamos los parametros de nuestro metodo Actualizar que se encuentra en la clase DataBase
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
    }
}
