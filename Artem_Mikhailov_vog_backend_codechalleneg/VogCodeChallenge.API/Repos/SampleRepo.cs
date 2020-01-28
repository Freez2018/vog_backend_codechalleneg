using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Repos
{  
    public static class SampleRepo
    {   
        public static IEnumerable<Department> Departments
        {
            get
            {
                var departments = new List<Department>();
                departments.Add(new Department
                {
                    Id = "1",
                    DepartmentName = "IT",
                    Address = new Address
                    {
                        Id = "22",
                        AddressLine_1 = "222 Square St",
                        Type = AddressType.Mailing
                    }
                });
                departments.Add(new Department
                {
                    Id = "2",
                    DepartmentName = "Accounting",
                    Address = new Address
                    {
                        Id = "222",
                        AddressLine_1 = "22332 Square St",
                        Type = AddressType.Mailing
                    }
                });
                departments.Add(new Department
                {
                    Id = "3",
                    DepartmentName = "Warehouse",
                    Address = new Address
                    {
                        Id = "111",
                        AddressLine_1 = "777 Square St",
                        Type = AddressType.Mailing
                    }
                });        

                return departments;
            }
        }
        public static IEnumerable<Employee> Employees
        {
            get
            {
                var employess = new List<Employee>();
                employess.Add(new Employee
                {
                    Id = "1",
                    FirstName = "John",
                    LastName = "Johns",
                    JobTitle = "Administrator",
                    Address = new Address
                    {
                        Id = "1",
                        AddressLine_1 = "999 Ball St",
                        Type = AddressType.Mailing
                    },
                    Department = Departments.ToList()[0]
                });
                employess.Add(new Employee
                {
                    Id = "2",
                    FirstName = "John2",
                    LastName = "Johns2",
                    JobTitle = "Accountant",
                    Address = new Address
                    {
                        Id = "1",
                        AddressLine_1 = "999 Ball St",
                        Type = AddressType.Mailing
                    },
                    Department = Departments.ToList()[0]
                });
                employess.Add(new Employee
                {
                    Id = "3",
                    FirstName = "John3",
                    LastName = "Johns3",
                    JobTitle = "Administrator1",
                    Address = new Address
                    {
                        Id = "1",
                        AddressLine_1 = "9999 Ball St",
                        Type = AddressType.Mailing
                    },
                    Department = Departments.ToList()[1]
                });
                employess.Add(new Employee
                {
                    Id = "4",
                    FirstName = "John",
                    LastName = "Johns",
                    JobTitle = "Administrator",
                    Address = new Address
                    {
                        Id = "1",
                        AddressLine_1 = "999 Ball St",
                        Type = AddressType.Mailing
                    },
                    Department = Departments.ToList()[1]
                });
                employess.Add(new Employee
                {
                    Id = "5",
                    FirstName = "John5",
                    LastName = "Johns5",
                    JobTitle = "Director",
                    Address = new Address
                    {
                        Id = "1",
                        AddressLine_1 = "999 Ball St",
                        Type = AddressType.Mailing
                    },
                    Department = Departments.ToList()[2]
                });

                return employess;
            }
        }
    }
}
  
