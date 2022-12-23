using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proceso_AratzFernandez
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source = SEGUNDO150\\SEGUNDO; Initial Catalog = DAM2_AratzFernandez; Integrated Security = True");

        SqlCommand cmdAlbaranes = new SqlCommand("SELECT CodAlb, CodPed, FechaEntrega, Aceptado, Estado FROM SGE.albaranes WHERE Estado = 'abierto'");
        SqlCommand cmdLinAlb = new SqlCommand("SELECT CodAlb, CodProd, Unidades FROM SGE.lineasAlb WHERE CodAlb = @p_codi");

        SqlParameter prmCodi = new SqlParameter()
        {
            Direction = ParameterDirection.Input,
            SqlDbType = SqlDbType.Int,
            ParameterName = "@p_codi"
        };

        SqlDataAdapter adpAlb = new SqlDataAdapter();

        DataSet dsAlb = new DataSet();
        DataSet dsLinAlb = new DataSet();

        private void Form2_Load(object sender, EventArgs e)
        {
            cmdLinAlb.Parameters.Add(prmCodi);
            cmdAlbaranes.Connection = conexion;
            adpAlb.SelectCommand = cmdAlbaranes;
            adpAlb.Fill(dsAlb, "Alb");
            grdAlb.DataSource = dsAlb.Tables["Alb"];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlCommand pr_aceptar = conexion.CreateCommand();
            SqlParameter tablaLinAlb = new SqlParameter();
            SqlParameter codAlb = new SqlParameter();
            SqlParameter salida = new SqlParameter();
            try
            {
            tablaLinAlb.ParameterName = "@tabla";
            tablaLinAlb.Direction = ParameterDirection.Input;
            tablaLinAlb.SqlDbType = SqlDbType.Structured;
            tablaLinAlb.Value = dsLinAlb.Tables["LinAlb"];

            codAlb.Value = grdAlb.CurrentRow.Cells[0].Value;

            salida.ParameterName = "@p_salida";
            salida.Direction = ParameterDirection.Output;
            salida.SqlDbType = SqlDbType.Int;
            salida.Value = 0;

            pr_aceptar.CommandType = CommandType.StoredProcedure;
            pr_aceptar.CommandText = "SGE.pr_AceptarAlb2";
            pr_aceptar.Parameters.Add(tablaLinAlb);
            pr_aceptar.Parameters.Add(codAlb);
            pr_aceptar.Parameters.Add(salida);

                conexion.Open();
                pr_aceptar.ExecuteNonQuery();
                MessageBox.Show("Se han aplicado los cambios correctamente");
            }
            catch
            {
                MessageBox.Show("Error al aplicar los cambios");
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            grdAlb.CurrentRow.Cells[3].Value = "Rechazado";
        }

        private void btnLinAlb_Click(object sender, EventArgs e)
        {
            dsLinAlb.Tables.Clear();
            grdLinAlb.DataSource = dsLinAlb.Tables["LinAlb"];
            if (grdAlb.Rows.Count > 0)
                prmCodi.Value = Convert.ToInt32(grdAlb.CurrentRow.Cells[0].Value);
            cmdLinAlb.Connection = conexion;
            adpAlb.SelectCommand = cmdLinAlb;
            adpAlb.Fill(dsLinAlb, "LinAlb");
            grdLinAlb.DataSource = dsLinAlb.Tables["LinAlb"];
        }
    }
}
