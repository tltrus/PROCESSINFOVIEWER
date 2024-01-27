using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InfoViewer
{
    internal class Tools
    {
        static public void EnabledOff(params Control[] controls)
        {
            if (controls == null || controls.Length == 0) return;

            for (int i = 0; i < controls.Length; ++i)
            {
                controls[i].IsEnabled = false;
            }
        }

        static public void EnabledOn(params Control[] controls)
        {
            if (controls == null || controls.Length == 0) return;

            for (int i = 0; i < controls.Length; ++i)
            {
                controls[i].IsEnabled = true;
            }
        }

        // Time comparing

        static public bool IsTimeInPeriod(DateTime time, DateTime timeFrom, DateTime timeTo) => time >= timeFrom && time < timeTo;

        static public bool IsTimeInPeriod(DateTime time, string timeFrom, string timeTo)
        {
            DateTime datetimeFrom = DateTime.ParseExact(timeFrom, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime datetimeTo = DateTime.ParseExact(timeTo, "HH:mm:ss", CultureInfo.InvariantCulture);

            return time > datetimeFrom && time < datetimeTo;
        }
    }
}
