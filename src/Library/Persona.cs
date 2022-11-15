using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        public string name {get; }
        public int age {get; }
        
        public  Person (string name, int age) 
        {
            this.name = name;
            this.age = age;

        }
        public void Accept(IVisitor<Person> visitor)
        {
             visitor.Visit(this);
        }


    }
}