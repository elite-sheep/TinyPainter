//==============================================================
//  Create by Yuchen Wang at 5/28/2017 4:01:26 PM.
//  Version 1.0
//  Yuchen Wang [mail: wyc8094@gmail.com]
//==============================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyPainter.Algorithm
{
    class Stack<T>
    {
        private T[] item;
        private int size;
        private int capacity;
        public int Size
        {
            get
            {
                return size;
            }
        }

        public Stack(int capacity)
        {
            this.item = new T[capacity];
            this.size = 0;
            this.capacity = capacity;
        }

        public bool isEmpty()
        {
            return Size == 0;
        }

        public void Push(T newItem)
        {
            item[size++] = newItem;
            return;
        }

        public bool Pop(ref T returnvalue)
        {
            if (this.Size == 0) return false;
            else returnvalue = item[--size];
            return true;
        }
    }
}
