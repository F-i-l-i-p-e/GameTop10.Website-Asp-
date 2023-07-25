// Include necessary libraries
using System;

// Namespace for the application
namespace GameInfoApp.Models
{
    // Public class for GameModel
    public class GameModel
    {
        public int Id { get; set; } // Unique Identifier for each game
        public string Name { get; set; } // Name of the game
        public string Genre { get; set; } // Genre of the game
        public string ImageUrl { get; set; } // URL of the game's image
        public string Description { get; set; } // Description of the game
    }
}
