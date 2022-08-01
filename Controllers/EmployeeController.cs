using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc3839_24522.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

       
            db3839_24522Entities db = new db3839_24522Entities();

        public ActionResult EmployeeForm()
        {
            return View();
        }

        public void EmployeeInsert(Emp obj)
        {
            db.Emps.Add(obj);
            db.SaveChanges();
        }

        public void EmployeeUpdate(Emp obj)
        {

            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void EmployeeDelete(int A)
        {

            var data = db.Emps.Find(A);
            db.Emps.Remove(data);
            db.SaveChanges();
        }


        public JsonResult EmployeeGet()
        {

            var data = (from e in db.Emps
                        join d in db.tbldepartments on e.department equals d.did
                        join c in db.tblcountries on e.country equals c.cid
                        join s in db.tblstates on e.state equals s.sid
                        select new {e.empid,e.name,e.address,e.age,d.dname,c.cname,s.sname }).ToList();
            return Json(data,JsonRequestBehavior.AllowGet);
        }


        public JsonResult DepartmentGet()
        {

            var data = (from a in db.tbldepartments select a ).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CountryGet()
        {

            var data = (from a in db.tblcountries select a).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult StateGet(int A)
        {

            var data = (from a in db.tblstates where a.cid==A select a).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }


        public JsonResult EmployeeEdit(int A)
        {

            var data = (from a in db.Emps where a.empid==A select a).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}