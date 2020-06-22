using GestContact.Models.Contact;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using GestContact.Models.Client.Data;
using GestContact.Models.Client.Services;
using GestContact.Infrastructure;
using GestContact.Infrastructure.Attributes;

namespace GestContact.Controllers
{
    [AuthenticatedRequired]
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return RedirectToAction("Listing");
        }

        public ActionResult Listing()
        {
            List<ListingView> model = new List<ListingView>();
            foreach (Contact c in ServiceLocator.Instance.ContactService.GetAll(SessionManager.User.Id))
                model.Add(new ListingView() {Id = c.Id, Fname = c.Fname, Lname = c.Lname});
            return View(model);
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            Contact c = ServiceLocator.Instance.ContactService.Get(id);
            DetailsView model = new DetailsView() { Id = c.Id, Fname = c.Fname, Lname = c.Lname, Email = c.Email, Tel = c.Tel };
            return View(model);
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateForm createForm)
        {
            if (ModelState.IsValid)
                try
                {
                    Contact c = new Contact(createForm.Fname, createForm.Lname, createForm.Tel, createForm.Email);
                    ServiceLocator.Instance.ContactService.Insert(SessionManager.User.Id, c);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ViewBag.Error = e.Message;
                }
            return View(createForm);
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            Contact c = ServiceLocator.Instance.ContactService.Get(id);
            EditForm model = new EditForm() { Email = c.Email, Fname = c.Fname, Lname = c.Lname, Tel = c.Tel };
            return View(model);
        }

        // POST: Contact/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditForm editForm)
        {
            if (ModelState.IsValid)
                try
                {
                    Contact c = new Contact(editForm.Fname, editForm.Lname, editForm.Tel, editForm.Email);
                    c.Id = id;
                    ServiceLocator.Instance.ContactService.Update(c);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ViewBag.Error = e.Message;
                }

            return View(editForm);
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            Contact c = ServiceLocator.Instance.ContactService.Get(id);
            DeleteView model = new DeleteView() { Id = c.Id, Fname = c.Fname, Lname = c.Lname, Tel = c.Tel, Email = c.Email };
            return View(model);
        }

        // POST: Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            if (ModelState.IsValid)
                try
                {
                    ServiceLocator.Instance.ContactService.Delete(id);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ViewBag.Error = e.Message;
                }
            return View();
        }
    }
}
