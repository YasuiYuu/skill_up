using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    class Lesson01
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++)
            {
                if (num % 3 == 0 || num % 10 == 3 || 30 <= num && num <= 39)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}

/*
3 6 9 12 13 15 18 21 23 24 27 30 31 32 33 34 35 36 37 38 39 42 43 45 48 51 53 54 57 60 63 66 69 72 73 75 78 81 83 84 87 90 93 96 99
*/