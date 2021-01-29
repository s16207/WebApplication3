﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
