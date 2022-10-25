using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memberId) => MemberDAO.Instance.Remove(memberId);

        public IEnumerable<Member> GetMember() => MemberDAO.Instance.GetMemberList();
        

        public Member GetMemberByID(int memberId) => MemberDAO.Instance.GetMemberByID(memberId);

        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);
        

        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);
    }
}
