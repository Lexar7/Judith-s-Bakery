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
        string DesencriptarContraseña;
        string dgv_id, dgv_nombre, dgv_direccion, dgv_telefono, dgv_usuario, dgv_contraseña, dgv_cargo, dgv_email, dgv_sexo, dgv_DUI, dgv_NIT, dgv_sueldo, dgv_activo;
        
        public Empleados()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        Encriptar_Desencriptar enc = new Encriptar_Desencriptar();
        private void Usuarios_Load(object sender, EventArgs e)
        {
            db.cargarDatos("Select * From Empleado", TablaUsuarios);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tb_buscar.Text == "Buscar Empleado")
            {
                tb_buscar.Text = "";

                tb_buscar.ForeColor = Color.Black;
            }
        }

        private void tb_buscar_Leave(object sender, EventArgs e)
        {
            if (tb_buscar.Text == "")
            {
                tb_buscar.Text = "Buscar Empleado";

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
                SqlCommand cmd = new SqlCommand("select IdEmpleado, Nombre, Direccion, Email, Telefono, DUI, NIT, Usuario, Contraseña, Cargo, Activo from Empleado where Nombre like '%"+nombre+"%'", DataBase.Conexion());
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
            try
            {
                //Boton modificar, creamos el contructor para poder llamar al Form Crear Usuario
                //y mandamos a llamar los controles de nuestro Form CrearEmpleado
                //ponemos cuales queremos que sean visibles y cuales no
                CrearEmpleado cu = new CrearEmpleado();
                //OJO LOS CONTROLES DEL FORM CrearEmpleado DEBEN DE ESTAR EN PUBLICO Y NO EN PRIVADO
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

                //Le mandamos a los controles del Form CrearEmpleado el valor de la fila seleccionada con su contenido en cada celda
                cu.lb_numeroID.Text = dgv_id;
                cu.txtNombre.Text = dgv_nombre;
                cu.txtDireccion.Text = dgv_direccion;
                cu.txtTelefono.Text = dgv_telefono;
                cu.txtUser.Text = dgv_usuario;
                cu.tb_contraseña.Text = enc.DecryptKey(dgv_contraseña);
                cu.cb_cargo.Text = dgv_cargo;
                cu.txtDUI.Text = dgv_DUI;
                cu.txtNIT.Text = dgv_NIT;
                cu.txtEmail.Text = dgv_email;
                cu.txtSueldo.Text = dgv_sueldo;
                cu.cb_sexo.Text = dgv_sexo;
                cu.cb_activo.Text = dgv_activo;
                cu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione primero una celda de algún Empleado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TablaUsuarios_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_desencriptar.Text = enc.DecryptKey(DesencriptarContraseña);
        }

        private void TablaUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DesencriptarContraseña = (string)TablaUsuarios.Rows[e.RowIndex].Cells[10].Value;
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
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al empleado " + dgv_nombre + "?", "Eliminar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Le pasamos la varibale dgv_id para que tome el IdEmpleado de la fila seleccionada
                    if (db.Eliminar("Empleado", "IdEmpleado = " + dgv_id)) 
                    {
                        MessageBox.Show("Empleado eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        db.cargarDatos("Select * From Empleado", TablaUsuarios);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione primero una celda de algún Empleado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                          
        }

        private void TablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Cada variable tendra el valor de la fila seleccionada con sus celdas
            dgv_id = Convert.ToString((Int32)TablaUsuarios.Rows[e.RowIndex].Cells[0].Value);
            dgv_nombre = (string)TablaUsuarios.Rows[e.RowIndex].Cells[1].Value;
            dgv_direccion = (string)TablaUsuarios.Rows[e.RowIndex].Cells[2].Value;
            dgv_email = (string)TablaUsuarios.Rows[e.RowIndex].Cells[3].Value;
            dgv_telefono = (string)TablaUsuarios.Rows[e.RowIndex].Cells[4].Value;
            dgv_sexo = (string)TablaUsuarios.Rows[e.RowIndex].Cells[5].Value;
            dgv_DUI = (string)TablaUsuarios.Rows[e.RowIndex].Cells[6].Value;
            dgv_NIT = (string)TablaUsuarios.Rows[e.RowIndex].Cells[7].Value;
            dgv_sueldo = Convert.ToString((Decimal)TablaUsuarios.Rows[e.RowIndex].Cells[8].Value);
            dgv_usuario = (string)TablaUsuarios.Rows[e.RowIndex].Cells[9].Value;
            dgv_contraseña = (string)TablaUsuarios.Rows[e.RowIndex].Cells[10].Value;
            dgv_cargo = (string)TablaUsuarios.Rows[e.RowIndex].Cells[11].Value;
            dgv_activo = Convert.ToString((Boolean)TablaUsuarios.Rows[e.RowIndex].Cells[12].Value);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lb_ayuda.Visible = true;
        }
     
    }
}
