namespace GamingSystem.Models;

internal class BoardGame : IPlayable
{
    public string Name { get; set; }

    public void Play()
    {
        Console.WriteLine($"Playing board game: {Name}");
    }
}
