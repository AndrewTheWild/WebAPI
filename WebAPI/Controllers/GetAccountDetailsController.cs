using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.GetAccount;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    public class GetAccountDetailsController : ApiController
    {
        private AccountService account = new AccountService(new Credentials("Office365",
                                                           "https://andriikyrstiuksenvironment.crm11.dynamics.com/",
                                                           "andrii.kyrstiuk@dynamicalabsinterns.uk",
                                                           "diablo@@3918"));
        [Route("GetAccountDetails/{id:guid}")]
        public Account Get(Guid id)
        {
            var accountDetails = account?.GetAccountDetails(id);
            return accountDetails;
        }
    }
}
