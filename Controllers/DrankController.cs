using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrankAPI.Models;
using DrankAPI.Services;

namespace DrankAPI.Controllers
{
     [Route("api/[controller]")]
    public class DrankController : Controller
    {

        DrankService _DrankService;


        public DrankController(DrankService drankService)
        {
            this._DrankService = drankService;
        }

         // GET api/drank
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._DrankService.GetDranks());
        }

        [HttpPost]
        public ActionResult Post(Drank drank)
        {
            this._DrankService.AddDrank(drank);
            return Ok();
        }

    }
}