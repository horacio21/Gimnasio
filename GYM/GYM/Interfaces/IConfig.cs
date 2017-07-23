using SQLite.Net.Interop;

namespace Sports.Interfaces
{
    public interface IConfig
    {
        string DirectoryDB { get; }

        ISQLitePlatform Platform { get; }
    }
}
