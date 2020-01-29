using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Models.DTOs;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        public readonly IDepartmentService _departmentService;
        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("employees/")]
        public ActionResult<IEnumerable<EmployeeDto>> GetEmployees()
        {            
            var data = _departmentService.GetAll().ToArray();

            List<EmployeeDto> employees = new List<EmployeeDto>();
            for (var i = 0; i < data.Length; i++)
            {
                employees.Add(new EmployeeDto
                {
                    Id = data[i].Id,
                    FirstName = data[i].FirstName,
                    LastName = data[i].LastName,
                    JobTitle = data[i].JobTitle,
                    Department = data[i].Department.DepartmentName,
                    Address = data[i].Address.AddressLine_1
                });
            }           
           
            return Ok(employees);
        }

        // GET https://localhost:44349/api/departments/department/1
        [HttpGet("department/{department}")]
        public ActionResult<string> GetEmployees(string department)
        {             
            var data = _departmentService.GetAll()
                        .Where(x => x.Department.Id == department);
            return Ok(data);
        }       
    }
}
