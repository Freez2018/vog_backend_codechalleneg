using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Repos;

namespace VogCodeChallenge.API.Models
{
    public interface IDepartmentDataContext
    {
        IEnumerable<Employee> Employees();

    }

    public static class DepartmentDataContext //: IDepartmentDataContext
    {
        public static IEnumerable<Employee> db = SampleRepo.Employees;
        //switch to EF here...
    }
}
