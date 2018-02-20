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
        public ActionResult Overview(string sortOrder, string searchString1, string searchString2, string clear)
        {
            ViewBag.OwnerSortParm = String.IsNullOrEmpty(sortOrder) ? "owner_desc" : "";
            ViewBag.VehicleTypeSortParm = sortOrder == "vehicletype" ? "vehicletype_desc" : "vehicletype";
            ViewBag.RegistrationNumberSortParm = sortOrder == "registrationnumber" ? "registrationnumber_desc" : "registrationnumber";
            ViewBag.CheckInSortParm = sortOrder == "checkin" ? "checkin_desc" : "checkin";

            var vehicles = from s in db.Vehicles select s;

            if (!String.IsNullOrEmpty(searchString1))
            {
                vehicles = vehicles.Where(s => s.RegistrationNumber.ToUpper().Contains(searchString1.ToUpper()));
            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                vehicles = vehicles.Where(s => s.VehicleType.Type.ToUpper().Contains(searchString2.ToUpper()));
            }

            switch (sortOrder)
            {
                case "owner_desc":
                    vehicles = vehicles.OrderByDescending(s => s.Member.LastName);
                    break;
                case "vehicletype":
                    vehicles = vehicles.OrderBy(s => s.VehicleType.Type);
                    break;
                case "vehicletype_desc":
                    vehicles = vehicles.OrderByDescending(s => s.VehicleType.Type);
                    break;
                case "registrationnumber":
                    vehicles = vehicles.OrderBy(s => s.RegistrationNumber);
                    break;
                case "registrationnumber_desc":
                    vehicles = vehicles.OrderByDescending(s => s.RegistrationNumber);
                    break;
                case "checkin":
                    vehicles = vehicles.OrderBy(s => s.CheckIn);
                    break;
                case "checkin_desc":
                    vehicles = vehicles.OrderByDescending(s => s.CheckIn);
                    break;
                default:
                    vehicles = vehicles.OrderBy(s => s.Member.LastName);
                    break;
            }
            return View(vehicles.ToList());
        }

        // GET: Vehicles
        public ActionResult DetailedOverview(string sortOrder, string searchString1, string searchString2, string clear)
        {
            ViewBag.OwnerSortParm = String.IsNullOrEmpty(sortOrder) ? "owner_desc" : "";
            ViewBag.VehicleTypeSortParm = sortOrder == "vehicletype" ? "vehicletype_desc" : "vehicletype";
            ViewBag.RegistrationNumberSortParm = sortOrder == "registrationnumber" ? "registrationnumber_desc" : "registrationnumber";
            ViewBag.ColorSortParm = sortOrder == "color" ? "color_desc" : "color";
            ViewBag.BrandSortParm = sortOrder == "brand" ? "brand_desc" : "brand";
            ViewBag.ModelSortParm = sortOrder == "model" ? "model_desc" : "model";
            ViewBag.NumberOfWheelsSortParm = sortOrder == "numberofwheels" ? "numberofwheels_desc" : "numberofwheels";
            ViewBag.CheckInSortParm = sortOrder == "checkin" ? "checkin_desc" : "checkin";
            var vehicles = from s in db.Vehicles select s;
            if (!String.IsNullOrEmpty(searchString1))
            {
                vehicles = vehicles.Where(s => s.RegistrationNumber.ToUpper().Contains(searchString1.ToUpper()));
            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                vehicles = vehicles.Where(s => s.VehicleType.Type.ToUpper().Contains(searchString2.ToUpper()));
            }

            switch (sortOrder)
            {
                case "owner_desc":
                    vehicles = vehicles.OrderByDescending(s => s.Member.LastName);
                    break;
                case "vehicletype":
                    vehicles = vehicles.OrderBy(s => s.VehicleType.Type);
                    break;
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
                case "brand":
                    vehicles = vehicles.OrderBy(s => s.Brand);
                    break;
                case "brand_desc":
                    vehicles = vehicles.OrderByDescending(s => s.Brand);
                    break;
                case "model":
                    vehicles = vehicles.OrderBy(s => s.Model);
                    break;
                case "model_desc":
                    vehicles = vehicles.OrderByDescending(s => s.Model);
                    break;
                case "numberofwheels":
                    vehicles = vehicles.OrderBy(s => s.NumberOfWheels);
                    break;
                case "numberofwheels_desc":
                    vehicles = vehicles.OrderByDescending(s => s.NumberOfWheels);
                    break;
                case "checkin":
                    vehicles = vehicles.OrderBy(s => s.CheckIn);
                    break;
                case "checkin_desc":
                    vehicles = vehicles.OrderByDescending(s => s.CheckIn);
                    break;
                default:
                    vehicles = vehicles.OrderBy(s => s.Member.LastName);
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
            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName");
            ViewBag.VehicleTypeID = new SelectList(db.VehicleTypes, "Id", "Type");
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
