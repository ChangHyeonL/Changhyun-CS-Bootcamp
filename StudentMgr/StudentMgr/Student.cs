using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
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
        //private string name;
        private string address;
        private int age;

        #region 생성자
        public Student(string name, string address)
        {
            this.Name = name;
            this.address = address;
        }
        public Student(string name):this(name, null)
        {
        }

        public Student():this(null)
        {
        }
        #endregion

        public string Name { get; set; }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            if(age<0 || age > 121)
            {
                Console.WriteLine("나이는 음수나 120세를 넘을 수 없습니다");
                return;
            }
            this.age = age;
        }

        public void printName()
        {
            Console.WriteLine("name = " + Name);
        }

        public void printAddress()
        {
            Console.WriteLine("address = " + address);
        }
    }
}
