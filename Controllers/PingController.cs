﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TodoMvc.Controllers
{
    public class PingController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}