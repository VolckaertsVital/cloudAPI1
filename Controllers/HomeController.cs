using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrankAPI.Models;
using PagedList;
using PagedList.Mvc;

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
            public ActionResult Index(String searchBy,String search, int? page){
                var model = _DrankRepository.GetAllDrank();
                
                if (searchBy == "Name")
                {
                    return View(model.Where(x => x.name == search || search == null ).ToPagedList(page ?? 1,8));
                }
                else {
                    return View(model.Where(x => x.NameBrand == search  || search == null ).ToPagedList(page ?? 1,8));
                }
                
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
            
            public ViewResult Edit(int id){
                Drank drank = _DrankRepository.GetDrank(id);
                return View();
            }

            [Route("[action]")]
            public IActionResult delete(int id){
                
                var model =_DrankRepository.GetDrank(id);
                _DrankRepository.Remove(model);
                return View();
            }


    }
}