namespace Strategy;

/// <summary>
/// Opens a file with a defined strategy. Acts as the context.
/// </summary>
internal class FileHelper : IContext
{
    public IEncoder Encoder { get; set; }

    public void OpenFile(string path)
    {
        var encoded = this.Encoder.Encode(path);
        Console.WriteLine(encoded);
    }
}
