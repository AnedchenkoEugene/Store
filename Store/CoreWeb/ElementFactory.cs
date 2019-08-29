using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.CoreWeb
{
    public static class ElementFactory
    {

        public static T Create<T>(Search search) where T : Element, new()
        {
            var element = new T { SearchWrapper = search };
            Info($"Element was created (search = `{search}`, element = `{element}`)");
            return element;
        }
    }
}
