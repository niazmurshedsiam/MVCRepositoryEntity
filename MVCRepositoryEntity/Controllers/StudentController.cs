using MVCRepositoryEntity.Interface;
using MVCRepositoryEntity.Manager;
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
    }
}