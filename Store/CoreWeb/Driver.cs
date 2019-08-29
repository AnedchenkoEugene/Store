using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.CoreWeb
{

    public class Driver
    {
        
        private const int WaiterTimeoutInSeconds = 60;

        private readonly IWebDriver _wrapper;
        private readonly IWait<IWebDriver> _wait;
        private readonly IJavaScriptExecutor _javaScriptExecutor;
        public enum BrowserType
        {
            Chrome,
            InternetExplorer,
            Firefox
        }

        private Driver(IWebDriver driver)
        {
            _wrapper = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WaiterTimeoutInSeconds));
            _javaScriptExecutor = (IJavaScriptExecutor)driver;
        }

        public static Driver GetFor(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new Driver(new ChromeDriver());

                case BrowserType.InternetExplorer:
                    return new Driver(new InternetExplorerDriver());

                case BrowserType.Firefox:
                    return new Driver(new FirefoxDriver());

                default:
                    throw new Exception("There is no such browser.");
            }
        }

        #region Properties

        /// <summary>
        /// Gets the source of the page last loaded by the browser.
        /// </summary>
        public string PageSource => _wrapper.PageSource;

        /// <summary>
        /// Gets or sets the URL the browser is currently displaying.
        /// </summary>
        public string Url
        {
            get => _wrapper.Url;
            set => _wrapper.Url = value;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Finds the first element using the given method.
        /// </summary>
        internal IWebElement FindElement(Search search)
        {
            var element = _wait.Until(WaitConditions.ElementExists(search.Wrapper));
            return element;
        }

        /// <summary>
        /// Maximizes the current window if it is not already maximized.
        /// </summary>
        public void MaximizeWindow()
        {
            _wrapper.Manage().Window.Maximize();
        }

        /// <summary>
        /// Gets a object representing the image of the page on the screen.
        /// </summary>
        public Screenshot TakeScreenshot()
        {
            var screenshot = _wrapper.TakeScreenshot();
            return screenshot;
        }

        /// <summary>
        /// Quits this driver, closing every associated window.
        /// </summary>
        public void Quit()
        {
            _wrapper.Quit();
        }

        #endregion Methods

    }
