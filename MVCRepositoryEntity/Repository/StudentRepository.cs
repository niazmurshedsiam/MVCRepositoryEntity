using EF.Repository.Repository;
using MVCRepositoryEntity.Data;
using MVCRepositoryEntity.Interface;
using MVCRepositoryEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRepositoryEntity.Repository
{
    public class StudentRepository:CommonRepository<Student>, IStudentRepository
    {
        public StudentRepository() : base(new ApplicationDbContext())
        {

        }
    }
}