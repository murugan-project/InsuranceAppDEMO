using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InsuranceApp.Models;

namespace InsuranceApp.Controllers
{
    public class RegisterViewModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RegisterViewModels
        [Authorize(Roles ="Admin")]
        public ActionResult Index()
        {
            return View(db.RegisterViewModels.ToList());
        }

        // GET: RegisterViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterViewModel registerViewModel = db.RegisterViewModels.Find(id);
            if (registerViewModel == null)
            {
                return HttpNotFound();
            }
            return View(registerViewModel);
        }

        // GET: RegisterViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Surname,PhoneNumber,City,Email,Password,ConfirmPassword,Description")] RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                db.RegisterViewModels.Add(registerViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registerViewModel);
        }

        // GET: RegisterViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterViewModel registerViewModel = db.RegisterViewModels.Find(id);
            if (registerViewModel == null)
            {
                return HttpNotFound();
            }
            return View(registerViewModel);
        }

        // POST: RegisterViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Surname,PhoneNumber,City,Email,Password,ConfirmPassword,Description")] RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registerViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registerViewModel);
        }

        // GET: RegisterViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterViewModel registerViewModel = db.RegisterViewModels.Find(id);
            if (registerViewModel == null)
            {
                return HttpNotFound();
            }
            return View(registerViewModel);
        }

        // POST: RegisterViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegisterViewModel registerViewModel = db.RegisterViewModels.Find(id);
            db.RegisterViewModels.Remove(registerViewModel);
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
