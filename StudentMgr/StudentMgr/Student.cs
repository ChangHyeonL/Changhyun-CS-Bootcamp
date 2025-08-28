using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chlee

{
    //Class Fullname => namespace.class_name
    /// <summary>
    /// chlee.Student 클래스 정의
    /// </summary>
    public class Student
    {
        private string name;
        private string address;

        public Student(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public Student(string name):this(name, null)
        {
        }

        public Student():this(null)
        {
        }


       

        public void printName()
        {
            Console.WriteLine("name = " + name);
        }

        public void printAddress()
        {
            Console.WriteLine("address = " + address);
        }
    }
}
