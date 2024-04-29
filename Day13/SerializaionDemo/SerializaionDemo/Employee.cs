using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializaionDemo
{
    [Serializable]
    public class Employee
    {
        public int id;
        public string name;

        public Employee(int Id , string Name) {
            this.id = Id;
            this.name = Name;
        }

    }
}
