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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet5.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            pRODUCTOSTableAdapter.Connection.ConnectionString = Conexion.conectar();
            this.pRODUCTOSTableAdapter.Fill(this.vENTASDataSet5.PRODUCTOS);
            consecutivo();
            //MostrarDatos();

        }
        private void guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PRODUCTOS";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@PR_ID", TXTID.Text);
            cmd.Parameters.AddWithValue("@PR_NOMBRE", TXTNOM.Text);
            cmd.Parameters.AddWithValue("@PR_ID_UNIDAD", TXTIDU.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MIN", TXTSTMIN.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MAX", TXTSTMAX.Text);
            cmd.Parameters.AddWithValue("@PR_ID_TP", TXTIDTP.Text);
            cmd.Parameters.AddWithValue("@PR_PRECIO", TXTPRE.Text);
            cmd.Parameters.AddWithValue("@PR_IVA", TXTIVA.Text);


            MessageBox.Show("Sus datos se guardaron correctamente");
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los dato. Error:" + ex);
            }

            finally
            {
                con.Close();
            }
        }

        private void eliminar()
        {
            SqlConnection con = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PRODUCTOS";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@PR_ID", TXTID.Text);
            cmd.Parameters.AddWithValue("@PR_NOMBRE", TXTNOM.Text);
            cmd.Parameters.AddWithValue("@PR_ID_UNIDAD", TXTIDU.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MIN", TXTSTMIN.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MAX", TXTSTMAX.Text);
            cmd.Parameters.AddWithValue("@PR_ID_TP", TXTIDTP.Text);
            cmd.Parameters.AddWithValue("@PR_PRECIO", TXTPRE.Text);
            cmd.Parameters.AddWithValue("@PR_IVA", TXTIVA.Text);


            MessageBox.Show("Sus datos se Eliminaron correctamente");
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los dato. Error:" + ex);
            }

            finally
            {
                con.Close();
            }
        }
        private void MostrarDatos()
        {

            SqlConnection mSqlConnection = new SqlConnection(Conexion.conectar());
            try
            {

                mSqlConnection.Open();
                string sql = "EXECUTE SP_PRODUCTOS";
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(sql, mSqlConnection);
                vENTASDataSet5.Tables["SP_PRODUCTOS"].Clear();
                adapter.Fill(vENTASDataSet5, "SP_PRODUCTOS");
                dataGridView1.DataSource = vENTASDataSet5.Tables["SP_PRODUCTOS"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron datos error: " + ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }









        }

        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(PR_ID),0) + 1 AS CONSECUTIVO FROM PRODUCTOS";

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TXTID.Text = dr.GetInt32(0).ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron datos error: " + ex);
            }
            finally
            {
                con.Close();

            }


        }
        private void BTNREG_Click(object sender, EventArgs e)
        {
            guardar();
        }





        private void BTNELIM_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void pRODUCTOSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }



        private void BTNREG_Click_1(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
