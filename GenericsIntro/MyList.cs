using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        //whenever we renew the class, constructor will work.
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];   
         
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Here we will protect our last know data, otherwise every time we call new items it would lost last date.
            items = new T[items.Length + 1]; //By this way we make our code dynamic, and we will increase it every time we call the constructor.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //one by one items get back its last know dates from tempArray.

            }
                items[items.Length - 1] = item;

            
        }
    }
}
