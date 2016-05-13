using Frw.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleSearchTest
{
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() : base(BrowserType.Firefox)
        {
            InitializeSettings();
            NavigateSite();
        }
    }
}
