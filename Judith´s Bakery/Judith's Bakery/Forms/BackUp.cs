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

namespace Judith_s_Bakery
{
    public partial class BackUp : Form
    {
        public BackUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = DataBase.Conexion();


                SqlCommand cmd = new SqlCommand("backupjb", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // cn.Open();

                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("La copia de Respaldo de la Base de Datos se realizo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
