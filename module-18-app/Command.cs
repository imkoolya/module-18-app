using YoutubeExplode;

internal abstract class Command
{
    protected YoutubeClient youtubeClient = new();

    protected string Link { get; set; }

    public abstract Task Run();

    public Command(string link)
    {
        Link = link;
    }
}