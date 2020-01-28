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

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeDto>> GetEmployees()
        {
            var data= _departmentService.GetAll();
            return Ok(data);
        }

        // GET api/values/5
        [HttpGet("department/{id}")]
        public ActionResult<string> GetEmployees(int id)
        {
            return "value";
        }
       
    }
}
