﻿using System.Web;
using System.Web.Mvc;

namespace Healthy.WA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
