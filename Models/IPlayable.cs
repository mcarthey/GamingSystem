namespace GamingSystem.Models;

internal interface IPlayable
{
    public string Name { get; set; }

    void Play();
}
