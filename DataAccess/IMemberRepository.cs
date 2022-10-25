using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMember();
        Member GetMemberByID(int memberId);
        void InsertMember(Member member);
        void DeleteMember(int memberId);
        void UpdateMember(Member member);
    }
}
