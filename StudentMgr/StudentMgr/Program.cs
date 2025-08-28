using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chlee;

namespace StudentMgr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("홍길동");
            Student student3 = new Student("홍길동", "서울특별시");
            student1.printName();
            student1.printAddress();
            student2.printName();
            student2.printAddress();
            student3.printName();
            student3.printAddress();

        }
    }

    /// <summary>
    /// <para>StudentMgr.Student 클래스 정의</para>
    /// <para>이것은 테스트입니다.</para>
    /// </summary>
    //class Student
    //{

    //}
}
