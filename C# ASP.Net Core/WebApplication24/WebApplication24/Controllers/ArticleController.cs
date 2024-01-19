using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.DataClassification;
using WebApplication24.Data;

namespace WebApplication24.Controllers
{
    public class DataViewModel
    {
        public int UsersCount { get; set; }
        public string ParametherValue { get; set; }
    }

    public class ArticlesController : Controller
    {
        private ApplicationDbContext dbContext;
        public ArticlesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [HttpPost]
        [ActionName("ById")]
        public IActionResult FalseName(string name)
        {
            var viewModel = new DataViewModel();
            viewModel.UsersCount = this.dbContext.Users.Count();
            viewModel.ParametherValue = name;

            return this.View(viewModel);
        }
    }
}
