using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace De_serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nimap\Desktop\serializationFile\sample.text";
            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            SerializaionDemo.Employee emp = (SerializaionDemo.Employee)formatter.Deserialize(stream);
            De_serialization.Employee demp = new De_serialization.Employee(emp.id,emp.name);
            if (demp != null)
            {
                Console.WriteLine("Employee id: " + demp.id);
                Console.WriteLine("Employee name: " + demp.name);
            }
            else
            {
                Console.WriteLine("Failed to deserialize Employee object.");
            }
           
            Console.ReadLine();
        }
    }
}
