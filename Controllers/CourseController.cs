using Microsoft.AspNetCore.Mvc;
using CourseProject.Models;

namespace CourseProject.Controllers
{
    public class CourseController :  Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidate model) //veri formdan geliyo
        {
            Repository.Add(model);
            return Redirect("/");
        }
    }
}