using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elephantico.Models
{
    public class ElephaitemRepository : IElephaitemRepository
    {
        // we need access to AppDbContext
        // we will pass it via contructing injection
        private readonly AppDBContex _appDbContext;

        public ElephaitemRepository(AppDBContex appDBContex)
        {
            // local instanced eqial to the passed instance
            _appDbContext = appDBContex;
        }

        // the interface is implemented
        public IEnumerable<Elephaitem> GetAllElephaitems()
        {
            // it will check if the list has been already populated, if not it will load data from the db
            //we use the context to return all the Elephaitems from the context
            return _appDbContext.Elephaitems;
        }

        public Elephaitem GetElephaitemById(int elephaitemId)
        {
            return _appDbContext.Elephaitems.FirstOrDefault(e => e.Id == elephaitemId);
        }
    }
}
