using System.Text;

namespace DS_Algo
{
    // 3.	Reverse an array
    public class Question3
    {
        public void TestStringReverse()
        {
            var dataSet = new List<(string, string)>
            {
                ("abcd", "dcba"),
                ("TesT", "TseT")
            };
            dataSet.ForEach(x => {
                var reversed = StringReverse(x.Item1);
                if (x.Item2.Equals(reversed))
                {
                    Console.WriteLine("Passed");
                }
                else
                {
                    Console.WriteLine($"Failed => Reverse of {x.Item1} is {x.Item2} not {reversed}");
                }
            });
        }

        public string StringReverse(string str)
        {            
            var left = 0;
            var right = str.Length - 1;
            var builder = new StringBuilder(str);

            while(left < right)
            {
                builder[right] = str[left];
                builder[left] = str[right];
                ++left;
                --right;
            }

            return builder.ToString();
        }
    }
}