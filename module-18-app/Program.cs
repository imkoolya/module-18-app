using System.Text;

class Program
{
    static async Task Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string videoUrl = "https://www.youtube.com/watch?v=0_CDMstFg7M";

        Receiver receiver = new Receiver();
        Sender sender = new();

        sender.SetCommand(new Download(receiver, videoUrl));
        await sender.PressButtonRun();
        Console.WriteLine("Первая операция выполнена");

        sender.SetCommand(new Description(receiver, videoUrl));
        await sender.PressButtonRun();
        Console.WriteLine("Вторая операция выполнена");
    }
}