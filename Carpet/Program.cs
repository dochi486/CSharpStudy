using System.Collections.Generic;

namespace Carpet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(18, 6);
            
            // 10 2     {4, 3}
            // 8 1      {3, 3}
            // 24 24    {8, 6}
            
        }
    }
    
    public class Solution 
    {
        public int[] solution(int brown, int yellow)
        {
            int[] answer = new int[] { };
            int sum = 0;
            int num = 0;
            
            int width = 1;
            int height = 1;
            
            sum = brown + yellow;

            List<int> divisors = new List<int>();
            
            for (int i = 1; i <= sum; i++)
            {
                if(sum % i == 0)
                    divisors.Add(i);
            }
            
            // 1.a+b값의 약수를 구합니다.
            // 2.약수의 개수가 홀수냐 짝수냐에 따른 조건을 추가하고
            // 가운데부터 짝이 맞는 두가지 약수 값의 -2를 하고 곱했을때 b값과 같으면 정답입니다.

            int middleIdx = divisors.Count / 2;
            for (int i = 0; i < middleIdx; i++)
            {
                if (middleIdx < divisors.Count)
                {
                    if (divisors.Count % 2 == 0)
                    {
                        width = divisors[middleIdx - 1 - i];
                        height = divisors[middleIdx + i];
                    }
                    else
                    {
                        width = divisors[middleIdx - i];
                        height = divisors[middleIdx + i];
                    }

                    if ((width - 2) * (height - 2) == yellow)
                    {
                        answer = new int[] { height, width };
                    }
                }
            }
            return answer;
        }
    }
}