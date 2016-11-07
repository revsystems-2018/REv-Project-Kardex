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
    public partial class FechaMensseger : Form
    {
        public String value = "";
        public int codUsr=7906442;
        public int indica = 1;  //1 es para registro de ventas si es 2 para report devolucion.

        DateTime dateIni= DateTime.Today;
        DateTime dateFin= DateTime.Today;

        public FechaMensseger()
        {
            InitializeComponent();

            toolTipFecha.SetToolTip(dateTimeini, "Seleccionar la Fecha de Inicio");
            toolTipFecha.SetToolTip(dateTimefin, "Seleccionar la Fecha de Conclusión");
            toolTipFecha.SetToolTip(send, "Enviar Fechas, Solicitar Busqueda");
            toolTipFecha.SetToolTip(xsalir, "Salir");
        }

        private void xsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FechaMensseger_Load(object sender, EventArgs e)
        {
            
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


        private void send_Click(object sender, EventArgs e)
        {
            dateIni = Convert.ToDateTime(dateTimeini.Text);
            dateFin = Convert.ToDateTime(dateTimefin.Text);

            if (indica == 1)
            {
                if (GetIDUsuario(codUsr) == 2)
                {
                    value = "SELECT * FROM REV_Ventas WHERE Fecha_Venta >= '" + dateIni + "' AND Fecha_Venta <= '" + dateFin + "' AND id_User = '" + codUsr + "' ;";
                    this.Visible = false;
                }
                else
                {
                    value = "SELECT * FROM REV_Ventas WHERE Fecha_Venta >= '" + dateIni + "' AND Fecha_Venta <= '" + dateFin + "' ; ";
                    this.Visible = false;
                }
            }
            else
            {
                value = "SELECT * FROM Devolucion_Ventas WHERE FV_dev >= '" + dateIni + "' AND FV_dev <= '" + dateFin + "' ;";
                this.Visible = false;
            }
        }
    }
}
