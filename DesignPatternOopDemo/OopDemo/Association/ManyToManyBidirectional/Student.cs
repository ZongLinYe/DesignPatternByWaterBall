﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternOopDemo.OopDemo.Association.ManyToManyBidirectional
{
    internal class Student
    {
        private string _description = string.Empty;
        private int _age;        
        public Student(int id, string name, string description, int age)
        {
            Id = id;
            Name = name;
            Description = description;
            Age = age;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Description cannot be null or empty");
                }
                // char[200]
                if (value.Length > 200)
                {
                    throw new ArgumentException("Description cannot be more than 200 characters");
                }
                _description = value;
            }
        }
        /// <summary>
        /// 7<=age<=150
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 7 || value > 150)
                {
                    throw new ArgumentException("Age must be between 7 and 150");
                }
                _age = value;
            }
        }

        public HashSet<Subject> Subjects { get; private set; }

        public void Study(Subject subject)
        {
            subject.Students.Add(this);
            Console.WriteLine($"{Name} is studying {subject.Name}");
            Subjects.Add(subject);
        }
    }
}
