using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.CoreWeb
{

    public abstract class Element
    {

        internal Search SearchWrapper;
        internal IWebElement Wrapper => DriverManager.Current.FindElement(SearchWrapper);

        #region Properties

        /// <summary>
        /// Gets the innerText of this element, without any leading or trailing whitespace, and with other whitespace collapsed.
        /// </summary>
        public string InnerText => Wrapper.Text;

        #endregion Properties

        #region Methods

        /// <summary>
        /// Clicks this element.
        /// </summary>
        public void Click()
        {
            Wrapper.Click();
            
        }

        #endregion Methods
    }
    public class InputRadioElement:Element
    {
        public bool Selected => Wrapper.Selected;
    }

   
}
