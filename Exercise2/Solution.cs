using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise2
{
    class Solution
    {
        public int solution(int[] A)
        {
            var query = A.GroupBy(num => num).Select(group => group).OrderByDescending(group => group.Count()).First().Key;
            return Convert.ToInt32(query);
        }
    }
}
