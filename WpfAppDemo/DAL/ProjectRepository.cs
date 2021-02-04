using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDemo.Domain;

namespace WpfAppDemo.DAL
{
    class ProjectRepository
    {
        public static Project Load(string path) {
            var list = new List<Point>();
            list.Add(new Point(1, 1));
            list.Add(new Point(2, 2));

            var points = new Points(list);

            var project = new Project();

            project.PointsList.Add(points);

            return project;
        }
    }
}
