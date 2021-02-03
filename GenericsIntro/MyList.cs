using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        
        public MyList()  //constructor 
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;//yenisi eklenince eskisi silinecegi icin bununla bir onceki degeri tutumus oldum
            items = new T[items.Length+1];//bu sekilde her seferinde eleman sayimi hep bir artirmis olurum ekleyebilmek icin
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        } 

        public T[] Items
        {
            get { return items; }
        }
    }
}
