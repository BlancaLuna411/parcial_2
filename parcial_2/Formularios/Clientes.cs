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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet1.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.vENTASDataSet1.CLIENTES);
            consecutivo();
        }

        private void guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CLIENTES";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@CL_ID", TXTCL_ID.Text);
            cmd.Parameters.AddWithValue("@CL_NOMBRE", TXTCL_NOMBRE.Text);
            cmd.Parameters.AddWithValue("@CL_RFC", TXTCL_RFC.Text);
            cmd.Parameters.AddWithValue("@CL_CORREO", TXTCL_CORREO.Text);
            cmd.Parameters.AddWithValue("@CL_LADA", TXTCL_LADA.Text);
            cmd.Parameters.AddWithValue("@CL_TELEFONO", TXTCL_TELEFONO.Text);
            cmd.Parameters.AddWithValue("@CL_CALLE", TXTCL_CALLE.Text);
            cmd.Parameters.AddWithValue("@CL_NUMERO_EXT", TXTCL_NUMEXT.Text);
            cmd.Parameters.AddWithValue("@CL_CTABANCARIA", TXTCL_CUENTABAN.Text);
            cmd.Parameters.AddWithValue("@CL_CONTACTO", TXTCL_CONTACTO.Text);
            cmd.Parameters.AddWithValue("@CL_TELEF_CONTACTO", TXTCL_TELCON.Text);
            cmd.Parameters.AddWithValue("@CL_REGIMEN", COMBOX_REG.Text);

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
            cmd.CommandText = "SP_CLIENTES";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@CL_ID", TXTCL_ID.Text);





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

        private void consecutivo()
        {
            SqlConnection con = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader dr;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(CL_ID),0) + 1 AS CONSECUTIVO FROM CLIENTES";

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TXTCL_ID.Text = dr.GetInt32(0).ToString();

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


            private void BTNBUSCAR_Click(object sender, EventArgs e)
        {

        }

        private void BTNREG_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BTNELIM_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}
