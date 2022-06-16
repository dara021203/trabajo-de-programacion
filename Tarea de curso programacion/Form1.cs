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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            
            Form formularioclientes = new Clientes();
            formularioclientes.Show();
        }

        private void btnservicios_Click(object sender, EventArgs e)
        {
            Form formularioservivios = new Servicio();
            formularioservivios.Show();

        }
    }
}
