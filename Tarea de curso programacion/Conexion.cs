using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_de_curso_programacion
{
    class Conexion
    {
        SqlConnection conex = new SqlConnection("Data source=DESKTOP-8E5163N\\SERVIDORSQL;Initial Catalog=clientesp1;Integrated Security =True");
        public SqlCommandBuilder cmb;
        public DataSet ds= new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comand;
        public void conectar()
        {
            try
            {
                conex.Open();
                MessageBox.Show("Conectado");

            }
            catch
            {

                MessageBox.Show("Error al conectar");
            }
            finally
            {
                conex.Close();
            }

        }
        public void consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, conex);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);

            }
            public bool insertar (string sql)
        {
            conex.Open();
            comand = new SqlCommand(sql, conex);
            int p = comand.ExecuteNonQuery();
            conex.Close();
            if (p > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    public bool Eliminar (string tabla,string condicion)
        {
            conex.Open();
            string elimina = "delete from " + tabla + " where " + condicion;
            comand = new SqlCommand(elimina, conex);
            int i = comand.ExecuteNonQuery();
            conex.Close();
            if (i > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool Actualizar(string tabla, string campos,string condicion)
        {
            conex.Open();
            string actualizar = "update " + tabla + " set " + campos + " where " + condicion;
            comand = new SqlCommand(actualizar, conex);
            int i = comand.ExecuteNonQuery();
            conex.Close();
            if (i > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool buscar(string campos, string  tabla, string condicion)
        {
            conex.Open();
            string buscar = "selected " + campos + " from " + tabla + " where " + condicion;
            comand = new SqlCommand(buscar, conex);
            SqlDataReader reader = comand.ExecuteReader();
            
            if (reader.Read ())
            {
                conex.Close();
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
