﻿using System.Web;
using System.Web.Mvc;

namespace u22710362_Practical2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
