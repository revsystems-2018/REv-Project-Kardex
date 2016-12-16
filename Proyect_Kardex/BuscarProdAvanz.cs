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
    public partial class BuscarProdAvanz : Form
    {
        public BuscarProdAvanz()
        {
            InitializeComponent();
        }

        private void BuscarProdAvanz_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEV_DataBaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.rEV_DataBaseDataSet.Productos);

        }
    }
}
