using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralClassLibrary;
using System.Collections.ObjectModel;

namespace WpfAppDemo.Domain
{
    class Points : ObservableCollection<Point>
    {
        public List<Point> List 
        { get { return points; } }

        private List<Point> points = new List<Point>();

        public Points(List<Point> Points)
        {
            points = Points;
        }

        public void AddPoint(Point Point)
        {
            if (List.Count > 10)
            {
                throw new Exception();
            }
            base.Add(Point);
        }
    }
}
