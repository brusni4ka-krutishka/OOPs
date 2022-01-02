using System;

namespace Lab8
{
    interface IGeneric<Type>
    {
        void Add(Type item);
        Type Delete(int item);
        void Check();
    }
}
