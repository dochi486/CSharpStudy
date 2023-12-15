namespace Fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(3);
        }
    }
    public class Solution 
    {
        public int solution(int n) 
        {
            int answer = 0;

            // n번째 항은 n-1번째 항의 값과 n-2번째 항의 값을 더한 것
            // 2 이상의 n이 입력되었을 때, n번째 피보나치 수를 1234567으로 나눈 나머지를 리턴하는 함수, solution을 완성해 주세요.
            
            int first = 0;
            int second = 1;

            for (int i = 2; i <= n; i++)
            {
                answer = (first + second) % 1234567;
                first = second % 1234567;
                second = answer;
            }
            return answer;
        }
    }
}