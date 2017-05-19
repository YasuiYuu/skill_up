using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    class Lesson06
    {
        static void Main(string[] args)
        {
            ArrayList indata = new ArrayList();

            Person a = new Person("佐藤太郎", "東京都", 20, "0303123456");
            Person b = new Employee("山田花子", 80, "所属部署名", "0170123456");
            Person c = new Engineer("木村 次郎", "京都府", 38, "保有技術", "0750123456");

            indata.Add(a);
            indata.Add(b);
            indata.Add(c);
            foreach (Person outdata in indata)
            {
                outdata.print();
            }
        }
    }
}