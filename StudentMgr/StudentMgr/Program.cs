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
            student1.SetName("홍길동");
            student1.SetAge(1000);
            student1.SetAge(-1);
            Console.WriteLine(student1.Name);

        }
    }

    
}
