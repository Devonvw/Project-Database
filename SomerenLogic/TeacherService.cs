using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;
using System.Collections.ObjectModel;

namespace SomerenLogic
{
    public class TeacherService
    {
        TeacherDao teacherdb;

        public TeacherService()
        {
            teacherdb = new TeacherDao();
        }
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teacher = teacherdb.GetAllTeachers();
            return teacher;
        }
    }
}
