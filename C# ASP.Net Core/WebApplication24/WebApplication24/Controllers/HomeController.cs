using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication24.Models;
using WebApplication24.Serivice;
using WebApplication24.ViewModels.Home;

namespace WebApplication24.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IShortSevice shortString;

        public HomeController(ILogger<HomeController> logger, IShortSevice shortString)
        {
            _logger = logger;
            this.shortString = shortString;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            viewModel.FirstName = "Nikola";
            viewModel.TimeGiver = DateTime.Now;
            viewModel.Description = "A descriptive text usually describes a single location, object, event, person, or place. It endeavors to engage all five of the reader’s senses to evoke the sights, sounds, smells, tastes, and feel of the text’s subject.\r\n\r\n";

            //viewModel.Description = this.shortString.GetShortDescription(viewModel.Description, 20);

            return View(viewModel);
        }

        [Authorize]
        public IActionResult Privacy()
        {
            //"Index", new IndexViewModel()
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}