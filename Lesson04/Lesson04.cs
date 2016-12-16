using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    class Lesson04
    {
        static void Main(string[] args)
        {
            Person a = new Person("佐藤太郎", "東京都", 20, "0303123456");
            Person b = new Person("山田花子", "青森県", 80, "0170123456");
            Person c = new Person("木村 次郎", "京都府", 38, "0750123456");

            a.print();
            b.print();
            c.print();
        }
    }
}

/*
氏名:佐藤太郎
住所:東京都
年齢:20
電話番号:0303123456

氏名:山田花子
住所:青森県
年齢:80
電話番号:0170123456

氏名:木村 次郎
住所:京都府
年齢:38
電話番号:0750123456
*/