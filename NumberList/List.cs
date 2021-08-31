using System;

namespace NumberList
{
    class List<T>
    {
        T[] _numbers;
        int _count;

        public List()
        {
            _numbers = new T[4];
            _count = 0;
        }

        public void Add(T value )
        {
            if (_count >= _numbers.Length)
            {
                var numbersTmp = _numbers;
                _numbers = new T[_numbers.Length * 2];
                Array.Copy(numbersTmp, _numbers, numbersTmp.Length);
                Console.WriteLine("Doblet kapasitet til " + _numbers.Length);
            }
            _numbers[_count] = value;
            _count++;
        }

        public void Show()
        {
            Console.WriteLine(string.Join(", ", _numbers));
        }
    }
}
