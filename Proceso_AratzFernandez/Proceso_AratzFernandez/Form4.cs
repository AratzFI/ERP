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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source = SEGUNDO150\\SEGUNDO; Initial Catalog = DAM2_AratzFernandez; Integrated Security = True");

        SqlCommand cmdProv = new SqlCommand("SELECT CodProv, Denominacion FROM SGE.provincias");
        SqlCommand cmdProd = new SqlCommand("SELECT CodProd, Denominacion FROM SGE.productos");
        SqlCommand cmdCodigo = new SqlCommand("SELECT ISNULL(MAX(CodPed), 0) FROM SGE.pedidos");
        SqlCommand cmdPVP = new SqlCommand("SELECT PVP FROM SGE.productos WHERE CodProd = @p_cp");

        SqlParameter prmcodProd = new SqlParameter()
        {
            Direction = ParameterDirection.Input,
            ParameterName = "@p_cp",
            SqlDbType = SqlDbType.TinyInt
        };

        DataTable LinPed = new DataTable();
        int NumLinea = 1;

        private void Form4_Load(object sender, EventArgs e)
        {
            LinPed.Columns.Add("CodPed");
            LinPed.Columns.Add("NumLin");
            LinPed.Columns.Add("CodProd");
            LinPed.Columns.Add("Unidades");
            LinPed.Columns.Add("PVP");
            LinPed.Columns["CodProd"].Unique = true;
            cmdProv.Connection = conexion;
            cmdProd.Connection = conexion;
            cmdCodigo.Connection = conexion;
            cmdPVP.Connection = conexion;
            
            cmdPVP.Parameters.Add(prmcodProd);

            conexion.Open();

            SqlDataReader lec = cmdProv.ExecuteReader();
            BindingSource acl = new BindingSource();
            acl.DataSource = lec;
            cboProv.DataSource = acl;
            cboProv.DisplayMember = "Denominacion";
            cboProv.ValueMember = "CodProv";

            lec.Close();

            SqlDataReader lecb = cmdProd.ExecuteReader();
            BindingSource aclb = new BindingSource();
            aclb.DataSource = lecb;
            cboProd.DataSource = aclb;
            cboProd.DisplayMember = "Denominacion";
            cboProd.ValueMember = "CodProd";

            conexion.Close();
        }

        private void btnAñadirLinPed_Click(object sender, EventArgs e)
        {
            prmcodProd.Value = cboProd.SelectedValue;
            conexion.Open();
            int CodPed = (int.Parse(cmdCodigo.ExecuteScalar().ToString())) + 1;
            Single PVP = Single.Parse(cmdPVP.ExecuteScalar().ToString());
            conexion.Close();
            DataRow linea = LinPed.NewRow();
            linea[0] = CodPed;
            linea[1] = NumLinea;
            linea[2] = int.Parse(cboProd.SelectedValue.ToString());
            linea[3] = int.Parse(txtCant.Text);
            linea[4] = PVP;
            try
            {

            
            LinPed.Rows.Add(linea);
            grdLineas.DataSource = LinPed;
                MessageBox.Show("Se ha añadido la línea de albaran");
            }
            catch
            {
                MessageBox.Show("No se puede añadir el mismo producto 2 veces");
            }
            finally
            {
                txtCant.Text = "";
                NumLinea++;
            }
            
        }

        private void btnCrearPed_Click(object sender, EventArgs e)
        {

        }
    }
}
