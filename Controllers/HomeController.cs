using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcApp.Models;

namespace AspNetCoreMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private static List<Submission> Submissions = new List<Submission>();

        public IActionResult Index()
        {
            ViewData["Message"] = "Hello world";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Hello world";
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Submission submission)
        {
            if (ModelState.IsValid)
            {
                submission.Id = Submissions.Count + 1;
                Submissions.Add(submission);
                return RedirectToAction("SubmissionList");
            }
            return View(submission); // Return with validation errors
        }


        public IActionResult SubmissionList(string? filter)
        {
            ViewData["Message"] = "Hello world";
            var filteredList = string.IsNullOrEmpty(filter)
                ? Submissions
                : Submissions.Where(s => s.Name.Contains(filter)).ToList();
            return View(filteredList);
        }
    }
}
