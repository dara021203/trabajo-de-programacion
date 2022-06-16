using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_de_curso_programacion
{
    public partial class Servicio : Form
    {
        public Servicio()
        {
            InitializeComponent();
            mostrardatos();
        }
        public void mostrardatos()
        {
            cone.consulta("select * from servicios", "servicios");
            dataGridView1.DataSource = cone.ds.Tables["servicios"];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        Conexion cone = new Conexion();
        private void Servicio_Load(object sender, EventArgs e)
        {
            cone.conectar();
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int plazo = Int32.Parse((DateTime.Parse(dtpFecha.Text).Month - DateTime.Now.Month).ToString());
            if (plazo == 0)
            {
                plazo = 1;
            }
            int cuota = Int32.Parse(txtMonto.Text) / plazo;
            string registrar = "insert into servicios values(" + txtMonto.Text + " , " + cuota.ToString() + ",'" + dtpFecha.Text;
            if (cone.insertar(registrar)){

                MessageBox.Show("Prestamo registrado");
                mostrardatos();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
