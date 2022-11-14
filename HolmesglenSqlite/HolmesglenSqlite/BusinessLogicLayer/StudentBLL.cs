using HolmesglenSqlite.DataAccessLayer;
using HolmesglenSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenSqlite.BusinessLogicLayer
{
    public class StudentBLL
    {
        private StudentDAL StudentDALInstance;
        public StudentBLL(StudentDAL studentDALInstance)
        {
            StudentDALInstance = studentDALInstance;
        }
        public List<Student> GetAll()
        {
            return StudentDALInstance.ReadAll();
        }
    }
}
