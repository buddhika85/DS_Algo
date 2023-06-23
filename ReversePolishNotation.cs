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
    }
}