using System.Collections.Generic;
using System.Linq;

namespace WordPlay
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(3,
                new string[] {"tank", "kick", "know", "wheel", "land", "dream", "mother", "robot", "tank" });
        }
    }
    
    
    class Solution
    {
        public int[] solution(int n, string[] words)
        {
            int[] answer = new int[2];

            List<string> list = new List<string>();
            list.Add(words[0]);


            for (int i = 1; i < words.Length; i++)
            {
                if (list.Contains(words[i]) || words[i - 1][words[i - 1].Length - 1] != words[i][0])
                    return new int[2] { i % n + 1, i / n + 1 };
                
                list.Add(words[i]);
            }   
            return new int[2] {0, 0};
        }

        
        // int[] RuleCheck(List<string> list, int n)
        // {
        //     int index = 0;
        //     // 끝말잇기 규칙을 틀렸을 때 탈락
        //     for (int i = 1; i < list.Count - 1; i++)
        //     {
        //         // 끝말잇기 규칙을 어겼다면
        //         if (list[i][0] != list[i - 1][list[i - 1].Count() - 1])
        //         {
        //             index = i;
        //         } 
        //     }
        //     return new int[] {(index % n) + 1, index - 1};
        // }
        //
        // int[] DuplicateCheck(List<string> list, int n)
        // {
        //     int index = 0;
        //     int[] answer = new int[2];
        //     
        //     if (index == 0)
        //     {
        //         var duplicates = list.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);
        //
        //         //사람의 수 n과
        //         //사람들이 순서대로 말한 단어 words 가 매개변수로 주어질 때,
        //         foreach (var word in duplicates)
        //         {
        //             var lastDuplicateWord = list.FindLast(x => x == word);
        //             index = list.FindLastIndex(x => x == lastDuplicateWord);
        //         }
        //
        //         if (duplicates.ToList().Count == 0)
        //         {
        //             answer[0] = 0;
        //             answer[1] = 0;
        //         }
        //         else
        //         {
        //             answer[0] = (index / n) + 1;
        //             answer[1] = (index / n) + 1;
        //         }
        //     }
        //     return answer;
        // }
    }
}