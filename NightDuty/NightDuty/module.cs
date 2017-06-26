using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace NightDuty
{
    public class module
    {
        // public static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Neeraj\Projects\NightDuty\NightDuty\NightDuty\bin\Debug\MyDatabase\NightDuty.mdf;Integrated Security=True;Connect Timeout=30";
        public static string constr = ConfigurationManager.ConnectionStrings["NightDuty.Properties.Settings.Night_DutyConnectionString"].ConnectionString.ToString();
    }
}