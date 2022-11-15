using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person ("Mario",104);
            Person p2 = new Person ("Jesús",80);
            Person p3 = new Person ("Juanito",70);
            Person p4 = new Person ("Agustina",40);
            Person p5 = new Person ("Amadeo",37);
            Person p6 = new Person ("Juan",52);
            Person p7 = new Person ("Javier",20);
            Person p8 = new Person ("Matías",10);


            Node<Person> np1 = new Node <Person> (p1);
            Node<Person> np2 = new Node <Person> (p2);
            Node<Person> np3 = new Node <Person> (p3);
            Node<Person> np4 = new Node <Person> (p4);
            Node<Person> np5 = new Node <Person> (p5);
            Node<Person> np6 = new Node <Person> (p6);
            Node<Person> np7 = new Node <Person> (p7);
            Node<Person> np8 = new Node <Person> (p8);

            //en el nodo de Mario agrego estos dos:
        
            np1.AddChildren(np2); //agrego a Jesús como hijo de Mario
            np1.AddChildren(np3); //agrego Juanito como hijo de Mario

            //en el nodo de Jesús:

            np2.AddChildren(np4); //agrego a Agustina como hijo de Jesús
            np2.AddChildren(np5); //agrego a Amadeo como hijo de Jesús
            np2.AddChildren(np6); //agrego a Juan como hijo de Jesús

            //en el de Juan:

            np6.AddChildren(np7); //agrego a Javier como hijo de Juan
            
            //en el de Amadeo
            np5.AddChildren(np8);//agrego a Matías como hijo de Amadeo

            //creo instancia de los visitadores:

            SumVisitor v1 = new SumVisitor();
            VisitorName v2 = new VisitorName();
            VisitorOld v3 = new VisitorOld();

            v1.Visit (np4);
            v2.Visit (np4);
            v3.Visit (np4);
         

            np1.Accept(v1);
            Console.WriteLine($"Suma de edades:{v1.SumaEdades}");

            np1.Accept(v2);
            Console.WriteLine($"Nombre mas largo es {v2.LongestName}");

            np1.Accept(v3);
            Console.WriteLine($"El mas viejo es: {v3.OldestKid}");

        }
    }
}