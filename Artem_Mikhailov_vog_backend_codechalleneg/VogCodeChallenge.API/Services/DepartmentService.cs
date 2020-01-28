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
        public readonly DataSet _db = new DataSet();
        public DepartmentService() // add EF context here in DI like (IContext Context)
        {              
            _db.Employees = DepartmentDataContext.Employees; // switch to database driven datacontext, for example: _db = DataContext.GetRepo();
            _db.Departments = DepartmentDataContext.Departments;  
        }
        public IEnumerable<Employee> GetAll()
        {

            return _db.Employees;
        }
        public IList<Employee> ListAll()
        {
            return _db.Employees.ToList();
        }
    }
}
