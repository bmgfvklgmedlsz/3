﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age) 
        {
            Name = name;
            Age = age;
        }
        public void ShowData()
        {
            Console.WriteLine($"имя: {Name}, возраст: {Age}");
        }
        public void voice ()
        {
            Console.WriteLine("мычание");
        }
    }

}
