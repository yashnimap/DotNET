using System;

namespace De_serialization
{
    [Serializable]
    internal class Employee
    {
        public int id;
        public string name;

        public Employee(int Id, string Name)
        {
            this.id = Id;
            this.name = Name;
        }

    }
}
