using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDemo.DAL;

namespace WpfAppDemo.Domain
{
    class LoadProjectUseCase
    {
        public static void Execute(string path)
        {
            var project = ProjectRepository.Load(path);
        }
    }
}
