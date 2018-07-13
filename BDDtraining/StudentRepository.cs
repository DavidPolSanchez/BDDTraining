using BDDTraining.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDtraining
{
    public class StudentRepository : GenericRepository<Student>
    {
        public new Student Insert(Student student)
        {
            student.Age = calcularAge(student.Birthday);
            return base.Insert(student);
        }
        protected int calcularAge(DateTime birthday)
        {
            var today = DateTime.Today;
            int age = today.Year - birthday.Year;

            if (today.Month < birthday.Month || (today.Month == birthday.Month && today.Day < birthday.Day))
            {
                age--;
            }
            return age;
        }

    }
}