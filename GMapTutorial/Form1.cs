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
using System.Net;
using System.Web.Script.Serialization;

namespace GMapTutorial
{
    public partial class Form1 : Form
    {
        List<PlaceOfInterest> placeOfInterests = new List<PlaceOfInterest>();

        public Form1()
        {
            InitializeComponent();
            GetLocationData();
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            int prevID = -1;
            Random random = new Random();
            placeOfInterests.Sort();
            Color prevColor = Color.Black;
            gmap.DragButton = MouseButtons.Left;//Map can be moved using Left mouse button
            gmap.MapProvider = GoogleMapProvider.Instance;//Changed to Google maps
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            //gmap.SetPositionByKeywords("Invercargill, New Zealand");
            gmap.Position = new PointLatLng(-46.4132, 168.3538);
            gmap.ShowCenter = false;//get rids of red cross in the middle
            GMapOverlay markers = new GMapOverlay("markers");
            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> rpoints = new List<PointLatLng>();
            foreach (var mark in placeOfInterests)
            {
                Console.WriteLine(mark.UserID);
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(mark.Latitude, mark.Longitude), GMarkerGoogleType.red_pushpin);
                
                marker.ToolTipText = (string.Format("User ID :{0}\nDesc :{1}", mark.UserID, mark.Description));
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);              
                if (mark.UserID != prevID)
                {
                    Color color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    prevID = mark.UserID;      
                    prevColor = color;
                }
                if (mark.UserID == prevID)
                {
                    marker.ToolTip.Fill = new SolidBrush(prevColor);
                    
                }
                markers.Markers.Add(marker);
                gmap.Overlays.Add(markers);               
            }

            

            



            //pg3 Polygons
            //GMapOverlay polygons = new GMapOverlay("polygons");
            //List<PointLatLng> points = new List<PointLatLng>();
            //points.Add(new PointLatLng(-46.413279, 168.353798));
            //points.Add(new PointLatLng(-46.414529, 168.353864));
            //points.Add(new PointLatLng(-46.414492, 168.359946));
            //points.Add(new PointLatLng(-46.413227, 168.359955));           
            //GMapPolygon polygon = new GMapPolygon(points, "Southern Institute of Technology Invercargill");
            //polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            //polygon.Stroke = new Pen(Color.Red, 1);
            //polygons.Polygons.Add(polygon);
            //gmap.Overlays.Add(polygons);

            //pg3 Routes
            
            //GMapRoute route = new GMapRoute(rpoints, "A walk to PakNSave and the Movies");
            //route.Stroke = new Pen(Color.Red, 3);
            //Console.WriteLine(route.Distance);//return route distance in KM
            //routes.Routes.Add(route);
            //gmap.Overlays.Add(routes);
            //GMapOverlay routes = new GMapOverlay("routes");
            //List<PointLatLng> rpoints = new List<PointLatLng>();
            //foreach (var mark in placeOfInterests)
            //{
            //    rpoints.Add(new PointLatLng(mark.Latitude, mark.Longitude));
            //    GMapRoute route = new GMapRoute(rpoints, "A walk");
            //    route.Stroke = new Pen(Color.Red, 3);
            //    routes.Routes.Add(route);
            //    gmap.Overlays.Add(routes);
            //}

        }//gmap_Load

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Console.WriteLine(string.Format("Marker {0} was clicked.", item.Tag));
        }

        private void gmap_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            Console.WriteLine(string.Format("Polygon {0} with tag {1} was clicked", item.Name, item.Tag));
        }
        
        private void GetLocationData()
        {
            string url = @"http://developer.kensnz.com/getlocdata";
            using (WebClient client = new WebClient())
            {
                var json = client.DownloadString(url);
                JavaScriptSerializer ser = new JavaScriptSerializer();
                var JSONArray = ser.Deserialize<Dictionary<string, string>[]>(json);
                //rTBnotes.AppendText(json + "\n\n");
                foreach (Dictionary<string, string> map in JSONArray)
                {
                    int userid = int.Parse(map["userid"]);
                    double latitude = double.Parse(map["latitude"]);
                    double longitude = double.Parse(map["longitude"]);
                    string description = map["description"];
                    PlaceOfInterest poi = new PlaceOfInterest(userid, latitude, longitude, description);
                    placeOfInterests.Add(poi);
                }
            }
        }//GetLocationData
    }//Class
}//NS
