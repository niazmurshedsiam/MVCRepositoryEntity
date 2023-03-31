using EF.Repository.Interface.Repository;
using MVCRepositoryEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRepositoryEntity.Interface
{
    interface IStudentRepository:ICommonRepository<Student>
    {
    }
}
