﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FrbaCrucero.Util
{
    class DateUtils
    {
        static String format = "yyyy-MM-dd hh:mm:ss";

        public static String stringFromDate(DateTime time)
        {
            return time.ToString(format);
        }

        public static DateTime getDateFromConfig()
        {
            return DateTime.Parse(ConfigurationManager.AppSettings["current_date"].ToString());
        }
    }
}
