using Frw.Base;
using Frw.Config;
using Frw.Helpers;
using TechTalk.SpecFlow;

namespace GoogleSearchTest
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() : base(BrowserType.Firefox)
        {
            InitializeSettings();
//            Settings.ApplicationCon = Settings.ApplicationCon.DBConnect(Settings.AppConnectionString);
         }
        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }
    }
}
