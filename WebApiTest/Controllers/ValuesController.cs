﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET /api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "value3" };
        }

        // GET /api/values/5
        public string Get(int id)
        {
            return "value" + id;
        }

        // POST /api/values
        public void Post(string value)
        {
        }

        // PUT /api/values/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/values/5
        public void Delete(int id)
        {
        }
    }
}