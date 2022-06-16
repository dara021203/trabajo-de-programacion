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
    class Servicios
    {
        SqlConnection conex = new SqlConnection("Data source=DESKTOP-8E5163N\\SERVIDORSQL;Initial Catalog=clientesp1;Integrated Security =True");
        public SqlCommandBuilder cmbu;
        public DataSet dse = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comandante;
        public void conect()
        {
            try
            {
                conex.Open();
                MessageBox.Show("Conectado a servicios");

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
        public void consult(string sql, string tabla)
        {
            dse.Tables.Clear();
            da = new SqlDataAdapter(sql, conex);
            cmbu = new SqlCommandBuilder(da);
            da.Fill(dse, tabla);

        }
        public bool insertar(string sql)
        {
            conex.Open();
            comandante = new SqlCommand(sql, conex);
            int p = comandante.ExecuteNonQuery();
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
        
    }
}

    
