using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CardMasterDTO
    {
        public int cardMasterId { get; set; }
        public int userId { get; set; }
        public int categoryId { get; set; }
        public Nullable<double> priceMeeting { get; set; }
        public Nullable<int> minutesMeeting { get; set; }
        public bool status { get; set; }
        public Nullable<double> priceToExtraTime { get; set; }
        public Nullable<double> numStars { get; set; }
    }
}
