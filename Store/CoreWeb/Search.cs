using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.CoreWeb
{
    public class Search
    {
        

        internal readonly By Wrapper;

        private Search(By wrapper)
        {
            Wrapper = wrapper;
          
        }

        /// <summary>
        /// Gets a mechanism to find elements by their CSS class.
        /// </summary>
        public static Search ClassName(string className)
        {
            var search = By.ClassName(className);
           return new Search(search);
        }

        /// <summary>
        /// Gets a mechanism to find elements by their cascading style sheet (CSS) selector.
        /// </summary>
        public static Search CssSelector(string cssSelector)
        {
            var search = By.CssSelector(cssSelector);
            return new Search(search);
        }

        /// <summary>
        /// Gets a mechanism to find elements by their ID.
        /// </summary>
        public static Search Id(string id)
        {
            var search = By.Id(id);
            return new Search(search);
        }

        /// <summary>
        /// Gets a mechanism to find elements by their link text.
        /// </summary>
        public static Search LinkText(string linkText)
        {
            var search = By.LinkText(linkText);
            return new Search(search);
        }

        /// <summary>
        /// Gets a mechanism to find elements by their name.
        /// </summary>
        public static Search Name(string name)
        {
            var search = By.Name(name);
            return new Search(search);
        }

        /// <summary>
        /// Gets a mechanism to find elements by a partial match on their link text.
        /// </summary>
        public static Search PartialLinkText(string partialLinkText)
        {
            var search = By.PartialLinkText(partialLinkText);
            return new Search(search);
        }

        /// <summary>
        /// Gets a mechanism to find elements by their tag name.
        /// </summary>
        public static Search TagName(string tagName)
        {
            var search = By.TagName(tagName);
            return new Search(search);
        }

        /// <summary>
        /// Gets a mechanism to find elements by an XPath query. Use ".//" to limit your search to the children of this element.
        /// </summary>
        public static Search XPath(string xPath)
        {
            var search = By.XPath(xPath);
            return new Search(search);
        }

        /// <summary>
        /// Gets a string representation of the finder.
        /// </summary>
        public override string ToString() => Wrapper.ToString();
    }
}
}
