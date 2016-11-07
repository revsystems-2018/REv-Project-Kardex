using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Proyect_Kardex
{
    public partial class Messengers : Form
    {
        public Messengers()
        {
            InitializeComponent();
            //Thread.Sleep(2000);
        }

        private void xsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Messengers_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(4000);
            //this.Close();
        }
    }
}
