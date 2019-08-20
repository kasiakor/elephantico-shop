using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elephantico.Models
{
    public class Elephaitem
    {

        // models - list of classes that make up the domain data plus classes to manage data (repository class) plain CLR classes or POCO classes, Elephantiem is a domain class, they have no base class - POCO
        // repository class manages that data  abstract the detail how data persistance performance
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsElephaitemOfTheWeek { get; set; }

    }
}
