using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szkeduel2000.Domain
{
    public class Schedule
    {
        int scheduleId;
        string scheduleName;
        int userId;

        public Schedule()
        {
        }

        public Schedule(int scheduleId, string scheduleName, int userId)
        {
            this.scheduleId = scheduleId;
            this.scheduleName = scheduleName;
            this.userId = userId;
        }
    }
}
