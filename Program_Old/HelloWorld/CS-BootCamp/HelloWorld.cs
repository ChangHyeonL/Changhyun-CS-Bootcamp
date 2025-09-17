
using System;

class HelloWorld
{
    static void Main()
    {
        //PrintHello("Hello World!");

        //PrintHello("안녕하세요 여러분!");
        AA var = new AA();
        var.PrintHello("안녕하세요 여러분!");
    }

    /*static void PrintHello(string str)
    {
        Console.WriteLine(str);
    }*/


}

class AA
{
    public void PrintHello(string str)
    {
        Console.WriteLine(str);
    }
}

