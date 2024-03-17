using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternOopDemo.OopDemo.Association.Unidirectional
{
    internal class Subject
    {
        public Subject(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}
