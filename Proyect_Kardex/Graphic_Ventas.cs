﻿using System;
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
    public partial class Graphic_Ventas : Form
    {
        Conexion cs = new Conexion();
        DataTable dt = null;

        public int CodUser = 7906442;

        void Conectar()
        {

            if (cs.GetCONN().State == ConnectionState.Closed)
            {
                cs.OpenCnn();
            }
        }

        public Graphic_Ventas()
        {
            InitializeComponent();
            Conectar();
            toolTip1.SetToolTip(chart1, "Grafico de Barras de las Ventas Cantidad y Precios");
            toolTip1.SetToolTip(chartorta, "Grafico de Pastel de los Productos Precios");
            toolTip1.SetToolTip(dataprodgrid, "Datos de los Productos");
        }

        public DataTable CargarDatos(String slq)
        {
            DataTable res = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(slq, cs.GetCONN());
            sda.Fill(res);
            return res;
        }


        public int GetIDUsuario(int idu)
        {
            int res = 0;
            Conexion r = new Conexion();
            string buscar = "SELECT * FROM Usuario WHERE ciUser= '" + idu + "' ; ";
            try
            {
                r.OpenCnn();
                SqlCommand find = new SqlCommand(buscar, r.GetCONN());
                SqlDataReader fb;
                fb = find.ExecuteReader();

                while (fb.Read())
                {
                    res = fb.GetInt32(15);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. En el Comparador. " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.CerrarCnn();
            }
            r.CerrarCnn();
            return res;
        }


        private void Graphic_Ventas_Load(object sender, EventArgs e)
        {
            try
            {
                if (GetIDUsuario(CodUser) == 2)
                {
                    String lee = "SELECT CAST( fecha_Venta AS DATE ) as Dias, SUM( num_Prod ) as Cantidades, SUM( pago_Cliente ) as Efectivos, count ( name_Cliente ) as Nombre_Cliente FROM REV_Ventas WHERE id_User='" + CodUser + "' GROUP BY CAST( Fecha_Venta AS DATE )"; //VENTAS POR USUARIO
                    String lee2 = "SELECT name_Cliente as Nombre_Cliente, SUM (num_Prod) as Cantidades, SUM(pago_Cliente) as Efectivo FROM REV_Ventas WHERE id_User='" + CodUser + "' GROUP BY name_Cliente";    //PAGOS POR CLIENTES
                    String lee3 = "SELECT cod_Venta, SUM (importe_sell) AS Total_Venta, SUM (ImpT_dev*-1) AS Total_Devolucion FROM Detalle_Venta, Devolucion_Ventas WHERE cod_Venta = IDV_dev GROUP BY cod_Venta";  //DETALLE CON DEVOLUCIONES

                    dataprodgrid.DataSource = CargarDatos(lee);
                    chart1.DataSource = CargarDatos(lee);
                    chart1.Series["SNum"].LegendText = "Cantidades Vendidas";
                    chart1.Series["SNum"].XValueMember = "Dias";
                    chart1.Series["SNum"].YValueMembers = "Cantidades";

                    chart1.Series["SName"].LegendText = "Ingresos";
                    chart1.Series["SName"].XValueMember = "Dias";
                    chart1.Series["SName"].YValueMembers = "Efectivos";

                    chart1.Series["SCliente"].LegendText = "Clientes";
                    chart1.Series["SCliente"].XValueMember = "Dias";
                    chart1.Series["SCliente"].YValueMembers = "Nombre_Cliente";

                    chartorta.DataSource = CargarDatos(lee2);
                    chartorta.Series["Series1"].XValueMember = "Nombre_Cliente";
                    chartorta.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    chartorta.Series["Series1"].YValueMembers = "Efectivo";
                    chartorta.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                    chartDevo.DataSource = CargarDatos(lee3);
                    chartDevo.Series["Series1"].LegendText = "(+)";
                    chartDevo.Series["Series1"].XValueMember = "cod_Venta";
                    chartDevo.Series["Series1"].YValueMembers = "Total_Venta";

                    chartDevo.Series["Series2"].LegendText = "(-)";
                    chartDevo.Series["Series2"].XValueMember = "cod_Venta";
                    chartDevo.Series["Series2"].YValueMembers = "Total_Devolucion";
                }
                else 
                {
                    String lee = "SELECT CAST( fecha_Venta AS DATE ) as Dias, SUM( num_Prod ) as Cantidades, SUM( pago_Cliente ) as Efectivos, count ( name_Cliente ) as Nombre_Cliente FROM REV_Ventas GROUP BY CAST( Fecha_Venta AS DATE )"; //VENTAS POR USUARIO
                    String lee2 = "SELECT name_Cliente as Nombre_Cliente, SUM (num_Prod) as Cantidades, SUM(pago_Cliente) as Efectivo FROM REV_Ventas GROUP BY name_Cliente";    //PAGOS POR CLIENTES
                    String lee3 = "SELECT cod_Venta, SUM (importe_sell) AS Total_Venta, SUM (ImpT_dev*-1) AS Total_Devolucion FROM Detalle_Venta, Devolucion_Ventas WHERE cod_Venta = IDV_dev GROUP BY cod_Venta";  //DETALLE CON DEVOLUCIONES

                    dataprodgrid.DataSource = CargarDatos(lee);
                    chart1.DataSource = CargarDatos(lee);
                    chart1.Series["SNum"].LegendText = "Cantidades Vendidas";
                    chart1.Series["SNum"].XValueMember = "Dias";
                    chart1.Series["SNum"].YValueMembers = "Cantidades";

                    chart1.Series["SName"].LegendText = "Ingresos";
                    chart1.Series["SName"].XValueMember = "Dias";
                    chart1.Series["SName"].YValueMembers = "Efectivos";

                    chart1.Series["SCliente"].LegendText = "Clientes";
                    chart1.Series["SCliente"].XValueMember = "Dias";
                    chart1.Series["SCliente"].YValueMembers = "Nombre_Cliente";

                    chartorta.DataSource = CargarDatos(lee2);
                    chartorta.Series["Series1"].XValueMember = "Nombre_Cliente";
                    chartorta.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    chartorta.Series["Series1"].YValueMembers = "Efectivo";
                    chartorta.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                    chartDevo.DataSource = CargarDatos(lee3);
                    chartDevo.Series["Series1"].LegendText = "(+)";
                    chartDevo.Series["Series1"].XValueMember = "cod_Venta";
                    chartDevo.Series["Series1"].YValueMembers = "Total_Venta";

                    chartDevo.Series["Series2"].LegendText = "(-)";
                    chartDevo.Series["Series2"].XValueMember = "cod_Venta";
                    chartDevo.Series["Series2"].YValueMembers = "Total_Devolucion";
                }
            }
            catch(Exception){ }
        }


    }
}
