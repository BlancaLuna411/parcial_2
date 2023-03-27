using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
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
            consecutivo();
           // MostrarDatos();

        }
        private void guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UNIDAD";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@UN_ID", TXTID.Text);
            cmd.Parameters.AddWithValue("@UN_DESCRIPCION", TXTDESC.Text);

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
            cmd.CommandText = "SP_UNIDAD";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@UN_ID", TXTID.Text);


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
                string sql = "EXECUTE SP_UNIDAD 3";
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(sql, mSqlConnection);
                vENTASDataSet7.Tables["SP_UNIDAD"].Clear();
                adapter.Fill(vENTASDataSet7, "SP_UNIDAD");
                dataGridView1.DataSource = vENTASDataSet7.Tables["SP_UNIDAD"];
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
            cmd.CommandText = "SELECT ISNULL(MAX(UN_ID),0) + 1 AS CONSECUTIVO FROM UNIDAD";

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

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {

        }
    }
}
