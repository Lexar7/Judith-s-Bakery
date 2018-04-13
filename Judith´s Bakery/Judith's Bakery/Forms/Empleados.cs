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
    public partial class Empleados : Form
    {
        string x, y;
        string dgv_id, dgv_nombre, dgv_apellido, dgv_direccion, dgv_telefono, dgv_usuario, dgv_contraseña, dgv_cargo;
        public Empleados()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        Encriptar_Desencriptar enc = new Encriptar_Desencriptar();
        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caceresCarDataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
           // this.usuariosTableAdapter1.Fill(this.caceresCarDataSet1.Usuarios);
            

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tb_buscar.Text == "Buscar Usuario")
            {
                tb_buscar.Text = "";

                tb_buscar.ForeColor = Color.Black;
            }
        }

        private void tb_buscar_Leave(object sender, EventArgs e)
        {
            if (tb_buscar.Text == "")
            {
                tb_buscar.Text = "Buscar Usuario";

                tb_buscar.ForeColor = Color.DarkGray;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string valorBuscando = tb_buscar.Text.ToString(); //Convertir valor del txt a cadena de texto
            BuscarUser(valorBuscando); //Llamar al metodo y pasarle el parametro
           
        }

        public void BuscarUser(string nombre)
        {              
                SqlCommand cmd = new SqlCommand("select IdUsuario, Nombre, Apellido, Direccion, Telefono, Usuario, Contraseña, Cargo from Usuarios where Nombre like '%"+nombre+"%'", DataBase.Conexion());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TablaUsuarios.DataSource = dt;      
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; // Minimiza la ventana
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            //Boton modificar, creamos el contructor para poder llamar al Form Crear Usuario
            //y mandamos a llamar los controles de nuestro Form Crear Usuario
            //ponemos cuales queremos que sean visibles y cuales no
            CrearEmpleado cu = new CrearEmpleado();
            //OJO LOS CONTROLES DEL FORM CREAR USUARIO DEBEN DE ESTAR EN PUBLICO Y NO EN PRIVADO
            //PARA PODERLOS USAR EN OTROS FORMULARIOS
            cu.lb_id.Visible = true;
            cu.lb_numeroID.Visible = true;
            cu.bt_modificar.Visible = true;          
            cu.lb_titulo.Text = "Modificar Usuario";
            //cu.cb_dia.Visible = false;
            //cu.cb_mes.Visible = false;
            //cu.cb_año.Visible = false;
            //cu.label2.Visible = false;
            cu.bt_ingresar.Visible = false;
            //Le mandamos a los controles del Form Crear Usuario el valor de la fila seleccionada con su contenido en cada celda
            cu.lb_numeroID.Text = dgv_id;
            cu.txtNombre.Text = dgv_nombre;
            //cu.txtApellido.Text = dgv_apellido;
            cu.txtDireccion.Text = dgv_direccion;
            cu.txtTelefono.Text = dgv_telefono;
            cu.txtUser.Text = dgv_usuario;
            cu.tb_contraseña.Text = dgv_contraseña;
            cu.cb_cargo.Text = dgv_cargo;
            cu.Show();
            this.Hide();
        }

        private void TablaUsuarios_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_desencriptar.Text = enc.DecryptKey(y);
        }

        private void TablaUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            y = (string)TablaUsuarios.Rows[e.RowIndex].Cells[6].Value;
            button1.Visible = true;
            lb_desencriptar.Visible = true;
        }

        private void bt_usuarios_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void lb_nueva_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void bt_usuarios_Click(object sender, EventArgs e)
        {
            CrearEmpleado cu = new CrearEmpleado();
            cu.Show();
            this.Hide();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {           
            if (db.Eliminar("Usuarios", "IdUsuario = " + x )) //Le pasamos los parametro a nuestro metodo Eliminar de la clase DataBase, 'x' que es la celda selecionada
            {
                MessageBox.Show("Usuario eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.usuariosTableAdapter1.Fill(this.caceresCarDataSet1.Usuarios); //Recargamos la tabla para actualizar los datos
            }
            else
            {
                MessageBox.Show("Error al eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            x = TablaUsuarios.CurrentCell.Value.ToString(); // x toma el valor de la celda seleccionada en la tabla

            //Cada variable tendra el valos de la fila seleccionada con sus celdas
            dgv_id = Convert.ToString((Int32)TablaUsuarios.Rows[e.RowIndex].Cells[0].Value);
            dgv_nombre = (string)TablaUsuarios.Rows[e.RowIndex].Cells[1].Value;
            dgv_apellido = (string)TablaUsuarios.Rows[e.RowIndex].Cells[2].Value;
            dgv_direccion = (string)TablaUsuarios.Rows[e.RowIndex].Cells[3].Value;
            dgv_telefono = Convert.ToString((Int32)TablaUsuarios.Rows[e.RowIndex].Cells[4].Value);
            dgv_usuario = (string)TablaUsuarios.Rows[e.RowIndex].Cells[5].Value;
            dgv_contraseña = (string)TablaUsuarios.Rows[e.RowIndex].Cells[6].Value;
            dgv_cargo = (string)TablaUsuarios.Rows[e.RowIndex].Cells[7].Value;

            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lb_ayuda.Visible = true;
        }
    }
}
