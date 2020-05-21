using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szkeduel2000.Domain
{
    public class Day
    {
        int dayId;
        string dayName;
        int scheduleId;

        public Day()
        {
        }

        public Day(int dayId, string dayName, int scheduleId)
        {
            this.dayId = dayId;
            this.dayName = dayName;
            this.scheduleId = scheduleId;
        }
    }
}
