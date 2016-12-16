using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09
{
    class MyListItem
    {
        private MyListItem next;
        private Object item;

        public MyListItem()
        {
            setItem(null);
            setNext(null);
        }

        public MyListItem(Object value)
        {
            setItem(value);
            setNext(null);
        }

        public MyListItem(Object value, MyListItem id)
        {
            setItem(value);
            setNext(id);
        }

        public MyListItem getNext()
        {
            return next;
        }

        public void setNext(MyListItem next)
        {
            this.next = next;
        }

        public Object getItem()
        {
            return item;
        }

        public void setItem(Object item)
        {
            this.item = item;
        }
    }
}
