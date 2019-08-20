using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elephantico.Models
{
    public interface IElephaitemRepository
    {
        // it will return all items in a method, all elephaitems in data store
        IEnumerable<Elephaitem> GetAllElephaitems();
        //also retrieve items by id
        Elephaitem GetElephaitemById(int elephaitemId);
    }
}
