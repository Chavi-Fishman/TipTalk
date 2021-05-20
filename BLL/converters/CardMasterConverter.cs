using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.converters
{
    public class CardMasterConverter
    {
        public static CardMaster GetCardMasterFromDTO(CardMasterDTO cardMasterDTO)
        {
            CardMaster cardMaster = new CardMaster();
            cardMaster.cardMasterId = cardMasterDTO.cardMasterId;
            cardMaster.categoryId = cardMasterDTO.categoryId;
            cardMaster.minutesMeeting = cardMasterDTO.minutesMeeting;
            cardMaster.numStars = cardMasterDTO.numStars;
            cardMaster.priceMeeting = cardMasterDTO.priceMeeting;
            cardMaster.priceToExtraTime = cardMasterDTO.priceToExtraTime;
            cardMaster.status = cardMasterDTO.status;
            cardMaster.userId = cardMasterDTO.userId;
            return cardMaster;
        }
        public static CardMasterDTO GetCardMasterFromEF(CardMaster cardMaster)
        {
            CardMasterDTO cardMasterDTO = new CardMasterDTO();
            cardMasterDTO.cardMasterId = cardMaster.cardMasterId;
            cardMasterDTO.categoryId = cardMaster.categoryId;
            cardMasterDTO.minutesMeeting = cardMaster.minutesMeeting;
            cardMasterDTO.numStars = cardMaster.numStars;
            cardMasterDTO.priceMeeting = cardMaster.priceMeeting;
            cardMasterDTO.priceToExtraTime = cardMaster.priceToExtraTime;
            cardMasterDTO.status = cardMaster.status;
            cardMasterDTO.userId = cardMaster.userId;
            return cardMasterDTO;
        }
    }
}
