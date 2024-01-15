using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delivery.Pattern
{
    public class Proxy : IProxy
    {
        private IProxy proxy;
        public bool IsValid(string username)
        {
            //if (username.Length < 5)
            //{
            //    return false;
            //}

            if (proxy == null)
            {
                proxy = new CheckValid();
            }
            return proxy.IsValid(username);
        }

    }
}