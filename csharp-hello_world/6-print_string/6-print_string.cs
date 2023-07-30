using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
        string strRep = string.Concat(str, str, str);
        Console.WriteLine(strRep);
        string nineChar = str.Substring(0, 9);
        Console.WriteLine(nineChar);
    }
}