using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public class GetDateTime
    {
        public static DateTime GetDateTimes(string inputDataTime)
        {
            var inputDayMountYear = inputDataTime
                .Split(new[] { '/' })
                .Select(int.Parse)
                .ToList();

            DateTime dateTime = new DateTime(inputDayMountYear[2], inputDayMountYear[1], inputDayMountYear[0]);
            return dateTime;
        }
    }
}
