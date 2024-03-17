using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternOopDemo.OopDemo.Association.AssociationClass
{
    internal class Registration
    {
        public Registration(School school, Student student, int score)
        {
            School = school;
            Student = student;
            Score = score;
        }

        public School School { get; }
        public Student Student { get; }
        public int Score { get; }
    }
}
