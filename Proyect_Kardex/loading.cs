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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 100) this.timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loading_Load(object sender, EventArgs e)
        {

        }
    }
}
