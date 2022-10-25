using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<Member> GetMemberList()
        {
            var members = new List<Member>();
            try
            {
                using var context = new myestoreContext();
                members = context.Members.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return members;
        }

        public Member GetMemberByID(int memberId)
        {
            Member members = null;
            try
            {
                using var context = new myestoreContext();
                members = context.Members.SingleOrDefault(c => c.MemberId == memberId);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return members;
        }

        public void AddNew(Member member)
        {
            try
            {
                Member _member = GetMemberByID(member.MemberId);
                if (_member == null)
                {
                    using var context = new myestoreContext();
                    context.Members.Add(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Member is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Update(Member member)
        {
            try
            {

                Member _member = GetMemberByID(member.MemberId);
                if (_member != null)
                {
                    using var context = new myestoreContext();
                    context.Members.Update(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member does not already exist");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Remove(int memberId)
        {
            try
            {

                Member member = GetMemberByID(memberId);
                if (member != null)
                {
                    using var context = new myestoreContext();
                    context.Members.Remove(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member does not already exist");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }

}

