using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03
{
    class CustomRange
    {
        int _minCapacity;
        int _from;
        int _to;
        int _count;

        public int[] Range { get; }

    #region Constructor

        public CustomRange(int minCapacity)
        {
            _minCapacity = minCapacity;           

            Console.WriteLine($"Input a range of at least {minCapacity} integer values.");
            do
            {
                Console.Write("From: ");
                _from = Int32.Parse(Console.ReadLine());
                Console.Write("To: ");
                _to = Int32.Parse(Console.ReadLine());                
            } while (!VerifyInput());

            _count = _to - _from + 1;
            Range = new int[_count];
            BuildRange();
        }

    #endregion Constructor

    #region Methods
    
        #region Verify Input range

        bool VerifyInput()
        {
            VerifyArrayBounds();
            if(VerifyRangeCapacity())
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
                int temp = _to;
                _to = _from;
                _from = temp;
            }
        }

        #endregion Verify Input range

        #region BuildRange

        void BuildRange()
        {
            int item = _from;
            for (int i = 0; i < _count; i++)
            {
                Range[i] = item++;
            }
        }

        #endregion BuildRange
    #endregion Methods
    }
}
