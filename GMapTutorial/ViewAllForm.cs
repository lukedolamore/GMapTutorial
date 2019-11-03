using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace GMapTutorial
{
    public partial class ViewAllForm : Form
    {
        List<PlaceOfInterest> placeOfInterests = new List<PlaceOfInterest>();

        public ViewAllForm()
        {
            InitializeComponent();
            listViewPOI.View = View.Details;
            listViewPOI.Columns.Add("UserID", -2, HorizontalAlignment.Left);
            listViewPOI.Columns.Add("Latitude", -2, HorizontalAlignment.Left);
            listViewPOI.Columns.Add("Longitude", -2, HorizontalAlignment.Left);
            listViewPOI.Columns.Add("Description", -2, HorizontalAlignment.Left);
            GetLocationData();
        }

        private void GetLocationData()
        {
            string url = @"http://developer.kensnz.com/getlocdata";
            using (WebClient client = new WebClient())
            {
                var json = client.DownloadString(url);
                JavaScriptSerializer ser = new JavaScriptSerializer();
                var JSONArray = ser.Deserialize<Dictionary<string, string>[]>(json);
                foreach (Dictionary<string, string> map in JSONArray)
                {
                    int userid = int.Parse(map["userid"]);
                    double latitude = double.Parse(map["latitude"]);
                    double longitude = double.Parse(map["longitude"]);
                    string description = map["description"];
                    PlaceOfInterest poi = new PlaceOfInterest(userid, latitude, longitude, description);
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = (poi.UserID.ToString());
                    listViewItem.SubItems.Add(poi.Latitude.ToString());
                    listViewItem.SubItems.Add(poi.Longitude.ToString());
                    listViewItem.SubItems.Add(poi.Description.ToString());
                    listViewPOI.Items.Add(listViewItem);
                    placeOfInterests.Add(poi);
                }
            }
        }//GetLocationData
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
