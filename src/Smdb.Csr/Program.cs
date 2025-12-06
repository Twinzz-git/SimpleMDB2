// ============================================
// ARCHIVO: src/Smdb.Csr/Program.cs
// ============================================
namespace Smdb.Csr;

public class Program
{
    public static async Task Main()
    {
        App app = new App();
        await app.Start();
    }
}

