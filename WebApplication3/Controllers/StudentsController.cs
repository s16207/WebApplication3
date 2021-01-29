using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : Controller
    {
        [HttpGet]
        public string GetStudents()
        {
            return "Alicja, Patryk, Kupa";
        }
        [HttpGet("{id}")]
        public string GetStudent(int id)
        {
            if(id == 1)
            {
                return "Jan Jeden";
            }

            return "Not found";
        }

    }
}