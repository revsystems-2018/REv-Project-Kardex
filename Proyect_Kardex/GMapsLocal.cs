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
        GMarkerGoogle marker;
        GMapOverlay markeroverlay;

        int filaseleccionada = 0;
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
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);
            markeroverlay.Markers.Add(marker); // add marcador

            //add un tooltip a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = String.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1} ", LatInicial, LngInicial);

            //add overlay en el mapa
            gMapControl1.Overlays.Add(markeroverlay);
        }
    }
}
