using EF.Repository.Manager;
using MVCRepositoryEntity.Data;
using MVCRepositoryEntity.Interface;
using MVCRepositoryEntity.Models;
using MVCRepositoryEntity.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRepositoryEntity.Manager
{
    public class StudentManager:CommonManager<Student>,IStudentManager
    {
        public StudentManager():base(new StudentRepository())
        {

        }

        public bool IsRegistrationNo(string RegNo)
        {
            var data = GetFirstOrDefault(x => x.strRegNo.ToLower() == RegNo.ToLower());
            if (data != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}