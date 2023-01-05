using CollegeNoteApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CollegeNoteApp.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Calculate()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Calculate(CalculateViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Percent1 + model.Percent2 != 100)
                {
                    ModelState.AddModelError("", "Percent - 1 and Percent - 2 can be 100.");
                }
                else
                {
                    model.AverageExamScore = (model.Exam1 * model.Percent1 / 100) + (model.Exam2 * model.Percent2 / 100);

                    if (model.AverageExamScore > 50)
                    {
                        model.AverageExamStatus = "Success";
                    }
                    else
                    {
                        model.AverageExamStatus = "Not Success";
                    }
                }
            }

            return View(model);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}