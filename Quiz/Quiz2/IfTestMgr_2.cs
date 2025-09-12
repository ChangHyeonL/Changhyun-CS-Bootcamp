using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    internal class IfTestMgr_2
    {
        public void Run()
        {
            PrintResult(Util.GetDigit());
        }

        private void PrintResult(int digit)
        {
            if (digit < 0 || digit > 100)
            {
                Console.WriteLine("잘못된 입력 입니다.");
            }
            if (digit >= 90)
            {
                Console.WriteLine("우수");
                Console.WriteLine("수고하셨습니다");
            }
            else
            {
                Console.WriteLine("보통");
                Console.WriteLine("노력하세요");
            }
        }
    }
}
