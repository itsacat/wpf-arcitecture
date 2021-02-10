using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralClassLibrary;
using System.Collections.ObjectModel;
using WpfAppDemo.Domain.Entity.Accessory;

namespace WpfAppDemo.Domain
{
    class Points : ObservableCollection<Point>
    {
        public string id;
        public readonly PointsAccessory accessory;

        public List<Point> List 
        { get { return points; } }

        private List<Point> points = new List<Point>();

        public Points(List<Point> Points)
        {
            points = Points;
            accessory = new PointsAccessory();
        }

        internal void AddPoint(Point Point)
        {
            Point.X = 1;
            if (List.Count > 10)
            {
                throw new Exception();
            }
            base.Add(Point);
        }
    }
}
