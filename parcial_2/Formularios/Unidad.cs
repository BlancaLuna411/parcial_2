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
    public partial class Unidad : Form
    {
        public Unidad()
        {
            InitializeComponent();
        }

        private void Unidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet7.UNIDAD' Puede moverla o quitarla según sea necesario.
            this.uNIDADTableAdapter.Fill(this.vENTASDataSet7.UNIDAD);

        }
    }
}
