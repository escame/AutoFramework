using Frw.Config;
using Frw.Helpers;

namespace Frw.Base
{
    public abstract class BaseStep : Base
    {

        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.Url);
            LogHelpers.Write("Opened the browser!");
        }
    }
}
