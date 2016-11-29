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
    public partial class ReportClientes : Form
    {
        Conexion cs = new Conexion();
        DataTable dt = null;

        void Conectar()
        {

            if (cs.GetCONN().State == ConnectionState.Closed)
            {
                cs.OpenCnn();
            }
        }

        public ReportClientes()
        {
            InitializeComponent();
            Conectar();
            toolTip1.SetToolTip(chartProd, "Grafico de Barras de los Clientes Cantidad y Pagos");
            toolTip1.SetToolTip(chartorta, "Grafico de Pastel de los Clientes Pagos");
            toolTip1.SetToolTip(dataprodgrid, "Datos de los Clientes");
        }

        public DataTable CargarDatos(String slq)
        {
            DataTable res = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(slq, cs.GetCONN());
            sda.Fill(res);
            return res;
        }

        private void ReportClientes_Load(object sender, EventArgs e)
        {
            String lee = "SELECT name_Cliente AS IDC, SUM(num_Prod) AS Cantidad, SUM(pago_Cliente) AS Pay FROM REV_Ventas GROUP BY name_Cliente; ";

            dataprodgrid.DataSource = CargarDatos(lee);
            chartProd.DataSource = CargarDatos(lee);
            chartProd.Series["Series1"].LegendText = "Productos";
            chartProd.Series["Series1"].XValueMember = "IDC";
            chartProd.Series["Series1"].YValueMembers = "Cantidad";

            chartProd.Series["Series2"].LegendText = "Compras";
            chartProd.Series["Series2"].XValueMember = "IDC";
            chartProd.Series["Series2"].YValueMembers = "Pay";

            chartorta.DataSource = CargarDatos(lee);
            chartorta.Series["Series1"].XValueMember = "IDC";
            chartorta.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartorta.Series["Series1"].YValueMembers = "Pay";
            chartorta.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }
    }
}
