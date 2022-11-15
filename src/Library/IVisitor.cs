using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface IVisitor <T>
    {
        void Visit(T t);
    }

}