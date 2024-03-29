﻿using System;

namespace Methodlar_Datetime// Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(DateTime.Now);
           Console.WriteLine(DateTime.Now.Day);
           Console.WriteLine(DateTime.Now.Date);
           Console.WriteLine(DateTime.Now.Month);
           Console.WriteLine(DateTime.Now.Year);
           Console.WriteLine(DateTime.Now.Hour);
           Console.WriteLine(DateTime.Now.Minute);
           Console.WriteLine(DateTime.Now.Second);
           Console.WriteLine(DateTime.Now.DayOfWeek);
           Console.WriteLine(DateTime.Now.DayOfYear);
           
           Console.WriteLine(DateTime.Now.ToLongDateString());
           Console.WriteLine(DateTime.Now.ToShortDateString());
           Console.WriteLine(DateTime.Now.ToLongTimeString());
           Console.WriteLine(DateTime.Now.ToShortTimeString());

           Console.WriteLine(DateTime.Now.AddDays(3));
           Console.WriteLine(DateTime.Now.AddHours(4));
           Console.WriteLine(DateTime.Now.AddMilliseconds(100));
           Console.WriteLine(DateTime.Now.AddMinutes(4));
           Console.WriteLine(DateTime.Now.AddMonths(4));
           Console.WriteLine(DateTime.Now.AddSeconds(4));
           Console.WriteLine(DateTime.Now.AddYears(4));

           Console.WriteLine(DateTime.Now.ToString("dd"));
           Console.WriteLine(DateTime.Now.ToString("ddd"));
           Console.WriteLine(DateTime.Now.ToString("dddd"));
           Console.WriteLine(DateTime.Now.ToString("MM"));
           Console.WriteLine(DateTime.Now.ToString("MMM"));
           Console.WriteLine(DateTime.Now.ToString("MMMM"));
           Console.WriteLine(DateTime.Now.ToString("yy"));
           Console.WriteLine(DateTime.Now.ToString("yyyy"));
           
           
           
           
           
           Console.WriteLine(Math.Abs(-25));
           Console.WriteLine(Math.Sin(10));
           Console.WriteLine(Math.Cos(10));
           Console.WriteLine(Math.Tan(10));
           
           
           Console.WriteLine(Math.Ceiling(22.3));
           Console.WriteLine(Math.Round(22.8));
           Console.WriteLine(Math.Floor(22.7));


                      
           Console.WriteLine(Math.Pow(4,2));
           Console.WriteLine(Math.Sqrt(16));
           Console.WriteLine(Math.Log(9));
           Console.WriteLine(Math.Exp(3));
           Console.WriteLine(Math.Log10(100));





           





           

        }
    }
}