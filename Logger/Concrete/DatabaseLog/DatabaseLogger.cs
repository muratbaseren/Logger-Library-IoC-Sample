using Logger.Abstract;
using Logger.Concrete.DatabaseLog.Context;
using Logger.Concrete.DatabaseLog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger.Concrete.DatabaseLog
{
    public class DatabaseLogger : ILogger
    {
        private ILogInitializer _initializer;
        private IEncryptor _encryptor;

        public DatabaseLogger(ILogInitializer initializer, IEncryptor encryptor)
        {
            _initializer = initializer;
            _encryptor = encryptor;

            _initializer.Initialize();
            _initializer.Seed();
        }

        public void Write(string message)
        {
            using(LoggerDbContext db = new LoggerDbContext())
            {
                LogData logData = new LogData()
                {
                    Message = message
                };

                db.LogDataItems.Add(logData);
                db.SaveChanges();
            }
        }

        public void Write(Exception ex)
        {
            Write(ex.Message);
        }
    }
}
