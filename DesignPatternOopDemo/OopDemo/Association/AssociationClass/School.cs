using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternOopDemo.OopDemo.Association.AssociationClass
{
    internal class School
    {

        public School()
        {
            Registrations = new HashSet<Registration>();
        }
        public HashSet<Registration> Registrations { get; private set; }

        public Registration Register(Student student, int score)
        {
            Registration registration = new Registration(this, student,score);
            Registrations.Add(registration);
            student.Registrations.Add(registration);
            return registration;
        }

    
        
    }
}
