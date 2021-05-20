using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TipTalkServer.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
   
        public IEnumerable<CardMasterDTO> Get()
        {
            return new CardMasterBLL().GetAllCardMasters();
        }

        // GET api/values/5
        public CardMasterDTO Get(int id)
        {
            return new CardMasterBLL().GetCardMaster(id);
        }
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
