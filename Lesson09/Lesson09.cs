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
/*
すべてのデータを先頭から順に出力
リストにデータが登録されていません

｢0｣番目に｢5｣を追加
末尾に｢2｣を追加
末尾に｢3｣を追加
すべてのデータを先頭から順に出力
5 2 3
iの値がゼロより下です。
すべてのデータを先頭から順に出力
5 2 3
iの値がゼロより下です。
すべてのデータを先頭から順に出力
5 2 3
｢0｣番目に｢7｣を追加
すべてのデータを先頭から順に出力
7 5 2 3
｢2｣番目に｢9｣を追加
すべてのデータを先頭から順に出力
7 5 9 2 3
｢5｣番目に｢8｣を追加
すべてのデータを先頭から順に出力
7 5 9 2 3 8
｢7｣番目は保存データ数を越えているため追加失敗
すべてのデータを先頭から順に出力
7 5 9 2 3 8
｢100｣番目は保存データ数を越えているため追加失敗
すべてのデータを先頭から順に出力
7 5 9 2 3 8
iの値がゼロより下です。
すべてのデータを先頭から順に出力
7 5 9 2 3 8
iの値がゼロより下です。
すべてのデータを先頭から順に出力
7 5 9 2 3 8
｢0｣番目を削除
すべてのデータを先頭から順に出力
5 9 2 3 8
｢1｣番目を削除
すべてのデータを先頭から順に出力
5 2 3 8
｢3｣番目を削除
すべてのデータを先頭から順に出力
5 2 3
｢3｣番目は保存データ数を越えているため削除失敗
すべてのデータを先頭から順に出力
5 2 3
｢100｣番目は保存データ数を越えているため削除失敗
すべてのデータを先頭から順に出力
5 2 3
｢0｣番目を削除
すべてのデータを先頭から順に出力
2 3
｢0｣番目を削除
すべてのデータを先頭から順に出力
3
｢0｣番目を削除
すべてのデータを先頭から順に出力
リストにデータが登録されていません

｢0｣番目は保存データ数を越えているため削除失敗
すべてのデータを先頭から順に出力
リストにデータが登録されていません

｢10｣番目は保存データ数を越えているため削除失敗
すべてのデータを先頭から順に出力
リストにデータが登録されていません

｢1｣番目は保存データ数を越えているため追加失敗
すべてのデータを先頭から順に出力
リストにデータが登録されていません
*/