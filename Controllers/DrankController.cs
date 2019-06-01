using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrankAPI.Models;

namespace DrankAPI.Controllers
{
     [Route("api/[controller]")]
    public class DrankController : Controller
    {
            private readonly IDrankRepository _DrankRepository;

            public DrankController(IDrankRepository drankRepository){
                _DrankRepository = drankRepository;
            }
        

            public ViewResult Index(){
                var model = _DrankRepository.GetAllDrank();
                return View(model);
            }

            public ViewResult Details(){
                Drank Model = _DrankRepository.GetDrank(1);
                ViewBag.PageTitle = "Employee Details";
                return View(Model);
            }

    }
}