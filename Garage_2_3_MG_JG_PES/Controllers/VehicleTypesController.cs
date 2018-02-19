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
    public class VehicleTypesController : Controller
    {
        //private RegisterContext db = new RegisterContext();

        //// GET: VehicleTypes
        //public ActionResult Index()
        //{
        //    return View(db.VehicleTypes.ToList());
        //}

        //// GET: Vehicles
        //public ActionResult Overview(string sortOrder, string searchString)
        //{
        //    ViewBag.VehicleTypeSortParm = String.IsNullOrEmpty(sortOrder) ? "vehicletype_desc" : "";
        //    ViewBag.RegistrationNumberSortParm = sortOrder == "registrationnumber" ? "registrationnumber_desc" : "registrationnumber";
        //    ViewBag.ColorSortParm = sortOrder == "color" ? "color_desc" : "color";
        //    ViewBag.CheckInSortParm = sortOrder == "checkin" ? "checkin_desc" : "checkin";
        //    var vehicles = from s in db.Vehicles select s;
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        vehicles = vehicles.Where(s => s.RegistrationNumber.ToUpper().Contains(searchString.ToUpper()));
        //    }
        //    switch (sortOrder)
        //    {
        //        case "vehicletype_desc":
        //            vehicles = vehicles.OrderByDescending(s => s.VehicleType);
        //            break;
        //        case "registrationnumber":
        //            vehicles = vehicles.OrderBy(s => s.RegistrationNumber);
        //            break;
        //        case "registrationnumber_desc":
        //            vehicles = vehicles.OrderByDescending(s => s.RegistrationNumber);
        //            break;
        //        case "color":
        //            vehicles = vehicles.OrderBy(s => s.Color);
        //            break;
        //        case "color_desc":
        //            vehicles = vehicles.OrderByDescending(s => s.Color);
        //            break;
        //        case "checkin":
        //            vehicles = vehicles.OrderBy(s => s.CheckIn);
        //            break;
        //        case "checkin_desc":
        //            vehicles = vehicles.OrderByDescending(s => s.CheckIn);
        //            break;
        //        default:
        //            vehicles = vehicles.OrderBy(s => s.VehicleType);
        //            break;
        //    }
        //    return View(vehicles.ToList());
        //}

        //// GET: VehicleTypes/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    VehicleType vehicleType = db.VehicleTypes.Find(id);
        //    if (vehicleType == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(vehicleType);
        //}

        //// GET: VehicleTypes/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: VehicleTypes/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Type")] VehicleType vehicleType)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.VehicleTypes.Add(vehicleType);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(vehicleType);
        //}

        //// GET: VehicleTypes/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    VehicleType vehicleType = db.VehicleTypes.Find(id);
        //    if (vehicleType == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(vehicleType);
        //}

        //// POST: VehicleTypes/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Type")] VehicleType vehicleType)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(vehicleType).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(vehicleType);
        //}

        //// GET: VehicleTypes/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    VehicleType vehicleType = db.VehicleTypes.Find(id);
        //    if (vehicleType == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(vehicleType);
        //}

        //// POST: VehicleTypes/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    VehicleType vehicleType = db.VehicleTypes.Find(id);
        //    db.VehicleTypes.Remove(vehicleType);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
