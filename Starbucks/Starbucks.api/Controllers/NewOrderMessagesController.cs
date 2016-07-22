using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

using Starbucks.Messages;

namespace Starbucks.Api.Controllers
{
    public class NewOrderMessagesController : ApiController
    {
        NewOrderMessage[] newOrderMessages = new NewOrderMessage[]
        {
            new NewOrderMessage() {CorrelationId = new Guid("4C6B43CE-6A7A-4A72-B024-559A07BF99E7"), Item = "Coffee", Name="Coffee Atlanda", Size = "M"},
            new NewOrderMessage() {CorrelationId = new Guid("370555A8-4D74-46EB-AD83-3C301F5C2B65"), Item = "Hot Choc", Name="Hot Choc Paris", Size = "L"},
        };
        
        // GET api/<controller>
        public IEnumerable<NewOrderMessage> GetAllNewOrderMessages()
        {
            return newOrderMessages;
        }

        // GET api/<controller>/5
        public IHttpActionResult GetNewOrderMessage(Guid id)
        {
            var message = newOrderMessages.FirstOrDefault(x => x.CorrelationId == id);
            if (message == null)
            {
                return NotFound();
            }
            return Ok(message);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}