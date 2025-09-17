using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[35];
            students[0] = new Student("lee");
            students[1] = new Student("kim");
            students[33] = null;

            Student[] students_1 = new Student[30];
            Student[] students_2 = new Student[30];
            Student[] students_3 = new Student[30];
            //string[] name = new string[] { "홍길동", "김길동", "박길동" };
            //int[,] kor_2 = new int[,] { { 10, 20, 30 }, { 30, 40, 50 }, { 40, 50, 60 } };
            //int[,,] kor_3 = new int[,,] { { { 10, 20, 30 }, { 30, 40, 50 }, { 40, 50, 60 } }, { { 10, 20, 30 }, { 30, 40, 50 }, { 40, 50, 60 } }, { { 10, 20, 30 }, { 30, 40, 50 }, { 40, 50, 60 } } };
        }

        class Student
        {
            private int kor;
            private string name;
            public Student(string name)
            {
                this.name = name;
            }
        }
    }
}
