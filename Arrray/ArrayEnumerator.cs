using System.Collections;

namespace DataStructures.Arrray
{
    internal class ArrayEnumerator : IEnumerator
    {
        private Object[] innerArray; 
        public int index; 
        public object Current => innerArray[index];

        public ArrayEnumerator(Object[] arr)
        {
            innerArray = arr;
            index = innerArray.Length;
        }
        public bool MoveNext()
        {
            if (index==innerArray.Length)
            {
                index--;
                return true;    
            }
            if (index>0)
            {
                index--;
                return true;
            }
            else
            {
                index = innerArray.Length;
                return false;
            }
        }

        public void Reset()
        {
            index=innerArray.Length;
        }
    }
}