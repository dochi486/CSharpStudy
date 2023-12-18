namespace JumpAndTeleport
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(5);
        }
        
    }
    
    class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            
            //한 번에 K 칸을 앞으로 점프하거나,
            //(현재까지 온 거리) x 2 에 해당하는 위치로 순간이동을 할 수 있는
            //이 아이언 슈트는 건전지로 작동되는데,
            //순간이동을 하면 건전지 사용량이 줄지 않지만,
            //앞으로 K 칸을 점프하면 K 만큼의 건전지 사용량이 듭니다.
            //그러므로 아이언 슈트를 착용하고 이동할 때는 순간 이동을 하는 것이 더 효율적입니다.
            
            //아이언 슈트 구매자가 이동하려는 거리 N이 주어졌을 때, 사용해야 하는 건전지 사용량의 최솟값을 return하는 solution 함수를 만들어 주세요.

            do
            {
                if (n % 2 == 0)
                {
                    // x2 움직이니까 /2 해준다.
                    n /= 2;
                }
                else
                {
                    answer += 1;
                    n -= 1;
                }
                
            } while (n > 0);


            return answer;
        }
    }
}