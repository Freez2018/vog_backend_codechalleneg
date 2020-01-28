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
        public static IEnumerable<Employee> Employees
        {
            get
            {
                var employess = new List<Employee>();
                employess.Add(new Employee { Id = "1", FirstName = "John", LastName = "Johns", JobTitle = "Administrator", Address = new Address {
                    Id = "1",
                    AddressLine_1 = "999 Ball St",
                    Type = AddressType.Mailing
                } });
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
                    }
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
                    }
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
                    }
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
                    }
                });

                return employess;
            }
        }


    }
}
  
