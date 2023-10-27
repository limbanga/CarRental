using MathNet.Numerics.Statistics.Mcmc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Helper
{
    public static class DateHelper
    {
        public static int CountDayInclusive(DateTime start, DateTime to)
        {
            return (int)Math.Ceiling((to.Date - start.Date).TotalDays + 1);
        }
    }
}
