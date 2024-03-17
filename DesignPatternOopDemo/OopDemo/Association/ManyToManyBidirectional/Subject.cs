using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternOopDemo.OopDemo.Association.ManyToManyBidirectional
{
    internal class Subject
    {
        public Subject(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
        public HashSet<Student> Students { get; set; }
    }
}
