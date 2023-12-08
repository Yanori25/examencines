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

namespace examencines.Vista
{
    public partial class Frmdepartamento : Form
    {
        public Frmdepartamento()
        {
            InitializeComponent();
        }



        CiudadesControlador controlador = new CiudadesControlador();
        CiudadesModelo modelo = new CiudadesModelo();


        private void refrescar()
        {
            dgvempleados.DataSource = controlador.get();
            label1.Text = $"Cantidad de Registros: {dgvempleados.RowCount - 1 }";
        }


        private void Frmdepartamento_Load(object sender, EventArgs e)
        {
            this.refrescar();

        }

        private void txtciudad_TextChanged(object sender, EventArgs e)
        {
            string filtername = "NombreCiudad";
            ((DataTable)dgvempleados.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtciudad.Text);

        }
    }
}
