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

namespace Proyect_Kardex
{
    public partial class ReportUsuarioMes : Form
    {
        Conexion cs = new Conexion();
        ValidacionText vt = new ValidacionText();
        DataTable dt = null;

        public String nameUsr = "";

        void Conectar()
        {

            if (cs.GetCONN().State == ConnectionState.Closed)
            {
                cs.OpenCnn();
            }
        }

        public ReportUsuarioMes()
        {
            InitializeComponent();
            Conectar();
            toolTip1.SetToolTip(chartorta, "Grafico de Pastel de Pagos en Ventas Realizadas");
            toolTip1.SetToolTip(dataprodgrid, "Datos de los Usuarios");
            toolTip1.SetToolTip(txtCant, "Cantidad de Productos Vendidos");
            toolTip1.SetToolTip(txtEfective, "Efectivo Realizado en Ventas");
            toolTip1.SetToolTip(txtname, "Nombre Completo del Empleado/Usuario del Mes");
            toolTip1.SetToolTip(txtci, "Codigo de Registro/C.I. del Usuario del Mes");
            toolTip1.SetToolTip(PBFoto, "Fotografia del Empleado/Usuario del Mes");

        }

        public DataTable CargarDatos(String slq)
        {
            DataTable res = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(slq, cs.GetCONN());
            sda.Fill(res);
            return res;
        }

        public String SacarUsuario()
        {
            String res = "";
            Double res2 = 0;
            Double aux = 0;

            foreach (DataGridViewRow row in dataprodgrid.Rows)
            {
                res2 = Convert.ToDouble(row.Cells[1].Value);

                if (res2 >= aux)
                {
                    aux = res2;
                    res = Convert.ToString(row.Cells[0].Value);
                }
            }
            return res;
        }

        public Double SacarEfective()
        {
            Double res = 0;
            Double res2 = 0;
            Double aux = 0;

            foreach (DataGridViewRow row in dataprodgrid.Rows)
            {
                res2 = Convert.ToDouble(row.Cells[1].Value);

                if (res2 >= aux)
                {
                    aux = res2;
                    res = Convert.ToDouble(row.Cells[1].Value);
                }
            }
            return res;
        }

        public int SacarCant()
        {
            int res = 0;
            Double res2 = 0;
            Double aux = 0;

            foreach (DataGridViewRow row in dataprodgrid.Rows)
            {
                res2 = Convert.ToDouble(row.Cells[1].Value);

                if (res2 >= aux)
                {
                    aux = res2;
                    res = Convert.ToInt32(row.Cells[2].Value);
                }
            }
            return res;
        }


        public void GetCodeUsr(String nvl)
        {
            Conexion f = new Conexion();

            string query = "SELECT ciUser, nombreUser, apeUser, fotoUser FROM Usuario WHERE nombreUser ='" + nvl + "' ; ";

            SqlCommand sqlQ = new SqlCommand(query, f.GetCONN());
            SqlDataReader read;

            txtname.Text = "";
            txtname.ForeColor = SystemColors.WindowText;
            txtname.Font = new Font(txtname.Font, FontStyle.Regular);
            txtci.Text = "";
            txtci.ForeColor = SystemColors.WindowText;
            txtci.Font = new Font(txtci.Font, FontStyle.Regular);

            try
            {
                f.OpenCnn();
                read = sqlQ.ExecuteReader();
                while (read.Read())
                {
                    txtci.Text = read.GetInt32(0).ToString();
                    txtname.Text = read.GetString(1) + " " + read.GetString(2);

                    byte[] imageBuffer = (byte[])(read[3]);

                    if (imageBuffer == null || read[3] == null) { PBFoto.Image = null; }
                    else
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        PBFoto.Image = Image.FromStream(ms);
                    }
                }
                f.CerrarCnn();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                f.CerrarCnn();
            }
        }


        private void ReportUsuarioMes_Load(object sender, EventArgs e)
        {
            String mes = "SELECT name_User AS Nombre_Usuario, SUM (pago_Cliente) AS Efectivo_En_Ventas, SUM (num_Prod) AS Cantidad FROM REV_Ventas WHERE DATEPART (mm, Fecha_Venta) = (DATEPART (mm, GETDATE())-2)  GROUP BY name_User;";

            dataprodgrid.DataSource = CargarDatos(mes);          

            chartorta.DataSource = CargarDatos(mes);
            chartorta.Series["Series1"].XValueMember = "Nombre_Usuario";
            chartorta.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartorta.Series["Series1"].YValueMembers = "Efectivo_En_Ventas";
            chartorta.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            nameUsr = SacarUsuario();
            txtEfective.Text = Convert.ToString(SacarEfective());
            txtCant.Text = Convert.ToString(SacarCant());

            GetCodeUsr(nameUsr);
        }

        private void PBFoto_Click(object sender, EventArgs e)
        {
            VerAdmin va = new VerAdmin();
            va.codUser = Convert.ToInt32(txtci.Text);
            va.ShowDialog();
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            vt.Nada(e);
        }

        private void txtEfective_KeyPress(object sender, KeyPressEventArgs e)
        {
            vt.Nada(e);
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            vt.Nada(e);
        }

        private void txtci_KeyPress(object sender, KeyPressEventArgs e)
        {
            vt.Nada(e);
        }
    }
}
