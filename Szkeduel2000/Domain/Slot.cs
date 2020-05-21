using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szkeduel2000.Domain
{
    public class Slot
    {
        int slotId;
        int slotHour;
        int dayId;
        int taskId;

        public Slot()
        {
        }

        public Slot(int slotId, int slotHour, int dayId, int taskId)
        {
            this.slotId = slotId;
            this.slotHour = slotHour;
            this.dayId = dayId;
            this.taskId = taskId;
        }
    }
}
