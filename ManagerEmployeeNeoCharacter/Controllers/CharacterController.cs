using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ManagerEmployeeNeoCharacter.Models;
using ManagerEmployeeNeoCharacter.DAL;

namespace ManagerEmployeeNeoCharacter.Controllers
{
    public class CharacterController : Controller
    {
        private ManagerEmployeeNeoCharacterContext db = new ManagerEmployeeNeoCharacterContext();

        //
        // GET: /Character/

        public ActionResult Index()
        {
            var characters = db.Characters.Include(c => c.Employee);
            return View(characters.ToList());
        }

        //
        // GET: /Character/Details/5

        public ActionResult Details(int id = 0)
        {
            Character character = db.Characters
                   .Where(b => b.EmployeeID == id)
                   .Single();
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        //
        // GET: /Character/Create

        public ActionResult Create(int id = 0)
        {
            

            Employee employee = db.Employees.Find(id);
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", employee.EmployeeID);
            return View();
        }

        //
        // POST: /Character/Create

        [HttpPost]
        public ActionResult Create(Character character)
        {
          //var total = db.Characters.Select(a => new { character = db.Characters.Sum(b => b.AA), 
            //total.ToString("A");
           // var sells = orderedArt
           //.GroupBy(a => a.ArticleName)
           //.Select(a => new { Amount = a.Sum(b => b.ArticleAmount), Name = a.ArticleName })
           //.OrderByDescending(a => a.Amount)
           //.ToList();
  

            //character.AA = 12;
            //character.AB = 12;       
            if (ModelState.IsValid)
            {
                db.Characters.Add(character);
                db.SaveChanges();
                return RedirectToAction("Index");
            }                                                  

            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", character.EmployeeID);
            return View(character);
        }

        //
        // GET: /Character/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Character character = db.Characters
                 .Where(b => b.EmployeeID == id)
                 .Single();
            if (character == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", character.EmployeeID);
            return View(character);
        }

        //
        // POST: /Character/Edit/5

        [HttpPost]
        public ActionResult Edit(Character character)
        {
            if (ModelState.IsValid)
            {
                db.Entry(character).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", character.EmployeeID);
            return View(character);
        }

        //
        // GET: /Character/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        //
        // POST: /Character/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Character character = db.Characters.Find(id);
            db.Characters.Remove(character);
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