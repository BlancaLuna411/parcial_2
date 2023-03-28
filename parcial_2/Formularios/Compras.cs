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

namespace parcial_2.Formularios
{
    public partial class Compras : Form
    {
        SqlConnection con = new SqlConnection(Conexion.conectar());
        public Compras()
        {
            InitializeComponent();
            this.cOMPRASTableAdapter.Connection = con;
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet.Compra_detalle_temporal' Puede moverla o quitarla según sea necesario.
            this.compra_detalle_temporalTableAdapter.Fill(this.vENTASDataSet.Compra_detalle_temporal);
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet4.COMPRAS' Puede moverla o quitarla según sea necesario.
            this.cOMPRASTableAdapter.Fill(this.vENTASDataSet4.COMPRAS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_COMPRAS", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OP", 1);
            command.Parameters.AddWithValue("@CO_FOLIO", TXTFOLIO.Text);
            command.Parameters.AddWithValue("@CO_SERIE", TXTSERIE.Text);
            command.Parameters.AddWithValue("@CO_ID_TIPODOCTO", TXTPRO.Text);
            command.Parameters.AddWithValue("@CO_MONTO", TXTMONT.Text);
            command.Parameters.AddWithValue("@CO_ID_PROVEEDOR", TXTPROV.Text);
            command.Parameters.AddWithValue("@CO_ID_ALMACEN", TXTIDAL.Text);
            command.Parameters.AddWithValue("@CO_FACTURA", TXTFAC.Text);
            command.Parameters.AddWithValue("@CO_FECHA", DATEFECHA.Value);
            command.Parameters.AddWithValue("@CD_ID_PRODUCTO", textBox1.Text);
            command.Parameters.AddWithValue("@CD_CANTIDAD", textBox2.Text);
            command.Parameters.AddWithValue("@CD_IMPORTE", textBox3.Text);
            command.Parameters.AddWithValue("@CD_IVA", textBox4.Text);
            command.Parameters.AddWithValue("@CD_UBICACION", textBox5.Text);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se guardaron correctamente");
                this.compra_detalle_temporalTableAdapter.Fill(this.vENTASDataSet.Compra_detalle_temporal);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos correctamente: " + ex);
            }

            finally
            {
                conn.Close();
            }
        }

        private void BTNREG_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_COMPRAS", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@OP", 2);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se pasaron a compra correctamente");
                this.compra_detalle_temporalTableAdapter.Fill(this.vENTASDataSet.Compra_detalle_temporal);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron pasar los datos a venta: " + ex);
            }

            finally
            {
                conn.Close();
            }
        }

        private void BTNELIM_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_COMPRAS", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OP", 3);
            command.Parameters.AddWithValue("@CO_FOLIO", TXTFOLIO.Text);
            command.Parameters.AddWithValue("@CO_SERIE", TXTSERIE.Text);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se borraron correctamente");
                this.compra_detalle_temporalTableAdapter.Fill(this.vENTASDataSet.Compra_detalle_temporal);

            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron borrar los datos correctamente: " + ex);
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
