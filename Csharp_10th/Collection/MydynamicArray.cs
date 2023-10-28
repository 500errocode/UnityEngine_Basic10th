using System.Text.RegularExpressions;
using System;

namespace Collection
{
    internal class MyDynamicArray<T>
        where T : IEnumerable<T>
    {
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();

                return this[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();

                _items[index] = value;
            }
        }

        //동적배열의 용량
        public int Capacity => _items.Length;

        //실제 가지고 있는 자료의 개수
        public int Count => _count;

        private const int DEFAULT_SIZE = 1;
        private T[] _items = new T[DEFAULT_SIZE];
        private int _count;
        private object match;

        //매치 조건 검색
        public T Find(Predicate<T> predicate)
        {
            for (int i = 0; i < _count; i++)
            {
                if (match.Invoke(_items[i]))
                    return _items[i];
            }
        }

        public T FindIndex(Predicate<T> predicate)
        {
            for (int i = 0; i < _count; i++)
            {
                if (match.Invoke(_items[i]))
                    return _items[i];
            }
        }

        public void Add(T item)
        {
            if (_count >= _items.Length)
            {
                T[] tmp = new T[_count * 2];
                Array.Copy(_items, tmp, _count);
                _items = tmp;
            }

            _items[_count++] = item; //마지막에 아이템 추가
        }
        //삭제
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _count--; // 하나 뺐으니까 차감
        }

        public bool Remove(T item)
        {
            int index = FindIndex(x => x.Equals(item));

            if (index < 0)
                return false;

            RemoveAt(index);
            return true;
        }
    }
}