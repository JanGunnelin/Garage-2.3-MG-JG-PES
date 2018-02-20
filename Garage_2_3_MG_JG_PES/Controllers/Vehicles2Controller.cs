using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage_2_3_MG_JG_PES.DataAccessLayer;

namespace Garage_2_3_MG_JG_PES.Models
{
    public class Vehicles2Controller : Controller
    {
        private RegisterContext db = new RegisterContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Vehicles
        public ActionResult Overview(string sortOrder, string searchString)
        {
            ViewBag.VehicleTypeSortParm = String.IsNullOrEmpty(sortOrder) ? "vehicletype_desc" : "";
            ViewBag.RegistrationNumberSortParm = sortOrder == "registrationnumber" ? "registrationnumber_desc" : "registrationnumber";
            ViewBag.ColorSortParm = sortOrder == "color" ? "color_desc" : "color";
            ViewBag.CheckInSortParm = sortOrder == "checkin" ? "checkin_desc" : "checkin";
            var vehicles = from s in db.Vehicles select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                vehicles = vehicles.Where(s => s.RegistrationNumber.ToUpper().Contains(searchString.ToUpper()));
            }
            switch (sortOrder)
            {
                case "vehicletype_desc":
                    vehicles = vehicles.OrderByDescending(s => s.VehicleType.Type);
                    break;
                case "registrationnumber":
                    vehicles = vehicles.OrderBy(s => s.RegistrationNumber);
                    break;
                case "registrationnumber_desc":
                    vehicles = vehicles.OrderByDescending(s => s.RegistrationNumber);
                    break;
                case "color":
                    vehicles = vehicles.OrderBy(s => s.Color);
                    break;
                case "color_desc":
                    vehicles = vehicles.OrderByDescending(s => s.Color);
                    break;
                case "checkin":
                    vehicles = vehicles.OrderBy(s => s.CheckIn);
                    break;
                case "checkin_desc":
                    vehicles = vehicles.OrderByDescending(s => s.CheckIn);
                    break;
                default:
                    vehicles = vehicles.OrderBy(s => s.VehicleType.Type);
                    break;
            }
            //var vehicles = db.Vehicles.Include(v => v.Member).Include(v => v.VehicleType);
            return View(vehicles.ToList());
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
            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName");
            ViewBag.VehicleTypeID = new SelectList(db.VehicleTypes, "Id", "Type");
            return View();
        }

        // POST: Vehicles/Check-In
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckIn([Bind(Include = "Id,MemberId,VehicleTypeId,RegistrationNumber,Color,Brand,Model,NumberOfWheels,CheckIn")] Vehicle vehicle)
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
        public ActionResult Edit([Bind(Include = "Id,MemberId,VehicleTypeId,RegistrationNumber,Color,Brand,Model,NumberOfWheels,CheckIn")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Overview");
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
            //DateTime departure = DateTime.Now;
            //DateTime arrival = (DateTime)vehicle.CheckIn;
            //TimeSpan parkeringstid = departure - arrival;
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
