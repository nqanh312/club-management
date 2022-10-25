using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessObject;
using DataAccess;
using System;

namespace eStore.Controllers
{
    public class MemberController : Controller
        
    {
        IMemberRepository member = null;
        public MemberController() => member = new MemberRepository();
        // GET: MemberController
        public ActionResult Index()
        {
            var memberList = member.GetMember();
            return View(memberList);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var mem = member.GetMemberByID(id.Value);
            if ( mem == null)
            {
                return NotFound();
            }
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member Member)
        {
            try
            {
               if (ModelState.IsValid)
                {
                    member.InsertMember(Member);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(Member);
            }
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Member = member.GetMemberByID(id.Value);
            if (Member == null)
            {
                return NotFound();
            }
            return View(Member);
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Member Member)
        {
            try
            {
                if (id != Member.MemberId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    member.UpdateMember(Member);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Member = member.GetMemberByID(id.Value);
            if (Member == null)
            {
                return NotFound();
            }
            return View(Member);
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                member.DeleteMember(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
