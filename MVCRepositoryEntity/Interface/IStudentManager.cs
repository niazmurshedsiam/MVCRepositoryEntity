using EF.Repository.Interface.Manager;
using MVCRepositoryEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRepositoryEntity.Interface
{
    interface IStudentManager:ICommonManager<Student>
    {
        bool IsRegistrationNo(string RegNo);
        Student GetById(int id);

    }
}
