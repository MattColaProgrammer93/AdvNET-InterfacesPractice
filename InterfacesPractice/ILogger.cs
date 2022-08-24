using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractice
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText(@"\myFile.txt", $"{message} [{DateTime.Now}] {Environment.NewLine}");
        }
    }
}
