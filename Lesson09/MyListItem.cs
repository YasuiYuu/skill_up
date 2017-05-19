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
            Item = null;
            Next = null;
        }

        public MyListItem(Object value)
        {
            Item = value;
            Next = null;
        }

        public MyListItem(Object value, MyListItem id)
        {
            Item = value;
            Next = id;
        }

        public MyListItem Next
        {
            get { return next; }
            set { next = value; }
        }

        public Object Item
        {
            get { return item; }
            set { item = value; }
        }
    }
}
