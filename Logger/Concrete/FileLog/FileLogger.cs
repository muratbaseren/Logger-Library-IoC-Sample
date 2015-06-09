using Logger.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger.Concrete.FileLog
{
    public class FileLogger : ILogger
    {
        private ILogInitializer _initializer;
        private IEncryptor _encryptor;

        public FileLogger(ILogInitializer initializer, IEncryptor encryptor)
        {
            _initializer = initializer;
            _encryptor = encryptor;

            _initializer.Initialize();
            _initializer.Seed();
        }

        public void Write(string message)
        {
            string fileName = DateTime.Now.ToString("yyyy_MM_dd") + ".txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, "logs", fileName);

            File.AppendAllText(filePath, message + Environment.NewLine + Environment.NewLine);
        }

        public void Write(Exception ex)
        {
            Write(ex.Message);
        }
    }
}
