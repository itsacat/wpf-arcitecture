using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDemo.Domain
{
    class PointsSumService
    {
        internal static Points Sum(Points Point1, Points Point2) {
            var list = new List<Point>();
            list.Add(new Point(1, 1));
            list.Add(new Point(2, 2));

            return new Points(list);
        }
    }
}
