using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Lesson08
{
    class Lesson08
    {
        static void Main(string[] args)
        {
            int cmdno = 0;
            int tmp = 0;
            int result;

            ArrayList indata = new ArrayList();
            ArrayList edata = new ArrayList();

            //コマンドライン引数を表示する
            Console.WriteLine("入力されたコマンドライン引数を表示");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < args.Length; i++)
            {
                try
                {
                    if (int.TryParse(Microsoft.VisualBasic.Strings.StrConv(args[i], VbStrConv.Narrow), out result))
                    {
                        cmdno = int.Parse(Microsoft.VisualBasic.Strings.StrConv(args[i], VbStrConv.Narrow));
                        indata.Add(cmdno);
                    }
                    else
                    {
                        edata.Add(args[i]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            /**
             * 数値がない場合の処理
             */
            if (indata.Count <= 0)
            {
                writeData(edata, "数値が登録されていません");
                return;
            }

            /**
             * ソート前のデータを一覧表示
             */
            writeData(indata, "ソート前のデータを一覧表示");

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
            writeData(indata, "ソート後のデータを一覧表示");
        }

        static void writeData(ArrayList data, string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }
            Console.WriteLine();
        }
    }
}
