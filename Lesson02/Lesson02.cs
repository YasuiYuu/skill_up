﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Lesson02
    {
        static void Main(string[] args)
        {
            // ★ ここから----------

            /* ソート対象となるデータ */
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Random random = new Random();

            /*配列データをランダムに並び替える */
            for (int loop = 0; loop < data.Length; loop++)
            {

                /*変数leftとrightには、配列dataのいずれかの要素番号がランダムに代入される */
                int left = random.Next(data.Length);
                int right = random.Next(data.Length);

                int swap = data[left];
                data[left] = data[right];
                data[right] = swap;
            }

            // ★ ----------ここまでの部分は変更しないでください。

            // ソート前配列の表示
            writeData(data, "ソート前配列");

            int min;    // 最小値の添字を示す変数
            int tmp;    // 要素交換用仮変数

            // 配列dataの最小値の添字を獲得
            for (int i = 0; i < data.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[min])
                    {
                        min = j;
                    }
                }
                // 最小値要素の交換
                tmp = data[i];
                data[i] = data[min];
                data[min] = tmp;

                // ソート中配列の表示
                writeData(data, "ソート中配列");
            }
            // ソート後配列の表示
            writeData(data, "ソート後配列");
        }

        static void writeData(int[] data,string msg)
        {
            Console.WriteLine(msg);
            foreach (int num in data)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}