// See https://aka.ms/new-console-template for more information
namespace Smdb.Api;

public class Program
{
    public static async Task Main()
    {
        App app = new App();
        await app.Start();
    }
}

