using GamingSystem.Models;

namespace GamingSystem;

internal class GamingSystem
{
    public void PlayGames(IPlayable[] games)
    {
        Console.WriteLine("Starting game play:");
        foreach (var game in games)
        {
            game.Play();
        }

        Console.WriteLine("Finished game play.");
    }
}
