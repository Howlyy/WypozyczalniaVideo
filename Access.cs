﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;


namespace WypożyczalniaVideo
{
    public static class Access
    {
        public static string Connect(string name)
        {
            return ConfigurationManager.ConnectionStrings["Video"].ConnectionString;
        }
    }
}
