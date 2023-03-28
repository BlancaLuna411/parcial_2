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
    public partial class Ventas : Form
    {
        SqlConnection con = new SqlConnection(Conexion.conectar());
        public Ventas()
        {
            InitializeComponent();
            this.vENTASTableAdapter.Connection = con;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet12.venta_detalle_temporal' Puede moverla o quitarla según sea necesario.
            this.venta_detalle_temporalTableAdapter.Fill(this.vENTASDataSet12.venta_detalle_temporal);
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet8.VENTAS' Puede moverla o quitarla según sea necesario.
            this.vENTASTableAdapter.Fill(this.vENTASDataSet8.VENTAS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_VENTAS", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OP", 1);
            command.Parameters.AddWithValue("@VE_FOLIO", TXTFOLIO.Text);
            command.Parameters.AddWithValue("@VE_SERIE", TXTSERIE.Text);
            command.Parameters.AddWithValue("@VE_ID_TIPODOCTO", TXTDOC.Text);
            command.Parameters.AddWithValue("@VE_MONTO", TXTMONT.Text);
            command.Parameters.AddWithValue("@VE_ID_CLIENTE", TXTIDCL.Text);
            command.Parameters.AddWithValue("@VE_ID_ALMACEN", TXTIDAL.Text);
            command.Parameters.AddWithValue("@VE_FECHA", DTPFECHA.Value);
            command.Parameters.AddWithValue("@VED_ID_PRODUCTO", textBox1.Text);
            command.Parameters.AddWithValue("@VED_CANTIDAD", textBox2.Text);
            command.Parameters.AddWithValue("@VED_IMPORTE", textBox3.Text);
            command.Parameters.AddWithValue("@VED_IVA", textBox4.Text);
            

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se guardaron correctamente");
                this.venta_detalle_temporalTableAdapter.Fill(this.vENTASDataSet12.venta_detalle_temporal);
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
            SqlCommand command = new SqlCommand("SP_VENTAS", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@OP", 2);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se pasaron a compra correctamente");
                this.venta_detalle_temporalTableAdapter.Fill(this.vENTASDataSet12.venta_detalle_temporal);
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
                this.venta_detalle_temporalTableAdapter.Fill(this.vENTASDataSet12.venta_detalle_temporal);

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


