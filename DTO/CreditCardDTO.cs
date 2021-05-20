using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CreditCardDTO
    {
        public int userId { get; set; }
        public int creditId { get; set; }
        public string creditNum { get; set; }
        public string creditNameUser { get; set; }
        public string cvv { get; set; }
        public string t_z { get; set; }
    }
}
