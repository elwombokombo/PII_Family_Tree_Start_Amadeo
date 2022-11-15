using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class Node<T>
    {
        private T content;

        private List<Node<T>> children = new List<Node<T>>();
        
        public ReadOnlyCollection<Node<T>> Children 
        { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T content)
        {
            this.content = content;
        }

        public T Content
        {
            get
            {
                return this.content;
            }
        }
        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        public void Accept(IVisitor<Node<T>> visitor)
        {
             visitor.Visit(this);
        }
        
        

               
    }
}
