using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

internal class Description : Command
{
    private Receiver receiver;

    public Description(Receiver receiver, string link) : base(link)
    {
        receiver = receiver;
    }

    public override async Task Run()
    {
        var description = await youtubeClient.Videos.GetAsync(Link);
    }
}
