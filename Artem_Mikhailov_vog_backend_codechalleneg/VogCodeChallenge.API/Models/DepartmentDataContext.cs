using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Repos;

namespace VogCodeChallenge.API.Models
{
    public class DataSet
    {
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }

    public class DepartmentDataContext 
    {
        public static IEnumerable<Employee> db = SampleRepo.Employees;
        public static IEnumerable<Employee> Employees = SampleRepo.Employees;
        public static IEnumerable<Department> Departments = SampleRepo.Departments;
        
    }
    
}
