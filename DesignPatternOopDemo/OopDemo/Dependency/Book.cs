using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternOopDemo.OopDemo.Dependency
{
    internal class Book
    {
        public Book(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }    
    }
}
