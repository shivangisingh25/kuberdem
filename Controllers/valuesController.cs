﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace kuberdem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class valuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "kubernetes", "demo","successful" };
        }

    }
}
