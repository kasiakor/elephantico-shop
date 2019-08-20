using Elephantico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elephantico.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Elephaitem> Elephaitems { get; set; }
    }
}
