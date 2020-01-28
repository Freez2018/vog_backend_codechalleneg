using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public interface IDepartmentService
    {
      IEnumerable<Employee> GetAll();
      IList<Employee> ListAll();
    }

    public class DepartmentService : IDepartmentService
    {
        public IEnumerable<Employee> GetAll()
        {
            return null;
        }
        public IList<Employee> ListAll()
        {
            return null;
        }
    }
}
