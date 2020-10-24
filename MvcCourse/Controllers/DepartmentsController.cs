using MvcCourse.Models;
using MvcCourse.Models.ViewModels;
using Omu.ValueInjecter;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MvcCourse.Controllers
{
    public class DepartmentsController : Controller
    {
        ContosoUniversity db = new ContosoUniversity();

        // GET: Departments
        public ActionResult Index()
        {
            return View(db.Departments.ToList());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            ViewBag.InstructorID = new SelectList(db.People, "ID", "FirstName");
            return View();
        }

        // Over Posting
        [HttpPost]
        public ActionResult Create(DepartmentEdit department)
        {
            if (ModelState.IsValid)
            {
                var item = db.Departments.Create();

                item.InjectFrom(department);

                db.Departments.Add(item);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.InstructorID = new SelectList(db.People, "ID", "FirstName");  

            return View(department);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return HttpNotFound();
            }

            var item = db.Departments.Find(id.Value);

            ViewBag.InstructorID = new SelectList(db.People, "ID", "FirstName", item.InstructorID);


            return View(db.Departments.Find(id));
             
        }
        
        [HttpPost]
        public ActionResult Edit(DepartmentEdit department)
        {
            if (ModelState.IsValid)
            {
                var item = db.Departments.Find(department.DepartmentID);

                // 用inject注入
                item.InjectFrom(department);
                
                //item.Name = department.Name;
                //item.Budget = department.Budget; 
                //item.StartDate = department.StartDate;
                //item.InstructorID = department.InstructorID;

                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.InstructorID = new SelectList(db.People, "ID", "FirstName", department.InstructorID);
            return View(department);
        }
         
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // POST: Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Department department = db.Departments.Find(id);
            db.Departments.Remove(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}