using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 조건문
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int min = 0;
            int max = 5;
            Console.WriteLine("숫자를 입력하세요.1");
            string val = Console.ReadLine();
            int c = int.Parse(val);
            Console.WriteLine("c 값은" + c);
            //비교연산자, 논리연산자, bool 값
            switch(c)
            {
                case 0:
                    PrintSheet();
                    break;
                case 1:
                    ReadData();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("해당사항 없습니다");
                    break;
            }
        }

        private static void ReadData()
        {
            throw new NotImplementedException();
        }

        private static void PrintSheet()
        {
            throw new NotImplementedException();
        }
    }
}
