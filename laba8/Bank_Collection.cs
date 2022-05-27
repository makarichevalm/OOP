using System.Collections;
using System.Collections.Generic;

namespace laba8
{
    class Bank_Collection<T> : ICollection<T>
    {
        LinkedList<T> Banks = new LinkedList<T>();
        public int Count => Banks.Count;
        public bool IsReadOnly { get; set; }
        public Bank_Collection()
        {
            Banks = new LinkedList<T>();
        }
        public void Add(T item)=> Banks.AddLast(item);
        public void Clear()=> Banks.Clear();
        public bool Contains(T item) => Banks.Contains(item);
        public void CopyTo(T[] array, int arrayIndex)=>Banks.CopyTo(array, arrayIndex);
        public IEnumerator<T> GetEnumerator()
        {
            return Banks.GetEnumerator();
        }
        public bool Remove(T item)
        {
            return Banks.Remove(item);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Banks.GetEnumerator();
        }
        ~Bank_Collection()
        {
            Banks.Clear();
        }
    }
}
