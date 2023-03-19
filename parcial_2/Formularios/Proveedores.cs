using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial_2.Formularios
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet6.PROVEEDORES' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORESTableAdapter.Fill(this.vENTASDataSet6.PROVEEDORES);

        }
    }
}
