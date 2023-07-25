// Include necessary libraries and models
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using GameInfoApp.Models;

// Namespace for the services
namespace GameInfoApp.Services
{
    // Public class for GameService
    public class GameService
    {
        // Constant string holding the path of the JSON file
        private const string JsonFileName = "wwwroot/data/Games.json";

        // Method to get a list of games
        public List<GameModel> GetGames()
        {
            // Open and read the JSON file
            using var jsonFileReader = File.OpenText(JsonFileName);
            // Deserialize the JSON to a list of game models
            return JsonSerializer.Deserialize<List<GameModel>>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    // Case-insensitive deserialization
                    PropertyNameCaseInsensitive = true
                });
        }
    }
}
