﻿using System.Web;
using System.Web.Mvc;

namespace COMP2084MidtermW2019
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // force all requests to use ssl
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
