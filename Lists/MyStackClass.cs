using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class MyStackClass<T>
    {
        MyLinkedList<T> _list;

        public MyStackClass()
        {
            _list = new MyLinkedList<T>();
        }

        public bool Push(T data)
        {
            _list.Add2Start(data);
            return true;
        }

        public bool Pop(out T data)
        {
            if (this.IsEmpty())
            {
                data = default(T);
                return false;
            }
            return _list.RemoveFromStart(out data);
        }

        public bool IsEmpty()
        {
            return _list.IsEmpty();
        }
    }
}
