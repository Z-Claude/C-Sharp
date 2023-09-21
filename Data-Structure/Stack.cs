using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    /// <summary>
    /// 特点先进后出
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T>
    {
        private T[] _array;
        private int _size;
        private int _version;
        private const int DefaultCapacity = 4;
        public Stack()
        {
            _array = Array.Empty<T>();
        }
        public Stack(int capacity)
        {
            _array = new T[capacity];
        }
        /// <summary>
        /// 返回但不删除
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            int size = _size - 1;
            T[] array = _array;

            if ((uint)size >= (uint)array.Length)
            {
                ThrowForEmptyStack();
            }

            return array[size];
        }

        public bool TryPeek(out T result)
        {
            int size = _size - 1;
            T[] array = _array;

            if ((uint)size >= (uint)array.Length)
            {
                result = default!;
                return false;
            }
            result = array[size];
            return true;
        }

        public void Push(T value)
        {


        }

        public void Pop()
        {

            _size--;
        }

        public int Count => _size;

        public void Clear()
        {


        }

        private void ThrowForEmptyStack()
        {
            Debug.Assert(_size == 0);
            throw new InvalidOperationException();
        }

    }
}
