﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    //GET http://localhost:5000/api/values

    [Authorize] //That's this controller is protected, only authorize user can access by Token
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //Read from Database
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }


     // GET api/values  
        //[AllowAnonymous] //That's this particular method allowed access without Token aunthentication  
        [HttpGet]

        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        /* 
         public IActionResult GetValues()
        {
            var values = _context.Values.ToList();
            return Ok(values);
        }
        */

        /* 
        public ActionResult<IEnumerable<string>> Get()
        {
            //throw new Exception ("hey is exception");
            return new string[] { "value1loooo", "value44dss4" };
        }
        */

        // GET api/values/5
        [HttpGet("{id}")]
         public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync (x => x.Id == id);
            return Ok(value);
        }

        /*
        public IActionResult GetValue(int id)
        {
            var value = _context.Values.FirstOrDefault (x => x.Id == id);
            return Ok(value);
        }
        */

        /*
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
        */


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
