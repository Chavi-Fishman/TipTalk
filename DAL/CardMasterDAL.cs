using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CardMasterDAL
    {
        public CardMasterDAL()
        {

        }
        public IEnumerable<CardMaster> GetAllCardMasters()
        {
            try
            {
                using (TipTalkEntities db = new TipTalkEntities())
                {
                    return db.CardMaster.ToList();
                }
            }
            catch
            {
                //todo:: add exception logger
                //EventLog log = new EventLog();
                return null;
            }
        }
        public CardMaster GetCardMaster(int v)
        {
            try
            {
                using (TipTalkEntities db = new TipTalkEntities())
                {
                    return db.CardMaster.Single(a => a.cardMasterId == v);
                }
            }
            catch
            {
                //todo:: add exception logger
                //EventLog log = new EventLog();
                return null;
            }
        }
    }
}
