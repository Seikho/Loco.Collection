using Loco.Collection.Enclosures;

namespace Loco.Collection.Loggers
{
    interface ILogger
    {
        string GetRootDirectory();
        string GetDataDirectory();
        string CreateDirectories();
        void StartLogging(IEnclosure enclosure);
        void StopLogging(IEnclosure enclosure);
        void Write(IEnclosure enclosure, int enclosureNumber);
    }
}
