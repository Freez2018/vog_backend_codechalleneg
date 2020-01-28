using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    //public DepartmentDataContext = _repo
    public interface IDepartmentService
    {
      IEnumerable<Employee> GetAll();
      IList<Employee> ListAll();
    }

    public class DepartmentService : IDepartmentService
    {
        public readonly IEnumerable<Employee> _db;
        public DepartmentService() // add EF context here in DI like (IContext Context)
        {
            _db = DepartmentDataContext.db;
        }
        public IEnumerable<Employee> GetAll()
        {
            
            return _db;
        }
        public IList<Employee> ListAll()
        {
            return null;
        }
    }
}
