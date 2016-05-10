using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frw.Config
{
    public class ConfigReader
    {
        public static string InitializeTest()
        {
            return ConfigurationManager.AppSettings["URL"].ToString();
        }
    }
}
