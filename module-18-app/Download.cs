using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

internal class Download : Command
{
    private Receiver receiver;

    public Download(Receiver receiver, string link) : base(link)
    {
        receiver = receiver;
    }

    public override async Task Run()
    {
        var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(Link);
        var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
        await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
    }
}