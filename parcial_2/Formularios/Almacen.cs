using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace parcial_2
{
    public partial class Almacen : Form
    {
        SqlConnection con = new SqlConnection(Conexion.conectar());
        public Almacen()
        {
            InitializeComponent();
            this.aLMACENESTableAdapter.Connection = con;
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAlmacenes.ALMACENES' Puede moverla o quitarla según sea necesario.
           // this.aLMACENESTableAdapter.Fill(this.dsAlmacenes.ALMACENES);
            //TODO: esta línea de código carga datos en la tabla 'dsAlmacenes.ALMACENES' Puede moverla o quitarla según sea necesario.
            this.aLMACENESTableAdapter.Fill(this.dsAlmacenes.ALMACENES);
            consecutivo();
            //MostrarDatos();
            
        }


        private void guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACENES";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@AL_ID", TXTID.Text);
            cmd.Parameters.AddWithValue("@AL_NOMBRE", TXTNOM.Text);
          
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sus datos se guardaron correctamente");
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


       /* private void Actualizar()
        {
            SqlConnection con = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACENES";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@AL_ID", TXTID.Text);
            cmd.Parameters.AddWithValue("@AL_NOMBRE", TXTNOM.Text);

            MessageBox.Show("Sus datos se Actializaron correctamente");
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron Actualizar los dato. Error:" + ex);
            }

            finally
            {
                con.Close();
            }
        }*/
        private void eliminar()
        {
            SqlConnection con = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACENES";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@AL_ID", TXTID.Text);
          

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
                string sql = "EXECUTE SP_ALMACENES";
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(sql, mSqlConnection);
                dsAlmacenes.Tables["SP_ALMACENES"].Clear();
                adapter.Fill(dsAlmacenes, "SP_ALMACENES");
                dataGridView1.DataSource = dsAlmacenes.Tables["SP_ALMACENES"];
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
            cmd.CommandText = "SELECT ISNULL(MAX(AL_ID),0) + 1 AS CONSECUTIVO FROM ALMACENES";

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {


        }

        private void BTNACT_Click(object sender, EventArgs e)
        {
           // Actualizar();
        }
    }
}
    


    




