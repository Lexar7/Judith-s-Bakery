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
    public partial class ModificarMateriaPrima : Form
    {
        DataBase db = new DataBase();
        MateriaPrima mp = new MateriaPrima();
        Validaciones val = new Validaciones();
        public string dgv_id, dgv_nombre, dgv_precio, dgv_cantidad, dgv_categoria, dgv_temporal, dgv_activo;

        private void ModificarMateriaPrima_Load(object sender, EventArgs e)
        {
            db.llenarItems(cbMedida, "SELECT Medida FROM InventarioMateriaPrima", "Medida");
        }

        int activo;
        public ModificarMateriaPrima()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mp.Show();
        }

        private void bt_crear_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (db.SiExiste("InventarioMateriaPrima", "Producto", txtNombre.Text) == false)
                {
                    MessageBox.Show("Ya hay un producto con este nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //AGREGAR EMPLEADO, SOLO ES NECESARIO CAMBIAR EL COMANDO PARA USARLOS EN OTRA TABLA Y LISTO
                    string agregar = "insert into InventarioMateriaPrima values( '" + txtNombre.Text + "', '" + cbMedida.Text + "', 0, '" + txtPrecio.Text + "','','" + obtenerEstado() + "')";
                    //llamamos a la clase DataBase con el metodo Insertar y le pasamos el parametro
                    if (db.Insertar(agregar))
                    {
                        MessageBox.Show("Empleado agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        mp.Show();
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
        public int obtenerEstado()
        {
            if (cbActivo.Text == "Activo")
            {
                activo = 1;
            }
            else
            {
                activo = 0;
            }
            return Convert.ToInt32(activo);
        }

        public bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                txtNombre.LineIdleColor = Color.Red;
                MessageBox.Show("Debe de escribir el nombre de la materia prima", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtPrecio.Text == "")
            {
                ok = false;
                txtPrecio.LineIdleColor = Color.Red;
                MessageBox.Show("Debe de escribir el precio de la materia prima", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbMedida.Text == "MEDIDA")
            {
                ok = false;
                MessageBox.Show("Debe asignarle una medida a la materia prima", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }

        private void ModificarMateriaPrima_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }
}
