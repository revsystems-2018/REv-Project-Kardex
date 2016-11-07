using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect_Kardex
{
    public partial class SearchMensseger : Form
    {
        public String value = "";
        public int indica = 1;

        public SearchMensseger()
        {
            InitializeComponent();

            toolBuscarSMS.SetToolTip(btnName, "Buscar por Nombre");
            toolBuscarSMS.SetToolTip(btnDet, "Buscar por Descripción");
            toolBuscarSMS.SetToolTip(btnCode, "Buscar por Codigo de Registro");
            toolBuscarSMS.SetToolTip(xsalir, "Salir");
            toolBuscarSMS.SetToolTip(textbuscar, "Ingresar los Datos del Producto a Buscar");
        }

        private void xsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (textbuscar.Text == "")
                {
                    MessageBox.Show("Ingrese Alguna Descripción del Producto.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    if(indica == 1)
                    {
                        value = "SELECT * FROM Productos WHERE nomProd Like '"+textbuscar.Text+"%' ";
                        this.Visible=false;
                    }
                    else if(indica == 2)
                    {
                        value = "SELECT * FROM Productos WHERE DescProd Like '" + textbuscar.Text + "%' ";
                        this.Close();
                    }
                    else if (indica == 3)
                    {
                        int fun = int.Parse(textbuscar.Text);
                        if (fun >= 0)
                        {
                            value = "SELECT * FROM Productos WHERE CodBarP Like '" + textbuscar.Text + "%' ";
                            this.Close();
                        }
                        else 
                        {
                            MessageBox.Show("Debe Ingresar un Valor Numerico que Pertenezca al Codigo de Registro del Producto.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else { this.Close(); }                                       
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indica = 1;
            btnName.BackgroundImage = global::Proyect_Kardex.Properties.Resources.BuscarName;
            btnDet.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarDetalle_B;
            btnCode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarCode_B;
        }

        private void SearchMensseger_Load(object sender, EventArgs e)
        {
            indica = 1;
            btnName.BackgroundImage = global::Proyect_Kardex.Properties.Resources.BuscarName;
            btnDet.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarDetalle_B;
            btnCode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarCode_B;
        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            indica = 2;
            btnName.BackgroundImage = global::Proyect_Kardex.Properties.Resources.BuscarName_B;
            btnDet.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarDetalle;
            btnCode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarCode_B;
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            indica = 3;
            btnName.BackgroundImage = global::Proyect_Kardex.Properties.Resources.BuscarName_B;
            btnDet.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarDetalle_B;
            btnCode.BackgroundImage = global::Proyect_Kardex.Properties.Resources.buscarCode;
        }


    }
}
