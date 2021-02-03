using System;
using System.Collections.Generic;

namespace GenericsMore
{
    class MyList2
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            Console.WriteLine(cities.Count);//count bir propertiy dir. biz de kendi mylist clasiimiza bu ozelligi ekleyelim
            cities.Add("Ankara");
            Console.WriteLine(cities.Count);

            MyList<string> cities2 = new MyList<string>();
            cities2.Add("Izmit");
            Console.WriteLine(cities2.Count);
            cities2.Add("csdcfw");
            cities2.Add("csdcfw");
            cities2.Add("csdcfw");
            cities2.Add("csdcfw");
            Console.WriteLine(cities2.Count);

        }

        class MyList<T> //bu artik bi generic class pga <>
        {
            T[] _array;
            T[] _tempArray;
            public MyList()
            {
                _array = new T[0];
            }
            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];

                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }

                _array[_array.Length - 1] = item;
            }

            private int _count;

            public int Count
            {
                get { return _array.Length; }
                
            }

        }

    }
}
