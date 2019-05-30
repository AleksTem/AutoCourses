using System;

namespace HomeWork_03
{
    class CustomRange
    {
        int _minCapacity;
        long _from;
        long _to;
        long _count;

        public Int64[] Range { get; }

        #region Constructor

        public CustomRange(int minCapacity)
        {
            _minCapacity = minCapacity;

            Console.WriteLine($"Input a range of at least {minCapacity} integer values.");
            do
            {
                Console.Write("From: ");
                _from = Int64.Parse(Console.ReadLine());
                Console.Write("To: ");
                _to = Int64.Parse(Console.ReadLine());
            } while (!VerifyInput());

            _count = _to - _from + 1;
            Range = new Int64[_count];
            BuildRange();
        }

        #endregion Constructor

        #region Methods

        #region Verify Input range

        bool VerifyInput()
        {
            VerifyArrayBounds();
            if (VerifyRangeCapacity())
                return true;
            Console.WriteLine($"Input range contains {_to - _from + 1} elements.");
            Console.WriteLine($"It less then expected on {_minCapacity - (_to - _from + 1)} elements.");
            Console.WriteLine("Please retry.");
            return false;
        }

        bool VerifyRangeCapacity()
        {
            return (Math.Abs(_to - _from) + 1) >= _minCapacity ? true : false;
        }

        void VerifyArrayBounds()
        {
            if (_from > _to)
            {
                Int64 temp = _to;
                _to = _from;
                _from = temp;
            }
        }

        #endregion Verify Input range

        #region BuildRange

        void BuildRange()
        {
            Int64 item = _from;
            for (int i = 0; i < _count; i++)
            {
                Range[i] = item++;
            }
        }

        #endregion BuildRange
        #endregion Methods
    }
}
