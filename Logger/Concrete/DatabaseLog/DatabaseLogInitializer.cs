using Logger.Abstract;
using Logger.Concrete.DatabaseLog.Context;
using Logger.Concrete.DatabaseLog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Concrete.DatabaseLog
{
    public class DatabaseLogInitializer : ILogInitializer
    {
        private bool isDbNotExists = false;

        public void Initialize()
        {
            LoggerDbContext db = new LoggerDbContext();
            this.isDbNotExists = db.Database.CreateIfNotExists();
        }

        public void Seed()
        {
            if(this.isDbNotExists)
            {
                LoggerDbContext db = new LoggerDbContext();

                for (int i = 0; i < 3; i++)
                {
                    LogData logData = new LogData()
                    {
                        Message = "Bu bir örnek log kaydıdır.(" + i.ToString() + ")"
                    };

                    db.LogDataItems.Add(logData);
                }

                db.SaveChanges();
            }
        }
    }
}
