using Castle.Windsor;
using Logger.Abstract;
using Logger.Concrete.DatabaseLog;
using Logger.Concrete.EventViewerLog;
using Logger.Concrete.FileLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Castle.MicroKernel.Registration;
using Logger.Concrete.Encryption;

namespace IoCSample
{
    public static class LoggerFactory
    {
        public static WindsorContainer Container { get; private set; }
 
        //public static ILogger LoggerObj { get; private set; }

        static LoggerFactory()
        {
            Container = new WindsorContainer();
            
            //Dependency Injection
            Container.Register(
                Component.For<ILogger>().ImplementedBy<DatabaseLogger>(),
                Component.For<ILogInitializer>().ImplementedBy<DatabaseLogInitializer>(),
                Component.For<IEncryptor>().ImplementedBy<MD5Encryptor>());
            


            //string loggerTypeName = ConfigurationManager.AppSettings["Logger"];
            //Type type = Type.GetType(loggerTypeName);

            //if (type != null)
            //{
            //    object loggerObj = Activator.CreateInstance(type);

            //    if (loggerObj != null && loggerObj is ILogger)
            //    {
            //        LoggerObj = (ILogger)loggerObj;
            //    }
            //}

            //switch (loggerTypeName)
            //{
            //    case "DB":
            //        LoggerObj = new DatabaseLogger();
            //        break;
            //    case "EV":
            //        LoggerObj = new EventViewerLogger();
            //        break;
            //    default:
            //        LoggerObj = new FileLogger();
            //        break;
            //}
        }
    }
}
