internal class Sender
{
    Command Command { get; set; }

    public void SetCommand(Command command)
    {
        Command = command;
    }

    public async Task PressButtonRun()
    {
        if (Command != null)
        {
            await Command.Run();
        }
    }
}