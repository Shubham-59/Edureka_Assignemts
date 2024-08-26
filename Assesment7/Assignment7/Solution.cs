using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Solution 
    {
        public int solution(int[] A)
        {
            int minPositiveValue = int.MaxValue;
            bool isPositive = false;

            foreach (int num in A)
            {
                if (num > 0)
                {
                    minPositiveValue = Math.Min(minPositiveValue, num);
                    isPositive = true;
                }
            }
            if (!isPositive)
            {
                return 0;
            }
            return minPositiveValue;
        }
    }   
}
