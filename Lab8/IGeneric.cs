using System;

namespace Lab8
{
    interface IGeneric<Type>
    {
        void MyAdd(Type item);
        Type Delete(int item);
        void Check();
    }
}
