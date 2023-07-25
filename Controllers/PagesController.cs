// Include necessary libraries and services
using Microsoft.AspNetCore.Mvc;
using GameInfoApp.Services;

// Namespace for the application
namespace GameInfoApp.Controllers
{
    // Game Controller class inheriting from the base Controller class
    public class PagesController : Controller
    {
        // Private readonly variable for GameService
        private readonly GameService _gameService;

        // Constructor for GameController, accepting GameService as a parameter
        public PagesController(GameService gameService)
        {
            _gameService = gameService;  // Assigning the service to the private variable
        }

        // Action method to handle the Index view
        public IActionResult Index()
        {
            var games = _gameService.GetGames(); // Retrieve games from the service
            return View(games); // Pass the games data to the Index view
        }

        // Action method to handle the About view
        public IActionResult About()
        {
            return View(); // Return the About view
        }
    }
}
