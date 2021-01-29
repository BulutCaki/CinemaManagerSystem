using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagerSystem
{
    class FilmList<T>
    {
        T[] items;
        T[] tempArray;
        public FilmList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            tempArray = items;
            items = new T[items.Length + 1];
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

        public T[] Film
        {
            get { return items; }
        }
    }
}