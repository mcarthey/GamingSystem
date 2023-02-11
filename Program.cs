using GamingSystem.Models;

namespace GamingSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        var videoGame1 = new VideoGame {Name = "Elden Ring"};
        var videoGame2 = new VideoGame {Name = "God of War"};
        var videoGame3 = new VideoGame {Name = "Super Mario Odyssey"};
        var boardGame1 = new BoardGame {Name = "Monopoly"};
        var boardGame2 = new BoardGame {Name = "Settlers of Catan"};
        var boardGame3 = new BoardGame {Name = "Betrayal at House on the Hill"};

        IPlayable[] games = {videoGame1, videoGame2, videoGame3, boardGame1, boardGame2, boardGame3};

        var gamingSystem = new GamingSystem();
        gamingSystem.PlayGames(games);
    }
}
