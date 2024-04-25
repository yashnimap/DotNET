using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializaionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\Nimap\Desktop\serializationFile\sample.text";
            //Employee emp = new Employee(101, "Yash");
            //Employee emp1 = new Employee(102, "Jadhav"); 
            //FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter formatter = new BinaryFormatter();  
            //formatter.Serialize(stream, emp1);
            //stream.Close();
            //Console.WriteLine("file has been created successfully");
            //Console.ReadLine();

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
