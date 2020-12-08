using System;
using System.Collections;
using System.Linq;

namespace lab9_v9.Class
{
    public class ToyCollection: IEnumerable
    {
        private Toy[] _toys;
        public ToyCollection(Toy[] arr)
        {
            _toys = new Toy[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                _toys[i] = arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public ToyEnum GetEnumerator()
        {
            return new ToyEnum(_toys);
        } 
    }

    public class ToyEnum : IEnumerator
    {
        public Toy[] _toys;

        private int _pos = -1;

        public ToyEnum(Toy[] list)
        {
            _toys = list;
        }

        public bool MoveNext()
        {
            _pos++;
            return (_pos < _toys.Length);
        }

        public void Reset()
        {
            _pos = -1;
        }

        object IEnumerator.Current { get; }

        public Toy Current
        {
            get
            {
                try
                {
                    return _toys[_pos];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}