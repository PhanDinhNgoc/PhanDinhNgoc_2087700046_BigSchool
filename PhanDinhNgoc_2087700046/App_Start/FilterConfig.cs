﻿using System.Web;
using System.Web.Mvc;

namespace PhanDinhNgoc_2087700046
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
