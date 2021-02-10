using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDemo.Domain;

namespace WpfAppDemo.DAL
{
    class PointRepository
    {
        public static void Save(Point Points) { }
        public static Point Load(int id)
        {
            return new Point(1, 1);
        }
    }
}
