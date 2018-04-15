using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Judith_s_Bakery
{
    class DataBase
    {
        SqlConnection conexion = new SqlConnection("Data Source=EDUAR7;Initial Catalog=JudithBakery;Integrated Security=True");
        public SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        public static SqlConnection Conexion()
        {
            //Hacemos conexion a la BD
            SqlConnection cn = new SqlConnection("Data Source=EDUAR7;Initial Catalog=JudithBakery;Integrated Security=True");
            cn.Open(); //Abrimos la conexion
            return cn;
        }

        //Metodo de Insertar datos a cierta tabla
        public bool Insertar(string sql)
        {
            conexion.Open();
            cmd = new SqlCommand(sql, conexion); //le pasamos el parametro al SQLCommand 
            int i = cmd.ExecuteNonQuery();
            conexion.Close();
            if (i > 0) //Si la sentencia Sql se ejecuta correctamente se agregan los datos 
            {
                return true;
                
            }
            else //sino no se agregan los datos
            {
                return false;
            }
            
        }


        //Metodo para eliminar datos de cierta tabla
        public bool Eliminar(string tabla, string condicion)
        {
            conexion.Open();
            string elimina = "DELETE FROM " + tabla + " WHERE " + condicion;
            cmd = new SqlCommand(elimina, conexion);
            int i = cmd.ExecuteNonQuery();
            conexion.Close();
            if (i > 0) //Si la sentencia Sql se ejecuta correctamente se agregan los datos 
            {
                return true;
                
            }
            else //sino no se agregan los datos
            {
                return false;
            }
        }


        //Metodo para actualizar los datos de cierta tabla
        public bool Actualizar(string tabla, string campos, string condicion)
        {
            conexion.Open();
            string modificar = "UPDATE " + tabla + " SET " + campos + " WHERE " + condicion;
            cmd = new SqlCommand(modificar, conexion);
            int i = cmd.ExecuteNonQuery();
            conexion.Close();
            if (i > 0) //Si la sentencia Sql se ejecuta correctamente se agregan los datos 
            {
                return true;

            }
            else //sino no se agregan los datos
            {
                return false;
            }
        }


        //Metodo para cargar datos a alguna tabla
        public void cargarDatos(string comando, DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter(comando, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla: " + ex.ToString());
            }
        }
    }
}
