using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ManagerEmployeeNeoCharacter.Models;
using ManagerEmployeeNeoCharacter.DAL;

namespace ManagerEmployeeNeoCharacter.Controllers
{
    public class NeoController : Controller
    {
        private ManagerEmployeeNeoCharacterContext db = new ManagerEmployeeNeoCharacterContext();

        //
        // GET: /Neo/

        public ActionResult Index()
        {
            var neos = db.Neos.Include(c => c.Employee);
            return View(neos.ToList());
        }

        //
        // GET: /Neo/Details/5

        public ActionResult Details(int id = 0)
        {


            Neo neo = db.Neos
                .Where(b => b.EmployeeID == id)
                .Single();
            if (neo == null)
            {
                return HttpNotFound();
            }
            return View(neo);
        }

       

        //
        // POST: /Neo/Create
        
        public ActionResult Create(int id = 0)
        {
            //Neo neo = db.Neos.Find(id);
            //PopulateDepartmentsDropDownList(neo.EmployeeID);
            //return View();

            //Neo neo = db.Neos.Find(id);
            //if (neo == null)
            //{
            Employee employee = db.Employees.Find(id);
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", employee.EmployeeID);
            //employee = db.Employees.Find(id);
            //ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", employee.EmployeeID);
            return View();
                //PopulateDepartmentsDropDownList();
            //}
            //ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", neo.EmployeeID);
            //return View(employeesQuery);
        }

        //
        // POST: /Character/Create

        [HttpPost]
        public ActionResult Create(Neo neo)
        {
            if (ModelState.IsValid)
            {
                db.Neos.Add(neo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", neo.EmployeeID);
            return View(neo);
        }

        //
        // GET: /Neo/Edit/5

        public ActionResult Edit(int id = 0)
        {


            Neo neo = db.Neos
                .Where(b => b.EmployeeID == id)
                .Single();
                
                

            if (neo == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", neo.EmployeeID);

            return View(neo);
        }

        //
        // POST: /Character/Edit/5

        [HttpPost]
        public ActionResult Edit(Neo neo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(neo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", neo.EmployeeID);
            return View(neo);
        }

        //
        // GET: /Neo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Neo neo = db.Neos.Find(id);
            if (neo == null)
            {
                return HttpNotFound();
            }
            return View(neo);
        }

        //
        // POST: /Neo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Neo neo = db.Neos.Find(id);
            db.Neos.Remove(neo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        private void PopulateDepartmentsDropDownList(object selectedEmployee =  null)
        {
            var employeesQuery = from d in db.Employees
                                   orderby d.LastName
                                   select d;
            ViewBag.EmployeeID = new SelectList(employeesQuery, "EmployeeID", "LastName", selectedEmployee);
        } 
    }
}