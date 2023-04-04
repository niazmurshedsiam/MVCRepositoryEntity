using MVCRepositoryEntity.Interface;
using MVCRepositoryEntity.Manager;
using MVCRepositoryEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRepositoryEntity.Controllers
{
    public class StudentController : Controller
    {
        IStudentManager _iStudent = new StudentManager();
        // GET: Student
        public ActionResult Index()
        {
            var students = _iStudent.GetAll();
            return View(students);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                if (_iStudent.IsRegistrationNo(student.strRegNo))
                {
                    ViewBag.Msg = "Registration Number Already exists";
                }
                
                bool isActive = _iStudent.Add(student);
                if (isActive)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Msg = "Data Don't Save";
                }

            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var data = _iStudent.GetFirstOrDefault(x => x.intId == id);
            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                bool isUpdate = _iStudent.Update(student);
                if (isUpdate)
                {
                    return RedirectToAction("Index");
                }

            }
            return View(); 
        }

        public ActionResult Details(int id)
        {
            var data = _iStudent.GetFirstOrDefault(c => c.intId == id);
            if(data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }
    }
}