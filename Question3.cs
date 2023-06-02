using System.Text;

namespace DS_Algo
{
    // 3.	Reverse an array
    public class Question3
    {
        public void TestStringArrayReverse()
        {
            var dataSet = new List<(string[], string[])>
            {
                (new string[] {"a", "b", "c", "d"}, new string[] {"d", "c", "b", "a"}),
                (new string[] {"T", "e", "s", "T"}, new string[] {"T", "s", "e", "T"}),
            };
            dataSet.ForEach(x => {
                var reversed = StringReverse(x.Item1);
                if (x.Item2.SequenceEqual(reversed))
                {
                    Console.WriteLine($"Passed => {reversed.Display()}");
                }
                else
                {
                    Console.WriteLine($"Failed => Reverse of {x.Item1.Display()} is {x.Item2.Display()} not {reversed.Display()}");
                }
            });
        }

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

        public string[] StringReverse(string[] array)
        {
            var left = 0;
            var right = array.Length - 1;
            while(left < right)
            {
                var temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                ++left;
                --right;
            }
            return array;
        }
    }
}