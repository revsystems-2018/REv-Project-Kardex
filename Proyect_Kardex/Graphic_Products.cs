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
    public partial class Graphic_Products : Form
    {
        Conexion cs = new Conexion();
        DataTable dt = null;
        //SqlConnection cnn = new SqlConnection();

        void Conectar() { 

            if(cs.GetCONN().State == ConnectionState.Closed)
            {
                cs.OpenCnn();
            }
        }

        public Graphic_Products()
        {
            InitializeComponent();
            Conectar();
            toolTip1.SetToolTip(chartProd, "Grafico de Barras de los Productos Cantidad y Precios");
            toolTip1.SetToolTip(chartorta, "Grafico de Pastel de los Productos Precios");
            toolTip1.SetToolTip(dataprodgrid, "Datos de los Productos");
        }

        public DataTable CargarDatos(String slq) 
        {
            DataTable res= new DataTable();         
            SqlDataAdapter sda = new SqlDataAdapter(slq, cs.GetCONN());
            sda.Fill(res);
            return res;
        }

        private void Graphic_Products_Load(object sender, EventArgs e)
        {
            String lee = "SELECT nomProd AS Nombre, CantProd AS Cantidad, PVUProd AS Precio_Unitario FROM Productos;";

            dataprodgrid.DataSource = CargarDatos(lee);
            chartProd.DataSource = CargarDatos(lee);
            chartProd.Series["Series1"].LegendText = "Productos";
            chartProd.Series["Series1"].XValueMember = "Nombre";
            chartProd.Series["Series1"].YValueMembers = "Cantidad";

            chartProd.Series["Series2"].LegendText = "Precios";
            chartProd.Series["Series2"].XValueMember = "Nombre";
            chartProd.Series["Series2"].YValueMembers = "Precio_Unitario";

            chartorta.DataSource = CargarDatos(lee);
            chartorta.Series["Series1"].XValueMember = "Nombre";
            chartorta.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartorta.Series["Series1"].YValueMembers = "Precio_Unitario";
            chartorta.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }
    }
}
