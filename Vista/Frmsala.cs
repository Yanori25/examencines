using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using examencines.Controlador;
using examencines.Modelo;

namespace examencines.Vista
{
    public partial class Frmsala : Form
    {
        public Frmsala()
        {
            InitializeComponent();
        }

        
        SalasControlador controlador = new SalasControlador();
        SalasModelo modelo  = new SalasModelo();


        private void refrescar()
        {
            dgvempleados.DataSource = controlador.get();
            label1.Text = $"Cantidad de Registros: {dgvempleados.RowCount -1 }";
        }


        private void Frmsala_Load(object sender, EventArgs e)
        {
            this.refrescar();

        }

        private void txtfilsala_TextChanged(object sender, EventArgs e)
        {
            string filtername = "NombreSala";
            ((DataTable)dgvempleados.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtfilsala.Text);
        }

        private void txtciudad_TextChanged(object sender, EventArgs e)
        {
            string filtername = "NombreCiudad";
            ((DataTable)dgvempleados.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtciudad.Text);
        }

        private void txtfilnombre_TextChanged(object sender, EventArgs e)
        {
            string filtername = "NombreCine";
            ((DataTable)dgvempleados.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtfilnombre.Text);
        }
    }
}
