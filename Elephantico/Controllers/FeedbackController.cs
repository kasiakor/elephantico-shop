using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elephantico.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Elephantico.Controllers
{
    public class FeedbackController : Controller
    {

        // this controller will have dependancy on FeedbackRepository
        private readonly IFeedbackRepository _feedbackRepository;

        // inject FeedbackRepository dependency via contructor injection
        public FeedbackController(IFeedbackRepository feedbackRepository)
     
        {
            //local field equals to injected value
            _feedbackRepository = feedbackRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            // if user enetrs data this feedback instance is going o be sent to the controller
            // then pass it on to the repository
            //redirect user to another action FeedbackComplete method to thank him for the feedback
            if (ModelState.IsValid)
            {
                _feedbackRepository.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }
            return View(feedback);
            
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}
