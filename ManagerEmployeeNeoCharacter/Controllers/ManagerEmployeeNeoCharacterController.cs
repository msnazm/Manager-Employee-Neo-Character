using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ManagerEmployeeNeoCharacter.Models;
using ManagerEmployeeNeoCharacter.DAL;
using PagedList;

namespace ManagerEmployeeNeoCharacter.Controllers
{
    public class ManagerEmployeeNeoCharacterController : Controller
    {
        private ManagerEmployeeNeoCharacterContext db = new ManagerEmployeeNeoCharacterContext();

        //
        // GET: /ManagerEmployeeNeoCharacter/
        //var neos = db.Neos.Include(c => c.Employee);
      


        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

          //  var neos = db.Neos.Include(c => c.Employee);
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;
            
            var employees = from s in db.Employees
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(s => s.LastName.ToUpper().Contains(searchString.ToUpper())
                                       || s.FirstMidName.ToUpper().Contains(searchString.ToUpper()));
            }

          
            switch (sortOrder)
            {
            
                case "name_desc":
                    employees = employees.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    employees = employees.OrderBy(s => s.EnetrDate);
                    break;
                case "date_desc":
                    employees = employees.OrderByDescending(s => s.EnetrDate);
                    break;
                default:  // Name ascending 
                    employees = employees.OrderBy(s => s.LastName);
                    break;
            }
          //  var msn = neos.ToList();
            int pageSize = 3;
            int pageNumber = (page ?? 1);

           // ViewBag.neo = new SelectList(db.Neos, "NeoID");
            return View(employees.ToPagedList(pageNumber, pageSize));
           
           
        }
        //
        // GET: /ManagerEmployeeNeoCharacter/Details/5
       
        public ActionResult Details(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // GET: /ManagerEmployeeNeoCharacter/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ManagerEmployeeNeoCharacter/Create

        [HttpPost]
        public ActionResult Create(
            [Bind(Include = "LastName, FirstMidName, EnrollmentDate")]
            Employee employee)
        {
             try
   {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
   }
             catch (DataException /* dex */)
             {
                 //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                 ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
             }

            return View(employee);
        }

        //
        // GET: /ManagerEmployeeNeoCharacter/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /ManagerEmployeeNeoCharacter/Edit/5

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //
        // GET: /ManagerEmployeeNeoCharacter/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /ManagerEmployeeNeoCharacter/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}