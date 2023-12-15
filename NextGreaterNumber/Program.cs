using System;
using System.IO;

namespace NextGreaterNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(78);
        }
    }
    
    class Solution 
    {
        public int solution(int n) 
        {
            int answer = 0;
            int bitCount = 0;
            int otherBitCount = 0;
            
            var binary = Convert.ToString(n, 2);
            
            foreach (var num in binary)
            {
                if (num == '1')
                    bitCount++;
            }
            
            do
            {
                otherBitCount = 0;
                n++;
                var converted = Convert.ToString(n , 2);

                foreach (var num in converted)
                {
                    if (num == '1')
                    {
                        otherBitCount++;
                    }
                }
                
                if (bitCount == otherBitCount)
                {
                    answer = Convert.ToInt32(converted, 2);
                    break;
                }
            } while (bitCount != otherBitCount);
            
            return answer;
        }
    }
}