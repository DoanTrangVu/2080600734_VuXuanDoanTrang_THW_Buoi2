﻿using System.Web;
using System.Web.Mvc;

namespace _2080600734_VuXuanDoanTrang_QuanLySach
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
