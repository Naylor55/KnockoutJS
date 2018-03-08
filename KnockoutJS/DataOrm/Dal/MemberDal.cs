using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOrm.Dal
{
    public class MemberDal : BaseDal
    {
        public static List<Member> GetMemberList()
        {
            List<Member> mlist = (from item in db.Member select item).Take(10).ToList();
            return mlist;
        }
    }
}
