using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrankAPI.Models;

namespace DrankAPI.Controllers
{


    public class HomeController : Controller
    {
            private readonly IDrankRepository _DrankRepository;

            public HomeController(IDrankRepository drankRepository){
                _DrankRepository = drankRepository;
            }
                
            public ViewResult Index(){
                var model = _DrankRepository.GetAllDrank();
                return View(model);
            }

            public ViewResult Details(int id){
                Drank Model = _DrankRepository.GetDrank(id);
                ViewBag.PageTitle = "Employee Details";
                return View(Model);
            }

    }
}