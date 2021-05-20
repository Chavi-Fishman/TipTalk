using BLL.converters;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CardMasterBLL
    {
        public IEnumerable<CardMasterDTO> GetAllCardMasters()
        {
            var listAll = new CardMasterDAL().GetAllCardMasters();
            foreach (var item in listAll)
            {
               yield return CardMasterConverter.GetCardMasterFromEF(item);              
            }   
        }
        public CardMasterDTO GetCardMaster(int id)
        {
            return CardMasterConverter.GetCardMasterFromEF(
                (new CardMasterDAL()).GetCardMaster(id));
        }
    }
}
