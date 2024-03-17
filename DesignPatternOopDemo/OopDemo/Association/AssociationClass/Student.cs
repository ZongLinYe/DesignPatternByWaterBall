using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternOopDemo.OopDemo.Association.AssociationClass
{
    internal class Student
    {
        public Student() 
        {
            Registrations = new HashSet<Registration>();
        }
        public HashSet<Registration> Registrations { get; private set; }

     
    }
}
