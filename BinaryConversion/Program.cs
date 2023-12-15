using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryConversion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution("01110");
        }
    }
    
    public class Solution {
        public int[] solution(string s)
        {
            List<int> answer = new List<int>();
            int zeroRemoveCount = 0;
            int convertedCount = 0;
            
            do
            {
                foreach (var num in s)
                {
                    if (num == '0')
                    {
                        zeroRemoveCount++;
                    }
                }
                s = s.Replace("0", "");
            
                var truncatedLength = s.Length;
        
                s = Convert.ToString(truncatedLength, 2);
                convertedCount++;
            
            } while (s != "1");

            answer.Add(convertedCount);
            answer.Add(zeroRemoveCount);
            
            return answer.ToArray();
        }
    }
    
}