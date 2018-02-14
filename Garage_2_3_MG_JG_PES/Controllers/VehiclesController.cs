using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage_2_3_MG_JG_PES.DataAccessLayer;
using Garage_2_3_MG_JG_PES.Models;

namespace Garage_2_3_MG_JG_PES.Controllers
{
    public class VehiclesController : Controller
    {
        private RegisterContext db = new RegisterContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Vehicles
        public ActionResult Overview()
        {
            return View(db.Vehicles.ToList());
        }

        // GET: Vehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // GET: Vehicles/Check-In
        public ActionResult CheckIn()
        {
            
            return View();
        }
           
        // POST: Vehicles/Check-In
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckIn([Bind(Include = "Id,VehicleType,RegistrationNumber,Color,Brand,Model,NumberOfWheels,CheckIn,CheckOut")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                
                vehicle.CheckIn = DateTime.Now;
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Overview");
            }

            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,VehicleType,RegistrationNumber,Color,Brand,Model,NumberOfWheels,CheckIn,CheckOut")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicle);
        }

        // GET: Vehicles/Check-Out/5
        public ActionResult CheckOut(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Check-Out/5
        [HttpPost, ActionName("CheckOut")]
        [ValidateAntiForgeryToken]
        public ActionResult CheckOutConfirmed(int? id)
        {
            
            Vehicle vehicle = db.Vehicles.Find(id);
           DateTime departure =  DateTime.Now;
           DateTime arrival = (DateTime)vehicle.CheckIn;
           TimeSpan parkeringstid = departure - arrival;
            db.Vehicles.Remove(vehicle);
            db.SaveChanges();
            return RedirectToAction("Overview");
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
