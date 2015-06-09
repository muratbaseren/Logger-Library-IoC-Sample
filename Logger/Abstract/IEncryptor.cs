using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger.Abstract
{
    public interface IEncryptor
    {
        string Encrypt(string s);
        string Decrypt(string s);
    }
}
