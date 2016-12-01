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
    public partial class ReporteUsuarios : Form
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

        public ReporteUsuarios()
        {
            InitializeComponent();
            Conectar();
            toolTip1.SetToolTip(chart1, "Grafico de Barras de los Usuarios Cantidad y Efectivo en Ventas");
            toolTip1.SetToolTip(chartorta, "Grafico de Pastel de Pagos en Ventas Realizadas");
            toolTip1.SetToolTip(dataprodgrid, "Datos de los Usuarios");
        }

        public DataTable CargarDatos(String slq)
        {
            DataTable res = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(slq, cs.GetCONN());
            sda.Fill(res);
            return res;
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            String lee = "SELECT name_Cliente AS Nombre, SUM(num_Prod) AS Cantidad, SUM(pago_Cliente) AS Efectivo_Compras FROM REV_Ventas GROUP BY name_Cliente; ";
            String mes = "SELECT name_User AS Nombre_Usuario, SUM (pago_Cliente) AS Efectivo_En_Ventas, SUM (num_Prod) AS Cantidad FROM REV_Ventas WHERE DATEPART (mm, Fecha_Venta) = (DATEPART (mm, GETDATE())-2)  GROUP BY name_User;";  
        
            dataprodgrid.DataSource = CargarDatos(lee);
            chart1.DataSource = CargarDatos(lee);
            chart1.Series["Series1"].LegendText = "Productos";
            chart1.Series["Series1"].XValueMember = "Nombre";
            chart1.Series["Series1"].YValueMembers = "Cantidad";

            chart1.Series["Series2"].LegendText = "Compras";
            chart1.Series["Series2"].XValueMember = "Nombre";
            chart1.Series["Series2"].YValueMembers = "Efectivo_Compras";

            chartorta.DataSource = CargarDatos(lee);
            chartorta.Series["Series1"].XValueMember = "Nombre";
            chartorta.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartorta.Series["Series1"].YValueMembers = "Efectivo_Compras";
            chartorta.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }
    }
}
