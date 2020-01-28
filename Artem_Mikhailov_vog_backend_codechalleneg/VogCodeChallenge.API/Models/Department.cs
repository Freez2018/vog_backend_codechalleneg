using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Department
    {
        public string Id { get; set; }
        public string DepartmentName { get; set; }
        public Address Address { get; set; }
    }
}
