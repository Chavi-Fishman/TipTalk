using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class MeetingsDTO
    {

        public int meetingId { get; set; }
        public int userId { get; set; }
        public int userId_master { get; set; }
        public System.DateTime dateMeeting { get; set; }
        public int categoryId { get; set; }
        public Nullable<int> kind_level { get; set; }
        public Nullable<int> availability_level { get; set; }
        public Nullable<int> mastery_level { get; set; }
        public string describeText { get; set; }
    }
}
