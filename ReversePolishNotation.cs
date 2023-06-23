namespace DS_Algo
{
    public class ReversePolishNotation
    {
        public int Evaulate(string[] tokens)
        {
            var stack = new Stack<int>();
            foreach (var token in tokens)
            {
                var num = 0;
                if (int.TryParse(token, out num))
                {
                    stack.Push(num);
                }
                else
                {
                    var num2 = stack.Pop();
                    var num1 = stack.Pop();
                    stack.Push(DoMath(num1, num2, token));
                }
            }
            return stack.Pop();
        }        
        private int DoMath(int num1, int num2, string token)
        {
            switch(token)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    return 0;
            }
        }

        public void Test()
        {
            var data = new List<(string[], int)>
            {
                new (new string[] {"1", "2", "+"}, 3),
                new (new string[] {"1", "2", "3", "+", "-"}, -4),
                new (new string[] {"4", "3", "1"}, 1),
                new (new string[] {"2", "3", "4", "+", "-", "7", "*"}, -35),
                new (new string[] {"5", "6", "4", "/", "-", "+", "1", "-"}, 5)
            };
            foreach (var item in data)
            {
                Console.WriteLine($"{Evaulate(item.Item1) == item.Item2}");
            }
        }

    }
}