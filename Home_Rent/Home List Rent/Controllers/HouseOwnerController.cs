using Buseness_Entity_Layer;
using Buseness_Logic_Layer.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Home_List_Rent.Controllers
{
    public class HouseOwnerController : ApiController
    {
        [Route("api/Owner/list")]
        [HttpGet]
        public List<OwnerModel>Get()
        {
            return OwnerService.GetAll();
        }
    
        [Route("api/Owner/Edit/{id}")]
        [HttpPost]
        public void EditOwner(OwnerModel n)
        {
            OwnerService.Edit(n);
        }
        [Route("api/Owner/Delete/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteOwner(int id)
        {
            bool sucess = OwnerService.DeleteOwner(id);
            return Request.CreateResponse(sucess ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }
        [Route("api/Investor/CreateInvestor")]
        [HttpPost]
        public void AddOwner(OwnerModel n)
        {
            OwnerService.AddOwner(n);
        }

    }
}
