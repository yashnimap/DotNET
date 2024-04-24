using System;

namespace Gneric_List
{
    public class Generic2<T> { 
        public void Add(T T1, T T2)
        {
            dynamic a = T1;
            dynamic b = T2;
            Console.WriteLine(a+b);
        }
        public void Sub(T T1, T T2)
        {
            dynamic a = T1;
            dynamic b = T2;
            Console.WriteLine(a - b);
        }
        public void Mul(T T1, T T2)
        {
            dynamic a = T1;
            dynamic b = T2;
            Console.WriteLine(a * b);
        }
    }
}
