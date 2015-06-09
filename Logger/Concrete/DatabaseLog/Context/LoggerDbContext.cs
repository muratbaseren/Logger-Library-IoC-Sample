using Logger.Concrete.DatabaseLog.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Concrete.DatabaseLog.Context
{
    public class LoggerDbContext : DbContext
    {
        public DbSet<LogData> LogDataItems { get; set; }
    }
}
