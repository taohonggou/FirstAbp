using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstABP.Persons;
using FirstABP.Persons.Dto;

namespace FirstABP.Web.Controllers
{
    public class PersonController : Controller
    {
        private IPersonAppService _personAppService;


        public PersonController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(CreatePersonInput input)
        {
            _personAppService.CreatePerson(input);
            return Content("ok");
        }
    }
}