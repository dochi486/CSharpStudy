using System.Collections.Generic;
using System.Linq;
using System;

namespace CsharpTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(new int[] { 1, 4, 2 }, new int[] { 5, 4, 4 });
        }

        public class Solution
        {
            public int solution(int[] A, int[] B)
            {
                int answer = 0;
                List<int> answerList = new List<int>();
                
                //1. A 배열 정렬
                Array.Sort(A);
                
                //2. B 배열 역순 정렬 => A의 최소값과 B의 최대값을 곱해서 더하면 그게 최소 곱한 더한값(..) 이니까
                Array.Sort(B);
                Array.Reverse(B);

                for (int i = 0; i < A.Length; i++)
                {
                    answerList.Add(A[i] * B[i]);
                }
                
                //3. index 순서대로 곱한 값을 배열 C에 넣는다
                foreach (var item in answerList)
                {
                    answer += item;
                }
                
                return answer;
            }
        }
    }
}