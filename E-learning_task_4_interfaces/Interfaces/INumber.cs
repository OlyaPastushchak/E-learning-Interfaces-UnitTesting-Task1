using System;

namespace E_learning_task_4_interfaces.Interfaces
{
    public interface INumber : ICloneable, IComparable<INumber>
    {
        INumber Add(INumber obj);
        INumber Subtract(INumber obj);
        INumber Divide(INumber obj);
        INumber Multiply(INumber obj);
        void Divide(int num);
    }
}
