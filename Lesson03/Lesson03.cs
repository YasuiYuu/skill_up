using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    class Lesson03
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
            Console.WriteLine("ソート前配列");
            foreach (int num in data)
            {
                Console.Write(num + " ");
            }

            int i;
            int j;
            int tmp;        // 要素交換用仮変数
            int flag = 1;   // ソート完了判断フラグ

            //隣接交換法
            for (i = data.Length - 1; i > 0 && flag == 1; i--)
            {
                flag = 0;
                for (j = 0; j < i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        //要素の交換
                        tmp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tmp;
                        flag = 1;
                    }
                }
            }
            // ソート後配列の表示
            Console.WriteLine();
            Console.WriteLine("ソート後配列");
            foreach (int num in data)
            {
                Console.Write(num + " ");
            }
        }
    }
}
/*
ソート前配列
2 6 8 7 10 9 4 5 3 1
ソート後配列
1 2 3 4 5 6 7 8 9 10
*/