using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger.Abstract
{
    public interface ILogInitializer
    {
        void Initialize();
        void Seed();
    }
}
