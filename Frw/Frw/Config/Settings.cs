using Frw.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frw.Config
{
    public static class Settings
    {
        public static string Url { get; set; }

        public static BrowserType BrowserType { get; set; }

        public static SqlConnection ApplicationCon { get; set; }

        public static string AppConnectionString { get; set; }

        public static string IsLog { get; set; }

        public static string LogPath { get; set; }
    }
}
