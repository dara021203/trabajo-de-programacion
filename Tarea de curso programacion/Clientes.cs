using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_de_curso_programacion
{
    public partial class Clientes : Form
    {
        Conexion conex = new Conexion();
        public Clientes()
        {
            conex.conectar();


            mostrardatos();
        }

        public void mostrardatos()
        {
            conex.consulta("select * from CLIENTES", "CLIENTES");
            dataGridView1.DataSource = conex.ds.Tables["CLIENTES"];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
            txtxClave.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtApellido.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtCedula.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtDireccion.Text= dataGridViewRow.Cells[4].Value.ToString();
         

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesp1DataSet2.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.clientesp1DataSet2.CLIENTES);
            // TODO: esta línea de código carga datos en la tabla 'clientesp1DataSet1.CLIENTES' Puede moverla o quitarla según sea necesario.
         

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = "clientes";
            if(conex.buscar("nombres",buscar,"Clase = " +txtbuscar.Text))
            {
                MessageBox.Show("dato buscado");
                string buscarx = "select " + "clase ," + "nombres ," + "Apellidos , " + "cedula , " + "Direccion , " + " direccion " + " from " +" clientes " + " where "+ " clase = " + txtbuscar.Text;

                conex.consulta(buscarx, "CLIENTES");
                dataGridView1.DataSource = conex.ds.Tables["CLIENTES"];
            }
            else
            {
                MessageBox.Show("error al buscar el dato");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into CLIENTES VALUES ('" + txtNombre.Text + "','" + txtApellido.Text + "'," + txtCedula.Text + ",'" + txtDireccion.Text +  "')";
            MessageBox.Show(agregar);
            if (conex.insertar(agregar))
            {
                MessageBox.Show("Datos agregados");
                mostrardatos();
            }
            else
            {
                MessageBox.Show("Error al agregar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (conex.Eliminar("clientes", "clase= " + txtxClave.Text))
            {
                MessageBox.Show("Dato eliminado");
                mostrardatos();
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string actualizar = "NOMBRES='" + txtNombre.Text + "', APELLIDOS='" + txtApellido.Text + "', CEDULA='" + txtCedula.Text;
                if(conex.Actualizar("clientes",actualizar,"Clase=" + txtxClave.Text))
            {
                MessageBox.Show("datos actualizados");
                mostrardatos();
            }
                else
            {
                MessageBox.Show("Error al actualizar");
            }
        }
    }
}
