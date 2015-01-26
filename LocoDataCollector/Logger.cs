using System;
using System.IO;

namespace LocoDataCollector
{
    public class Logger
    {
        public bool IsLogging { get; set; }
        public string Filename = "";
        public int EnclosureNumber, SampleCount, SampleLimit;
        public string Folder = "";
        public string FileExtension = ".txt";
        public DateTime DateEnd;
        protected StreamWriter Writer;
        public Logger(int enclosureNum)
        {
            EnclosureNumber = enclosureNum;
        }
        
        public void StartLog(int hours, int minutes)
        {
            // Assumption: FEZ will sample at 2Hz, therefore 120 samples per minute.
            SampleLimit = (minutes * 120) + ((hours * 60) * 120);
            SampleCount = 0;
            var dtNow = DateTime.Now;
            DateEnd = dtNow.AddHours(hours);
            DateEnd = DateEnd.AddMinutes(minutes);
            Folder = "C:\\Files\\EncData\\" + EnclosureNumber + "\\";
            Filename = "Enc0" + EnclosureNumber + "_" + FixDate(DateTime.Now.ToShortDateString()) + "_";
            var count = 1;
            while (File.Exists(Folder + Filename + count + FileExtension))
            {
                count++;
            }
            Filename = Filename + count + FileExtension;
            Writer = new StreamWriter(GetFullPath(), true);
            IsLogging = true;
        }

        public DateTime GetTime()
        {
            return DateEnd;
        }

        public string FixDate(string date)
        {
            var split = date.Split('/');
            return split[2] + (split[1].Length == 1 ? "0" : "") + split[1] + (split[0].Length == 1 ? "0" : "") + split[0];
        }

        public override string ToString()
        {
            return "Enclosure0" + EnclosureNumber + ", " + Filename + ", " + DateEnd.ToLongTimeString();
        }

        public string GetFilename()
        {
            return Filename;
        }

        public string GetFullPath()
        {
            return Folder + Filename;
        }

        public string GetFolder()
        {
            return Folder;
        }

        public void EndLog()
        {
            IsLogging = false;
            if (Writer != null) Writer.Dispose();
        }

        public void LogData(string output)
        {
            SampleCount++;
            Writer.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " " + output);
            if (SampleCount == SampleLimit)
            {
                IsLogging = false;
                Writer.Dispose();
            }
        }
    }
}
