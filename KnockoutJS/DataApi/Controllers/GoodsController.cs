using DataOrm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DataApi.Controllers
{
    public class GoodsController : BaseApiController
    {
        public IEnumerable<Goods> Get()
        {
            var list = DataOrm.Dal.GoodsDal.GetGoodsList();
            return list;
        }
    }
}
