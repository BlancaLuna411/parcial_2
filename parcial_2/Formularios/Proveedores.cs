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
            consecutivo();
        }

        private void guardar()
        {
            SqlConnection con = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PROVEEDORES";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@PRO_ID", TXTID_PRO.Text);
            cmd.Parameters.AddWithValue("@PRO_NOMBRE", TXTPROV_NOM.Text);
            cmd.Parameters.AddWithValue("@PRO_RFC", TXTPROV_RFC.Text);
            cmd.Parameters.AddWithValue("@PRO_CORREO", TXTPROV_COR.Text);
            cmd.Parameters.AddWithValue("@PRO_LADA", TXTPROV_LADA.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEFONO", TXTPROV_TEL.Text);
            cmd.Parameters.AddWithValue("@PRO_CALLE", TXTPROV_CALLE.Text);
            cmd.Parameters.AddWithValue("@PRO_NUMERO_EXT", TXTPROV_NUMEX.Text);
            cmd.Parameters.AddWithValue("@PRO_CTABANCARIA", TXTPROV_CB.Text);
            cmd.Parameters.AddWithValue("@PRO_CONTACTO", TXTPROV_CONT.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEF_CONTACTO", TXTPROV_TELCONT.Text);
            cmd.Parameters.AddWithValue("@PRO_REGIMEN", TXTCOM_REG.Text);

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
            cmd.CommandText = "SP_PROVEEDORES";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@PRO_ID", TXTID_PRO.Text);




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
            cmd.CommandText = "SELECT ISNULL(MAX(PRO_ID),0) + 1 AS CONSECUTIVO FROM PROVEEDORES";

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TXTID_PRO.Text = dr.GetInt32(0).ToString();

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
