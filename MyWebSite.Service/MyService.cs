using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebSite.Data;
using MyWebSite.Domain;

namespace MyWebSite.Service
{
    public class MyService : IMyService
    {
        private IMyEntity1Repository _repo;

        public MyService(IMyEntity1Repository repo)
        {
            _repo = repo;
        }

        public IList<Entity1> Entities1()
        {
            return _repo.GetAll();
        }
    }
}
