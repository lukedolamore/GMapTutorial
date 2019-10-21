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
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace GMapTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GoogleMapProvider.Instance;//Changed to Google maps
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            //gmap.SetPositionByKeywords("Invercargill, New Zealand");
            gmap.Position = new PointLatLng(-46.4132, 168.3538);
            gmap.ShowCenter = false;//get rids of red cross in the middle

            //pg2
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(-46.4132, 168.3538),GMarkerGoogleType.blue_pushpin);
            marker.ToolTipText = "Hello\nout there";//Changing the tooltip
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(20, 20);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;//
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);

            //pg3 Polygons
            GMapOverlay polygons = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(-46.413279, 168.353798));
            points.Add(new PointLatLng(-46.414529, 168.353864));
            points.Add(new PointLatLng(-46.414492, 168.359946));
            points.Add(new PointLatLng(-46.413227, 168.359955));           
            GMapPolygon polygon = new GMapPolygon(points, "Southern Institute of Technology Invercargill");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polygons.Polygons.Add(polygon);
            gmap.Overlays.Add(polygons);

            //pg3 Routes
            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> rpoints = new List<PointLatLng>();
            rpoints.Add(new PointLatLng(-46.413902, 168.355514));
            rpoints.Add(new PointLatLng(-46.414115, 168.352888));
            rpoints.Add(new PointLatLng(-46.412349, 168.347600));
            GMapRoute route = new GMapRoute(rpoints, "A walk to PakNSave and the Movies");
            route.Stroke = new Pen(Color.Red, 3);
            Console.WriteLine(route.Distance);//return route distance in KM
            routes.Routes.Add(route);
            gmap.Overlays.Add(routes);

        }//gmap_Load

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Console.WriteLine(string.Format("Marker {0} was clicked.", item.Tag));
        }

        private void gmap_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            Console.WriteLine(string.Format("Polygon {0} with tag {1} was clicked", item.Name, item.Tag));
        }
    }
}
