namespace GamingSystem.Models;

internal class VideoGame : IPlayable
{
    public string Name { get; set; }

    public void Play()
    {
        Console.WriteLine($"Playing video game: {Name}");
    }
}
