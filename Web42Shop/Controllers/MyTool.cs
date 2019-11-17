﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Web42Shop.Controllers
{
    public class MyTool
    {
    }

    public static class StaticClass
    {
        /*public static string ToVND(this double dongia)
        {
            return $"{dongia.ToString("#,##0")} đ";
        }*/

        public static string ToUrlFriendly(this string tieuDe)
        {
            string str = tieuDe.ToLower().Trim();

            //thay thế tiếng Việt
            str = Regex.Replace(str, @"[áàảạãăắằẳẵặâấầẩẫậ]", "a");

            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            str = Regex.Replace(str, @"\s+", "-").Trim();
            str = Regex.Replace(str, @"\s", "-");
            return str;
        }
    }
}