using Microsoft.AspNetCore.Mvc;
using necore.model;

namespace necore.Controllers
{
    public class HomeController :Controller
    {
        private IstudentRep _emprep;

        public HomeController(IstudentRep emprep)
        {
            _emprep = emprep;
        }

        [Route("")]
        [Route("home")]
        [Route("home/index")]
        public ViewResult Index()
        {
            var model = _emprep.allStudent();
            return View(model);
        }

        [Route("home/details/{id?}")]
        public ViewResult Details(int? id)
        {
            student stu = _emprep.GetStudent(id?? 1);
            ViewBag.desc = "Student Data";
            return View(stu);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(student s)
        {
           student stu= _emprep.add(s);
           return RedirectToAction("Details", new { id = s.id });
        }
        [HttpGet]
        public ViewResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(login l)
        {
            
            student c = _emprep.Search(l.id, l.Password);
            if (c!=null)
            {
                return new JsonResult(c);
            }
            else
            {
                ViewBag.ErrorMessage = "Incorrect Username Password";
                return Json("Incorrect username and password");
            }

        }

    }
}
