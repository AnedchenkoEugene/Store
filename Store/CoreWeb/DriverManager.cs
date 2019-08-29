using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Store.CoreWeb
{
    public static class DriverManager
    {
        private static readonly Dictionary<int, Driver> Instances = new Dictionary<int, Driver>();

        public static Driver Current
        {
            get
            {
                if (!Instances.ContainsKey(Thread.CurrentThread.ManagedThreadId))
                {
                    throw new Exception("Driver instance was not created");
                }
                return Instances[Thread.CurrentThread.ManagedThreadId];
            }
            set => Instances[Thread.CurrentThread.ManagedThreadId] = value;
        }
    }
}
