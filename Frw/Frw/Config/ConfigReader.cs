using Frw.Base;
using System;
using System.IO;
using System.Xml.XPath;

namespace Frw.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            XPathItem url;
            XPathItem browserType;
            XPathItem isLog;
            XPathItem logPath;
            XPathItem appConnection;

            string strFileName = Environment.CurrentDirectory.ToString() +
                @"\Config\GlobalConfig.xml";
            FileStream stream = new FileStream(strFileName, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XpathItem type variables
            url = navigator.SelectSingleNode("Frw/RunSettings/URL");
            browserType = navigator.SelectSingleNode("Frw/RunSettings/Browser");
            isLog = navigator.SelectSingleNode("Frw/RunSettings/IsLog");
            logPath = navigator.SelectSingleNode("Frw/RunSettings/LogPath");
            appConnection = navigator.SelectSingleNode("Frw/RunSettings/ApplicationDb");

            //Set XML Details in the property to be used across framework
            Settings.Url = url.ToString();
            Settings.BrowserType = (BrowserType) Enum.Parse(typeof(BrowserType), browserType.ToString());
            Settings.IsLog = isLog.ToString();
            Settings.LogPath = logPath.ToString();
            Settings.AppConnectionString = appConnection.Value.ToString();
        }
    
    }
}
