using System.Globalization;
using System.IO;
using Loco.Collection.Enclosures;

namespace Loco.Collection.Loggers
{
    class StandardLogger : ILogger
    {
        private const string RootDirectory = @"C:\Files\";
        private const string DataDirectory = "EncData";
        
        public string GetRootDirectory()
        {
            return RootDirectory;
        }

        public string GetDataDirectory()
        {
            return Path.Combine(RootDirectory, DataDirectory);
        }

        public void CreateDirectories()
        {
            if (!Directory.Exists(RootDirectory))
                Directory.CreateDirectory(GetRootDirectory());
            if (!Directory.Exists(GetDataDirectory()))
                Directory.CreateDirectory(GetDataDirectory());
            for (var x = 1; x <= 5; x++)
            {
                var directory = Path.Combine(GetDataDirectory(), x.ToString(CultureInfo.InvariantCulture));
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
            }
        }

        public void StartLogging(IEnclosure enclosure)
        {
            throw new System.NotImplementedException();
        }

        public void StopLogging(IEnclosure enclosure)
        {
            throw new System.NotImplementedException();
        }

        public void Write(IEnclosure enclosure, int enclosureNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}
