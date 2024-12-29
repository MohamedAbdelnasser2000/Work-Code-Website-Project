using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Work_Code.Models;

namespace Work_Code.Controllers
{
    public class Lets_Work_To_GetherController : Controller
    {
        private WorkCode_dbEntities1 db = new WorkCode_dbEntities1();

        // GET: Lets_Work_To_Gether
        public ActionResult Index()
        {
            return View(db.Lets_Work_To_Gether.ToList());
        }

        // GET: Lets_Work_To_Gether/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lets_Work_To_Gether lets_Work_To_Gether = db.Lets_Work_To_Gether.Find(id);
            if (lets_Work_To_Gether == null)
            {
                return HttpNotFound();
            }
            return View(lets_Work_To_Gether);
        }

        // GET: Lets_Work_To_Gether/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lets_Work_To_Gether/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,P_Name,P_Desciption,Ex_Delivery_Date,P_Budget,Your_Name,Your_mail,Your_Phone,Your_Address,Uplode_Requirment_pdf")] Lets_Work_To_Gether lets_Work_To_Gether, HttpPostedFileBase file1)
        {
            if (file1 != null)
            {
                file1.SaveAs(HttpContext.Server.MapPath("~/Image/") + file1.FileName);
                lets_Work_To_Gether.Uplode_Requirment_pdf = file1.FileName;
            }
            if (ModelState.IsValid)
            {
                db.Lets_Work_To_Gether.Add(lets_Work_To_Gether);
                db.SaveChanges();


                // تنظيف النموذج بعد الحفظ
                ModelState.Clear();

                // تخزين رسالة النجاح في TempData
                TempData["SuccessMessage"] = "Success Message";

                return RedirectToAction("Create");
            }

            return View(lets_Work_To_Gether);
        }

        // GET: Lets_Work_To_Gether/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lets_Work_To_Gether lets_Work_To_Gether = db.Lets_Work_To_Gether.Find(id);
            if (lets_Work_To_Gether == null)
            {
                return HttpNotFound();
            }
            return View(lets_Work_To_Gether);
        }

        // POST: Lets_Work_To_Gether/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,P_Name,P_Desciption,Ex_Delivery_Date,P_Budget,Your_Name,Your_mail,Your_Phone,Your_Address,Uplode_Requirment_pdf")] Lets_Work_To_Gether lets_Work_To_Gether)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lets_Work_To_Gether).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lets_Work_To_Gether);
        }

        // GET: Lets_Work_To_Gether/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lets_Work_To_Gether lets_Work_To_Gether = db.Lets_Work_To_Gether.Find(id);
            if (lets_Work_To_Gether == null)
            {
                return HttpNotFound();
            }
            return View(lets_Work_To_Gether);
        }

        // POST: Lets_Work_To_Gether/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lets_Work_To_Gether lets_Work_To_Gether = db.Lets_Work_To_Gether.Find(id);
            db.Lets_Work_To_Gether.Remove(lets_Work_To_Gether);
            db.SaveChanges();
            return RedirectToAction("Index");
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
