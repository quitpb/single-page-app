using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using single_page_app.Models;

namespace single_page_app.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            return new MovieModel();
       }

        [HttpGet]
        public object Get1()
        {
            return new { Name = "asda"};
        }

    }
}
