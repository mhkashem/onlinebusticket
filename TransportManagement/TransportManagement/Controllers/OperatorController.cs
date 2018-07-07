using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using TransportManagement.Models;


namespace TransportManagement.Controllers
{
    public class OperatorController : Controller
    {

        public ActionResult GetInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetInfo(CityOperator info)
        {
            using (Bus_Management db = new Bus_Management())
            {
                //OperatorViewModel vmodel = new OperatorViewModel();
                List<CityOperator> details = db.CityOperators.ToList().
                    Where(x => x.City_From == info.City_From && x.City_To == info.City_To
                               && x.Dtate == info.Dtate).Select(s => new CityOperator
                               {
                                   Operator = s.Operator,
                                   Arr_Time = s.Arr_Time,
                                   Dept_Time = s.Dept_Time,
                                   Seat = s.Seat,
                                   Fare = s.Fare,
                                   Details = s.Details
                               }).ToList();

                TempData["detail"] = details;
                if(details != null)
                {
                    return RedirectToAction("BusInfo");
                }
                else
                {
                    ViewBag.Message = "Not found";
                }
               
                
                return View();
            }
        }

        public ActionResult BusInfo()
        {
            var lModel = (List<CityOperator>)TempData["detail"];
            return View(lModel);

        }
        public ActionResult SelectBus(CityOperator op)
        {
            var data = op;
            return View (data);
        }
        public ActionResult TicketInf()
        {
            return View();
        }

        private Bus_ManagementEntities3 dbs = new Bus_ManagementEntities3();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Passenger([Bind(Include = "PassengerId,Name,Address,Email,Phone")] User user)
        {
            if (ModelState.IsValid)
            {
                dbs.Users.Add(user);
                dbs.SaveChanges();
                return RedirectToAction("");
            }

            return View(user);
        }


        public ActionResult SelectTicket()
        {
            ViewBag.PassengerId = new SelectList(dbs.Users, "PassengerId", "Name");
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult SelectTicket([Bind(Include = "TicketId,CityId,TicketNo,Bus_Name,Time,Taka,PassengerId")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                dbs.Tickets.Add(ticket);
                dbs.SaveChanges();
                return RedirectToAction("");
            }

            ViewBag.PassengerId = new SelectList(dbs.Users, "PassengerId", "Name", ticket.PassengerId);
            return View(ticket);
        }


        public ActionResult Payment()
        {
            ViewBag.PassengerId = new SelectList(dbs.Users, "PassengerId", "Name");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Payment([Bind(Include = "PayId,PaymentSystem,Code,PassengerId")] Payment payment)
        {
            if (ModelState.IsValid)
            {
                dbs.Payments.Add(payment);
                dbs.SaveChanges();
                return RedirectToAction("");
            }

            ViewBag.PassengerId = new SelectList(dbs.Users, "PassengerId", "Name", payment.PassengerId);
            return View(payment);
        }
    }


}  
        

        
    
