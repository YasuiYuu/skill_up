using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09
{
    class Lesson09
    {
        static void Main(string[] args)
        {
            MyListManager list = new MyListManager();
            list.print();
            list.add(5, 0);
            list.add(2);
            list.add(3);
            list.print();
            list.add(6, -3);
            list.print();
            list.add(2, -1);
            list.print();
            list.add(7, 0);
            list.print();
            list.add(9, 2);
            list.print();
            list.add(8, 5);
            list.print();
            list.add(4, 7);
            list.print();
            list.add(10, 100);
            list.print();
            list.remove(-3);
            list.print();
            list.remove(-1);
            list.print();
            list.remove(0);
            list.print();
            list.remove(1);
            list.print();
            list.remove(3);
            list.print();
            list.remove(3);
            list.print();
            list.remove(100);
            list.print();
            list.remove(0);
            list.print();
            list.remove(0);
            list.print();
            list.remove(0);
            list.print();
            list.remove(0);
            list.print();
            list.remove(10);
            list.print();
            list.add(0, 1);
            list.print();
        }
    }
}