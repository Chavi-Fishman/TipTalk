using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class MasterShiftDTO
    {
        public int shiftMasterId { get; set; }
        public int cardMasterId { get; set; }
        public int dayOfWeek { get; set; }
        public double fromHour { get; set; }
        public double untillHour { get; set; }
    }
}
