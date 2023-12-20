using System;

namespace Tournament
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(8, 4, 7);
        }
    }
    
    class Solution
    {
        public int solution(int n, int a, int b)
        {
            int answer = 0;

            /*
             * 대진표는 2의 n승의 개수만큼 주어지고, 라운드가 진행될 때마다 대진하는 대상은 무조건 반으로 줄어들기 때문에 수식화가 가능함을 여기서 느낌
             * - 자신의 번호가 라운드 진행에 따라 두 가지로 변하는 것을 확인할 수 있음
             * -> 짝수일 경우 : 자신의 번호에 2를 나눔
             * -> 홀수일 경우 : 자신의 번호에 2를 나누고 1을 더함
             *
             * 처음 라운드에서 A번을 가진 참가자는 경쟁자로 생각하는 B번 참가자와 몇 번째 라운드에서 만나는지 궁금해졌습니다.
             * 게임 참가자 수 N, 참가자 번호 A, 경쟁자 번호 B가 함수 solution의 매개변수로 주어질 때,
             * 처음 라운드에서 A번을 가진 참가자는 경쟁자로 생각하는 B번 참가자와 몇 번째 라운드에서 만나는지 return 하는 solution 함수를 완성해 주세요.
             * 단, A번 참가자와 B번 참가자는 서로 붙게 되기 전까지 항상 이긴다고 가정합니다.
             */
            
            
            // answer = 3;
            return answer;
        }
    }
}