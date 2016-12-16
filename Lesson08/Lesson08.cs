using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08
{
    class Lesson08
    {
        static void Main(string[] args)
        {
            int cmdno = 0;
            int tmp = 0;

            ArrayList indata = new ArrayList();
            ArrayList edata = new ArrayList();

            for (int i = 0; i < args.Length; i++)
            {
                try
                {
                    cmdno = int.Parse(args[i]);
                    indata.Add(cmdno);
                }
                catch (FormatException)
                {
                    edata.Add(args[i]);
                }
            }
            /**
             * 数値がない場合の処理
             */
            if (indata.Count <= 0)
            {
                Console.WriteLine("数値が登録されていません");
                Console.WriteLine("登録された内容一覧表示");
                for (int i = 0; i < edata.Count; i++)
                {
                    Console.WriteLine(edata[i]);
                }
                return;
            }

            /**
             * ソート前のデータを一覧表示
             */
            Console.WriteLine("ソート前のデータを一覧表示");
            for (int i = 0; i < indata.Count; i++)
            {
                Console.WriteLine(indata[i]);
            }

            /**
             * バブルソートを実施
             */
            for (int i = 0; i < indata.Count; i++)
            {
                for (int j = indata.Count - 1; j > i; j--)
                {
                    if ((int)indata[j - 1] > (int)indata[j])
                    {
                        tmp = (int)indata[j - 1];
                        indata[j - 1] = indata[j];
                        indata[j] = tmp;
                    }
                }
            }

            /**
             * ソート後のデータを一覧表示
             */
            Console.WriteLine("ソート後のデータを一覧表示");
            for (int i = 0; i < indata.Count; i++)
            {
                Console.WriteLine(indata[i]);
            }
        }
    }
}
/*
3 test 5 2 you 1 4

ソート前のデータを一覧表示
3
5
2
1
4
ソート後のデータを一覧表示
1
2
3
4
5


test you yasui

数値が登録されていません
登録された内容一覧表示
test
you
yasui

*/
