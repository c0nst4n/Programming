using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListChunga
{
    internal class Pool<T> where T : new()
    {
        List<T> GenericList = new List<T>();

        public T Adquire()
        {
            if (GenericList.Count == 0)
            {
                return new T();
            }

            int index = GenericList.Count - 1;

            T item = GenericList[index];

            GenericList.RemoveAt(index);

            return item;
        }

        public void Release(T item)
        {
            GenericList.Add(item);
        }

    }
}
