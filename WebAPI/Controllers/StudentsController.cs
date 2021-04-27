﻿using DataService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class StudentsController : CrudApiController<Student>
    {
        public StudentsController(IService<Student> service) : base(service)
        {
        }

        [HttpGet("{id}", Name = "StudentsController_Get")]
        public override IActionResult Get(int id)
        {
            return base.Get(id);
        }
    }
}
