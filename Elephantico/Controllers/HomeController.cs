using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elephantico.Models;
using Elephantico.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Elephantico.Controllers
{
    public class HomeController : Controller
    {
        // controller is a method that will be invoked when the request s recived
        // it will return a view as a result
        // it will make use of the repository
        // it will recieve it through a constructor parameter// dependency injection system will take care of it// the instance it will be provided
        // this way the view will receive some data
        // will use repositories to talk to the model

        // create the repository below!
        private readonly IElephaitemRepository _elephaitemRepository;
        // GET: /<controller>/
        // controller will use repository to talk to the model
        // initialize repository in the constructor
        // hc will need IERepository when it is created
        // hc needs it and dependency injection will fulfill it
        public HomeController(IElephaitemRepository elephaitemRepository)
        {
            // the local repository equals the passed repository
            _elephaitemRepository = elephaitemRepository;
        }

        public IActionResult Index()
        {
            
            // we pass data directly
            var elpehaitems = _elephaitemRepository.GetAllElephaitems().OrderBy(e => e.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Elephantico",
                Elephaitems = elpehaitems.ToList()
            };
            return View(homeViewModel);
        }
    }
}
