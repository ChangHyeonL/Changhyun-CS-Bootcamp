using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class IfTest
    {
        public void Run()
        { 
            PrintResult(GetDigit());
        }

        private void PrintResult(int digit)
        {
            if (digit < 0 || digit > 100)
            {
                Console.WriteLine("잘못된 입력이거나 범위를 벗어났습니다.");
                return;
            }
                if (digit >= 90)
            {
                Console.WriteLine("우수");
                Console.WriteLine("수고하셨습니다.");
            }
            else
            {
                Console.WriteLine("보통");
                Console.WriteLine("조금 더 노력하세요");
            }
        }
        private int GetDigit()
        {
            Console.WriteLine("숫자를 입력해주세요.[0~100]");
            string val = Console.ReadLine();
            return ConvertString2Int(val);

        }

        private int ConvertString2Int(string str)
        {
            int result = 0;
            bool ret = int.TryParse(str, out result);
            if (ret)
                return result;
            else
                return -1; // -1 = 에러
        }
    }


}
