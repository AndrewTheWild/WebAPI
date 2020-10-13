using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.GetAccount;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    public class GetModifiedAccountsController : ApiController
    {
        private AccountService account = new AccountService(new Credentials("Office365",
                                                            "https://andriikyrstiuksenvironment.crm11.dynamics.com/",
                                                            "andrii.kyrstiuk@dynamicalabsinterns.uk",
                                                          "diablo@@3918"));
        [Route("GetModifiedAccounts/{x}")]
        public List<Account> Get(string x)
        {
            List<Account> list=new List<Account>();
            var datePart = (from item in x.Split(new char[] { '-' })
                            select int.Parse(item)).ToList();
            DateTime modifieOn=new DateTime(datePart[2],datePart[1], datePart[0]);
            list = account?.GetModifiedAccounts(modifieOn);
            return list;

        }
    }
}
