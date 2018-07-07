using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TransportManagement.Models;

namespace TransportManagement.Controllers
{
    public class CancelsController : Controller
    {
        private Bus_ManagementEntities3 db = new Bus_ManagementEntities3();

        public ActionResult Cancel()
        {
            ViewBag.TicketId = new SelectList(db.Tickets, "TicketId", "TicketNo");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cancel([Bind(Include = "CancelId,PassengerId,TicketPNR,TicketNo,Phone,TicketId")] Cancel cancel)
        {
            if (ModelState.IsValid)
            {
                db.Cancels.Add(cancel);
                db.SaveChanges();
                return RedirectToAction("Dashbord");
            }

            ViewBag.TicketId = new SelectList(db.Tickets, "TicketId", "TicketNo", cancel.TicketId);
            return View(cancel);
        }
        public ActionResult Dashbord()
        {
            return View();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
