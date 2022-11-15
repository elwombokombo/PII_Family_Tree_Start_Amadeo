using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class SumVisitor :  IVisitor<Node<Person>>, IVisitor<Person>
    {
        private int sumaEdades = 0;
        public int SumaEdades
        {
            get
            {
                return this.sumaEdades;
            }
        }
       
        public void Visit(Node<Person> node)
        {
            node.Content.Accept(this);

            foreach (Node<Person> item in node.Children)
            {
                item.Accept(this);
            }

        }
        public  void Visit(Person person)
        {
           this.sumaEdades += person.age;
        }

    }


}