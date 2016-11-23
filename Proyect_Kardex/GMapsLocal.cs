using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Proyect_Kardex
{
    public partial class GMapsLocal : Form
    {
        ValidacionText mn = new ValidacionText();
        GMarkerGoogle marker;
        GMapOverlay markeroverlay;

        int filaseleccionada = 0;
        public String codGMap = "";
        public double LatInicial = -17.301837;
        public double LngInicial = -66.410481;

        public GMapsLocal()
        {
            InitializeComponent();

            toolTip1.SetToolTip(txtdesc, "Redactar la Direccion");
            toolTip1.SetToolTip(txtlat, "Codigo de Posicion en Latitud");
            toolTip1.SetToolTip(txtlng, "Codigo de Posicion en Longitud");
            toolTip1.SetToolTip(sendBtn, "Localizar/Enviar Direccion");
        }

        private void GMapsLocal_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = System.Windows.Forms.MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //marcador
            markeroverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.red);
            markeroverlay.Markers.Add(marker); // add marcador

            //add un tooltip a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = String.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1} ", LatInicial, LngInicial);

            //add overlay en el mapa
            gMapControl1.Overlays.Add(markeroverlay);
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //obtener los datos en los ejes X y Y.
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //posicionar lat y lng
            txtdesc.Text = "Mi Ubicacion";
            txtlat.Text = lat.ToString();
            txtlng.Text = lng.ToString();

            //crear marcador en el mapa
            marker.Position = new PointLatLng(lat, lng);

            //add mensage del lugar
            marker.ToolTipText = String.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", lat, lng);
        }

        private void txtdesc_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (txtdesc.Text != "" && txtdesc.Font.Italic == true)
                {
                    txtdesc.Text = "";
                    txtdesc.ForeColor = SystemColors.WindowText;
                    txtdesc.Font = new Font(txtdesc.Font, FontStyle.Regular);
                    //textBox1.Font.Italic = false;

                }
                else
                {
                    txtdesc.ForeColor = SystemColors.WindowText;
                    txtdesc.Font = new Font(txtdesc.Font, FontStyle.Regular);
                }
            }
        }

        private void txtdesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtdesc.ForeColor = SystemColors.WindowText;
            txtdesc.Font = new Font(txtdesc.Font, FontStyle.Regular);
        }

        private void txtlat_KeyPress(object sender, KeyPressEventArgs e)
        {
            mn.Nada(e);
        }

        private void txtlng_KeyPress(object sender, KeyPressEventArgs e)
        {
            mn.Nada(e);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            codGMap = txtdesc.Text + ";" + txtlat.Text + ";" + txtlng.Text;
            this.Close();
        }
    }
}
