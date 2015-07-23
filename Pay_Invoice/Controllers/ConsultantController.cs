using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pay_Invoice.Controllers
{
    public class ConsultantController : Controller
    {
        //
        // GET: /Consultant/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Consultant/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Consultant/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Consultant/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Consultant/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Consultant/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Consultant/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Consultant/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
