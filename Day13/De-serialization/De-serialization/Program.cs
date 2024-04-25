using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

//using System.Runtime.Serialization.Formatters.Binary;
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
            Employee emp = (Employee)formatter.Deserialize(stream);
            if (emp != null)
            {
                Console.WriteLine("Employee id: " + emp.id);
                Console.WriteLine("Employee name: " + emp.name);
            }
            else
            {
                Console.WriteLine("Failed to deserialize Employee object.");
            }
           
            Console.ReadLine();
        }
    }
}
