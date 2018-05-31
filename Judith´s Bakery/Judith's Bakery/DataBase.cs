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
        SqlConnection conexion = new SqlConnection(@"Data Source=.;Initial Catalog=JudithBakery;Integrated Security=True");

        public SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;
        public static SqlConnection Conexion()
        {
            //Hacemos conexion a la BD
            SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=JudithBakery;Integrated Security=True");
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

        //Verificar si ya existe un dato en la BD para no repetir 
        public bool SiExiste(string tabla,  string condicion, string campo)
        {
            string sql = "SELECT * FROM " + tabla + " WHERE " + condicion + " = @campo";
            SqlCommand cmd = new SqlCommand(sql, DataBase.Conexion());
            cmd.Parameters.AddWithValue("campo", campo);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count == 0;
        }


        //Busqueda para rangos de precios 
        public void BuscarRango(string entidad,string campo, double desde, double hasta, DataGridView dgv)
        {
            cargarDatos("Select * FROM " + entidad + " WHERE " + campo + " BETWEEN "+desde+" AND "+hasta+" AND Activo = 1", dgv);
        }
        //Busqueda para un solo parametro PD. no lo recomiendo para ID's
        public void BuscarporUnParametro(string entidad,string campo,string parametro, DataGridView dgv)
        {
            cargarDatos("Select * FROM " + entidad + " WHERE " + campo + " LIKE '%" + parametro+"%'",dgv);
        }


        //llenar un comboBox con datos desde la base de datos
        public void llenarItems(ComboBox cb, string comando, string campo)
        {
            try
            {
                cmd = new SqlCommand(comando, DataBase.Conexion()); //le pasamos los parametro 'comando' y nuestra conexion
                dr = cmd.ExecuteReader();  //lenamos el DataReader con los registros de la secuencia SQLCommand
                while (dr.Read())       // recorrera los registros
                {
                    cb.Items.Add(dr[campo].ToString());     //capturara los datos de los campos que se estan leyebdo en el DataReader
                }
                //cb.SelectedIndex = 0; Para cargar por defecto el primer valor de la lista
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos al ComboBox" + ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<string> ObtenerCategoria()
        {
            List<string> categorias= new List<string>();
            SqlCommand comando = new SqlCommand(String.Format("SELECT Categoria FROM Categoria"), DataBase.Conexion());
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {


                string valor = reader.GetString(0);

                categorias.Add(valor);
            }
            return categorias;
        }
    }
}
