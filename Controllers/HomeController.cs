using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrankAPI.Models;

namespace DrankAPI.Controllers
{

    [Route("[controller]")] 
    public class HomeController : Controller
    {
            private readonly IDrankRepository _DrankRepository;

            public HomeController(IDrankRepository drankRepository){
                _DrankRepository = drankRepository;
            }
            [Route("")]
            [Route("[action]")]
            [Route("~/")]
            public ViewResult Index(String search){
                var model = _DrankRepository.GetAllDrank();
                return View(model);

                //.Where(x => x.name.Contains(search));
            }

            [Route("[action]/{id?}")]
            public ViewResult Details(int? id){
                Drank Model = _DrankRepository.GetDrank(id??1);
                ViewBag.PageTitle = "Employee Details";
                return View(Model);
            }

            [Route("[action]")]
            [HttpGet]
            public ViewResult Create(){
                return View();
            }

            [Route("[action]")]
            [HttpPost]
            public IActionResult Create(Drank drank){
                if (ModelState.IsValid)
                {
                    Drank newDrank =  _DrankRepository.Add(drank);
                    return RedirectToAction("details", new { id =  newDrank.Id});
                }

                return View();
            }

            [Route("[action]")]
            
            public ViewResult Edit(){
                return View();
            }

    }
}