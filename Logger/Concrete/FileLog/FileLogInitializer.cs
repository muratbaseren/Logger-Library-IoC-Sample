using Logger.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Concrete.FileLog
{
    public class FileLogInitializer : ILogInitializer
    {
        private string logsFolderPath = Path.Combine(Environment.CurrentDirectory, "logs");
        public void Initialize()
        {
            if (Directory.Exists(logsFolderPath) == false)
            {
                Directory.CreateDirectory(logsFolderPath);
            }
        }

        public void Seed()
        {
            string readmeFilePath = Path.Combine(this.logsFolderPath, "readme.txt");

            if(File.Exists(readmeFilePath) == false)
            {
                File.WriteAllText(readmeFilePath, "Bu klasör loglama amaçlı oluşturulmuştur.");
            }
        }
    }
}
