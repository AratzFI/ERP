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
    public partial class Form3 : Form
    {
        SqlCommand cmdProductos = new SqlCommand("SELECT CodProd, Denominacion FROM SGE.productos");
        SqlCommand cmdINSAlb = new SqlCommand("INSERT INTO SGE.albaranes (CodAlb, CodPed, FechaEntrega, Estado) VALUES (@p_calb, @p_cped, @p_fecha, @p_est)");
        SqlCommand cmdINSLinAlb = new SqlCommand("INSERT INTO SGE.lineasAlb (CodAlb, CodProd, Unidades) VALUES (@p_calbo, @p_cprod, @p_uni)");
        SqlCommand cmdCodigoAlb = new SqlCommand("SELECT ISNULL(MAX(CodAlb), 0) FROM SGE.albaranes");
        SqlCommand cmdCodigoPed = new SqlCommand("SELECT MAX(CodPed) FROM SGE.pedidos");

        SqlParameter prmCAlbINSAlb = new SqlParameter()
        {
            Direction = ParameterDirection.Input,
            ParameterName = "@p_calb",
            SqlDbType = SqlDbType.SmallInt
        };
        SqlParameter prmCPedINSAlb = new SqlParameter()
        {
            Direction = ParameterDirection.Input,
            ParameterName = "@p_cped",
            SqlDbType = SqlDbType.TinyInt
        };
        SqlParameter prmFEINSAlb = new SqlParameter()
        {
            Direction = ParameterDirection.Input,
            ParameterName = "@p_fecha",
            SqlDbType = SqlDbType.Date
        };
        SqlParameter prmEstINSAlb = new SqlParameter()
        {
            Direction = ParameterDirection.Input,
            ParameterName = "@p_est",
            SqlDbType = SqlDbType.NChar,
            Size = 7
        };

        SqlParameter prmINSLinAlbA = new SqlParameter()
        {
            Direction = ParameterDirection.Input,
            ParameterName = "@p_calbo",
            SqlDbType = SqlDbType.SmallInt
        };
        SqlParameter prmINSLinAlbB = new SqlParameter()
        {
            Direction = ParameterDirection.Input,
            ParameterName = "@p_cprod",
            SqlDbType = SqlDbType.TinyInt
        };
        SqlParameter prmINSLinAlbC = new SqlParameter()
        {
            Direction = ParameterDirection.Input,
            ParameterName = "@p_uni",
            SqlDbType = SqlDbType.TinyInt
        };

        DataTable LinAlb = new DataTable();


        SqlConnection conexion = new SqlConnection("Data Source = SEGUNDO150\\SEGUNDO; Initial Catalog = DAM2_AratzFernandez; Integrated Security = True");


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LinAlb.Columns.Add("CodAlb");
            LinAlb.Columns.Add("CodProd");
            LinAlb.Columns.Add("Unidades");

            btnLinea.Enabled = false;
            cmdCodigoPed.Connection = conexion;
            cmdCodigoAlb.Connection = conexion;
            cmdProductos.Connection = conexion;
            cmdINSAlb.Connection = conexion;
            cmdINSLinAlb.Connection = conexion;

            cmdINSLinAlb.Parameters.Add(prmINSLinAlbA);
            cmdINSLinAlb.Parameters.Add(prmINSLinAlbB);
            cmdINSLinAlb.Parameters.Add(prmINSLinAlbC);
            cmdINSAlb.Parameters.Add(prmCAlbINSAlb);
            cmdINSAlb.Parameters.Add(prmCPedINSAlb);
            cmdINSAlb.Parameters.Add(prmFEINSAlb);
            cmdINSAlb.Parameters.Add(prmEstINSAlb);

            prmEstINSAlb.Value = "Abierto";

            conexion.Open();

            SqlDataReader dr = cmdProductos.ExecuteReader();
            BindingSource acp = new BindingSource();
            acp.DataSource = dr;
            cboProd.DataSource = acp;
            cboProd.ValueMember = "CodProd";
            cboProd.DisplayMember = "Denominacion";

            conexion.Close();

        }

        private void btnAlb_Click(object sender, EventArgs e)
        { 
            conexion.Open();
            prmCAlbINSAlb.Value = (int.Parse(cmdCodigoAlb.ExecuteScalar().ToString())) + 1;
            prmCPedINSAlb.Value = (int.Parse(cmdCodigoPed.ExecuteScalar().ToString()));
            prmFEINSAlb.Value = dtFecha.Value;

            SqlTransaction trans = conexion.BeginTransaction();
            cmdINSAlb.Transaction = trans;
            try
            {
                cmdINSAlb.ExecuteNonQuery();
                trans.Commit();
                MessageBox.Show("Se ha creado el Albaran");                
            }
            catch
            {
                trans.Rollback();
                MessageBox.Show("Error");
            }
            finally
            {
                conexion.Close();
                txtUnidades.Text = "";
                btnLinea.Enabled = true;
            }
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            conexion.Open();
            prmINSLinAlbA.Value = int.Parse(cmdCodigoAlb.ExecuteScalar().ToString());
            prmINSLinAlbB.Value = int.Parse(cboProd.SelectedValue.ToString());
            prmINSLinAlbC.Value = int.Parse(txtUnidades.Text);

            SqlTransaction trans = conexion.BeginTransaction();
            cmdINSLinAlb.Transaction = trans;
            try
            {
                cmdINSLinAlb.ExecuteNonQuery();
                trans.Commit();
                MessageBox.Show("Se ha añadido la linea al Albarán creado más reciente");
            }
            catch
            {
                trans.Rollback();
                MessageBox.Show("Error al añadir la línea de albarán");
            }
            finally
            {
                int codalb = (int.Parse(cmdCodigoAlb.ExecuteScalar().ToString()));
                conexion.Close();
                DataRow linea = LinAlb.NewRow();
                linea[0] = codalb;
                linea[1] = int.Parse(cboProd.SelectedValue.ToString());
                linea[2] = txtUnidades.Text;
                LinAlb.Rows.Add(linea);
                grdLinAlb.DataSource = LinAlb;
                txtUnidades.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
