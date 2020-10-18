using MvcCourse.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcCourse.Controllers
{
    public class TestController : Controller
    {
        private static List<Person> persons = new List<Person>
        {
            new Person{ Id= 1, Name= "張啟祥", Age=18 },
            new Person{ Id= 2, Name= "紹培盛", Age=18 },
            new Person{ Id= 3, Name= "吳群益", Age=18 },
        };

        // GET: Test
        public ActionResult Index()
        {
            return View(persons);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            // 輸入驗證 (Input Validation) 與 模型驗證 
            if (ModelState.IsValid)
            {
                persons.Add(person);
                return RedirectToAction("Index");
            }

            return View(person);
        }

        public ActionResult Edit(int id)
        {
            var person = persons.SingleOrDefault(c => c.Id == id);

            return View(person);
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                var one = persons.SingleOrDefault(c => c.Id == person.Id);
                one.Name = person.Name;
                one.Age = person.Age;

                return RedirectToAction("Index");
            }

            return View(person);
        }

        public ActionResult Details(int id)
        {
            var data = persons.SingleOrDefault(c => c.Id == id);
            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var data = persons.SingleOrDefault(c => c.Id == id);

            return View(data);
        }

        /// <summary>
        /// , FormCollection form
        /// </summary>
        /// <param name="id"></param>
        /// <param name="form"></param>
        /// <returns></returns>
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection form)
        //{
        //    var data = persons.SingleOrDefault(c => c.Id == id);
        //    persons.Remove(data);

        //    return RedirectToAction("Index");
        //}


        /// <summary>
        /// , FormCollection form
        /// </summary>
        /// <param name="id"></param>
        /// <param name="form"></param>
        /// <returns></returns>
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeletePost(int id)
        {
            var data = persons.SingleOrDefault(c => c.Id == id);
            persons.Remove(data);

            return RedirectToAction("Index");
        }
    }
}