using System;
using System.Collections.Generic;
using System.Linq;

namespace CorrectBracket
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(")()(");
        }
        
        public class Solution {
            public bool solution(string s) 
            {
                bool answer = true;
                /*
                 *brute force 구현
                1. 원본 배열의 복사본 배열 생성
                2. 복사본 배열의 순서를 reverse
                3. index로 순서대로 () 짝이 맞는지 검사
                4. () 짝이 안 맞으면 return false
                5. return false 되지 않으면 return true
                
                1. 배열로 변경
                2. ( -> 1로 변경
                3. ) -> -1로 변경
                4.
                5. 1이 나오면 곱하기 2해서 누적시키는 변수 생성
                6. -1이 나오면 곱하기 2하는 누적시키는 변수 생성
                7.  for문 순환
                8. 0이면 true
                 */
                
                // 주어진 string에서 () 괄호 짝이 맞는지 확인 

                var strings = s.ToArray();
                
                int bracketNum = 0;
                List<int> bracketList = new List<int>();
                
                foreach (var bracket in strings)
                {
                    if (bracket == '(')
                    {
                        bracketList.Add(1);
                    }
                    else
                    {
                        bracketList.Add(-1);
                    }
                }

                int complete = 0;
                
                for (int i = 0; i < bracketList.Count; i++)
                {
                    complete += (int)Math.Pow(bracketList[i], 2);
                }
                
                return answer = complete == 0;
            }
        }
    }
}