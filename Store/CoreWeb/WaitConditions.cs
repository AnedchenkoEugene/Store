using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.CoreWeb
{
    internal static class WaitConditions
    {
        /// <summary>
        /// An expectation for checking that an element is present on the DOM of a page.
        /// </summary>
        public static Func<IWebDriver, IWebElement> ElementExists(By locator)
        {
            return (driver) => driver.FindElement(locator);
        }

    }

}
}
