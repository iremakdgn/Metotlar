using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //t : programcı ne tip verirse demek
    {
        T[] items;
        public MyList() //constructor
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizide itemsı tutuyo
            items = new T[items.Length+1];
            for(int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
