using NUnitLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            List<int> list = new List<int>();
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                    list.Add(num);
            }
            return list.ToArray();
        }
    }
}