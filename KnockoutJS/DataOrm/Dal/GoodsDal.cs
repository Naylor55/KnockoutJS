using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOrm.Dal
{
    public class GoodsDal : BaseDal
    {
        public static List<Goods> GetGoodsList()
        {
            List<Goods> mlist = (from item in db.Goods select item).Take(10).ToList();
            return mlist;
        }
    }
}
