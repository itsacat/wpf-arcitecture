﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDemo.Domain;

namespace WpfAppDemo.DAL
{
    class PointsRepository
    {
        public static void Save(Points Points) { }
        public static Points Load(int id)
        {
            var list = new List<Point>();
            list.Add(new Point(1, 1));
            list.Add(new Point(2, 2));

            return new Points(list);
        }
    }
}
