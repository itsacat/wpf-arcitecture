using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDemo.Domain;
using WpfAppDemo.DAL;

namespace WpfAppDemo.Domain
{
    class AddPointUseCase
    {
        public static void Execute(Points Points, Point Point) {
            Points.AddPoint(Point);

            PointsRepository.Save(Points);
        }

        public static void Execute(int PointsId, Point PointId)
        {
            var points = PointsRepository.Load(PointsId);
            var point = PointRepository.Load(PointId);

            points.AddPoint(point);

            PointsRepository.Save(points);
        }
    }
}
