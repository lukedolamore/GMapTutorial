using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMapTutorial
{
    class PlaceOfInterest : IComparable<PlaceOfInterest>
    {
        public int UserID { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public PlaceOfInterest (int userid, double latitude, double longitude, string description)
        {
            UserID = userid;
            Latitude = latitude;
            Longitude = longitude;
            Description = description;
        }

        int IComparable<PlaceOfInterest>.CompareTo(PlaceOfInterest other)
        {
            return UserID - other.UserID;
        }

    }
}
