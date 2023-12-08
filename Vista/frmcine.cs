using examencines.Controlador;
using examencines.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examencines
{
    public partial class frmcine : Form
    {
        public frmcine()
        {
            InitializeComponent();
        }
        CinesControlador controlador = new CinesControlador();
        CinesModelo modelo = new CinesModelo();


        private void refrescar()
        {
            dgvempleados.DataSource = controlador.get();

            label1.Text = $"Cantidad de Registros: {dgvempleados.RowCount - 1 }";

        }


        private void frmcine_Load(object sender, EventArgs e)
        {
            this.refrescar();

        }

        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtfilnombre_TextChanged(object sender, EventArgs e)
        {
            string filtername = "NombreCine";
            ((DataTable)dgvempleados.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtfilnombre.Text);
        }

        private void txtciudad_TextChanged(object sender, EventArgs e)
        {
            string filtername = "NombreCiudad";
            ((DataTable)dgvempleados.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtciudad.Text);
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
