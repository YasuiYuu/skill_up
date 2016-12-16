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
                while (position.getNext() != null)
                {
                    position = position.getNext();
                }
                position.setNext(mylistitem);
            }
            else
            {
                firstItem = mylistitem;
            }
            Console.WriteLine("末尾に｢" + o + "｣を追加");
        }

        public void add(Object o, int i)
        {
            MyListItem mylistitem = new MyListItem(o);
            MyListItem position = firstItem;
            int j = 0;
            while (position != null)
            {
                position = position.getNext();
                j++;
            }
            if (i > j && i != 0)
            {
                Console.WriteLine("｢" + i + "｣番目は保存データ数を越えているため追加失敗");
                return;
            }
            else if (i < 0)
            {
                Console.WriteLine("iの値がゼロより下です。");
                return;
            }
            else if (i == 0)
            {
                position = firstItem;
                mylistitem.setNext(position);
                firstItem = mylistitem;
            }
            else
            {
                position = firstItem;
                for (int k = 0; k < i - 1; k++)
                {
                    position = position.getNext();
                }
                mylistitem.setNext(position.getNext());
                position.setNext(mylistitem);
            }
            Console.WriteLine("｢" + i + "｣番目に｢" + o + "｣を追加");
        }

        public void remove(int i)
        {
            MyListItem nextposition = firstItem;
            MyListItem position = firstItem;
            int j = 0;
            while (position != null)
            {
                position = position.getNext();
                j++;
            }
            if (i >= j)
            {
                Console.WriteLine("｢" + i + "｣番目は保存データ数を越えているため削除失敗");
                return;
            }
            else if (i < 0)
            {
                Console.WriteLine("iの値がゼロより下です。");
                return;
            }
            else if (i == 0)
            {
                nextposition = nextposition.getNext();
                firstItem = nextposition;
            }
            else
            {
                position = firstItem;
                for (int k = 0; k <= i; k++)
                {
                    nextposition = nextposition.getNext();
                }
                for (int k = 0; k < i - 1; k++)
                {
                    position = position.getNext();
                }
                position.setNext(nextposition);
            }
            Console.WriteLine("｢" + i + "｣番目を削除");
        }

        public void print()
        {
            MyListItem position = firstItem;
            Console.WriteLine("すべてのデータを先頭から順に出力");
            if (position != null)
            {
                while (position != null)
                {
                    Console.Write(position.getItem() + " ");
                    position = position.getNext();
                }
            }
            else
            {
                Console.WriteLine("リストにデータが登録されていません");
            }
            Console.WriteLine();
        }
    }
}
