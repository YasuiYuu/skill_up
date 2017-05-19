using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09
{
    class MyListManager
    {
        private MyListItem firstItem;

        public MyListManager()
        {
            firstItem = null;
        }

        public void add(Object o)
        {
            MyListItem mylistitem = new MyListItem(o);
            MyListItem position = firstItem;
            if (position != null)
            {
                while (position.Next != null)
                {
                    position = position.Next;
                }
                position.Next = mylistitem;
            } else {
                firstItem = mylistitem;
            }
            Console.WriteLine("末尾に｢" + o + "｣を追加");
            Console.WriteLine();
        }

        public void add(Object o, int i)
        {
            MyListItem mylistitem = new MyListItem(o);
            MyListItem position = firstItem;
            int j = 0;
            while (position != null)
            {
                position = position.Next;
                j++;
            }
            if (i > j && i != 0)
            {
                Console.WriteLine("｢" + i + "｣番目は保存データ数を越えているため追加失敗");
                Console.WriteLine();
                return;
            } else if (i < 0) {
                Console.WriteLine(i + " : iの値がゼロより下です。");
                Console.WriteLine();
                return;
            } else if (i == 0) {
                position = firstItem;
                mylistitem.Next = position;
                firstItem = mylistitem;
            } else {
                position = firstItem;
                for (int k = 0; k < i - 1; k++)
                {
                    position = position.Next;
                }
                mylistitem.Next = position.Next;
                position.Next = mylistitem;
            }
            Console.WriteLine("｢" + i + "｣番目に｢" + o + "｣を追加");
            Console.WriteLine();
        }

        public void remove(int i)
        {
            MyListItem nextposition = firstItem;
            MyListItem position = firstItem;
            int j = 0;
            while (position != null)
            {
                position = position.Next;
                j++;
            }
            if (i >= j)
            {
                Console.WriteLine("｢" + i + "｣番目は保存データ数を越えているため削除失敗");
                Console.WriteLine();
                return;
            } else if (i < 0) {
                Console.WriteLine(i + " : iの値がゼロより下です。");
                Console.WriteLine();
                return;
            } else if (i == 0) {
                nextposition = nextposition.Next;
                firstItem = nextposition;
            } else {
                position = firstItem;
                for (int k = 0; k <= i; k++)
                {
                    nextposition = nextposition.Next;
                }
                for (int k = 0; k < i - 1; k++)
                {
                    position = position.Next;
                }
                position.Next = nextposition;
            }
            Console.WriteLine("｢" + i + "｣番目を削除");
            Console.WriteLine();
        }

        public void print()
        {
            MyListItem position = firstItem;
            Console.WriteLine("すべてのデータを先頭から順に出力");
            if (position != null)
            {
                while (position != null)
                {
                    Console.Write(position.Item + " ");
                    position = position.Next;
                }
            } else {
                Console.Write("リストにデータが登録されていません");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
