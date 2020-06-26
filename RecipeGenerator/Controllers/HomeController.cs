using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecipeGenerator.Models;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using RecipeGenerator_Models;

namespace RecipeGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RandomRecipe()
        {
            //MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=recipe_generator;port=3306;password=password");
            //try
            //{
            //    string sql = "Select id, title, ingredients, method, imageUrl from recipe where id = 1";
            //    MySqlDataAdapter daRecipe = new MySqlDataAdapter(sql, con);
            //    MySqlCommandBuilder cb = new MySqlCommandBuilder(daRecipe);

            //    DataSet dsRecipe = new DataSet();
            //    daRecipe.Fill(dsRecipe, "Recipe");
            //    List<string> res = dsRecipe.Tables[0].AsEnumerable().Select(m => "abc"+m["title"]).ToList();
            //    ViewBag.recipeTitle = res[0];
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error while fetching data from db: " + ex);
            //}

            RecipeInformation recipeInformation = RecipeGenerator_BL.Recipe.getFirstRecipe();
            ViewBag.recipe = recipeInformation;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
