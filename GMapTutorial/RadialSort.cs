using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMapTutorial
{
    class RadialSort : IComparer<PlaceOfInterest>
    {
        public PlaceOfInterest A { get; set; }
        public RadialSort (PlaceOfInterest a)
        {
            A = a;
        }

        int IComparer<PlaceOfInterest>.Compare(PlaceOfInterest b, PlaceOfInterest c)
        {
            //x = lat
            //y = lng
            double ABBA = (A.Latitude * b.Longitude) - (b.Latitude * A.Longitude) + (b.Latitude * c.Longitude) - (c.Latitude * b.Longitude) + (c.Latitude * A.Longitude) - (A.Latitude * c.Longitude);
            if (ABBA == 0)
            {
                double d1 = GetDistance(A.Latitude, A.Longitude, b.Latitude, b.Longitude);
                double d2 = GetDistance(A.Latitude, A.Longitude, c.Latitude, c.Longitude);
                return d1.CompareTo((d2));
            }
            return (int)ABBA;
        }


        public double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}
