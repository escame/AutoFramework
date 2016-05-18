using OpenQA.Selenium.Support.PageObjects;

namespace Frw.Base
{
    public abstract class BasePage : Base
    {
        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }
    }
}
