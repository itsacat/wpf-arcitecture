using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDemo.Domain;
using WpfAppDemo.DAL;

namespace WpfAppDemo.Appl
{
    class AddPointUseCase
    {
        public static void Execute(Points Points, Point Point) {
            Points.AddPoint(Point);

            PointsRepository.Save(Points);
        }
    }
}
