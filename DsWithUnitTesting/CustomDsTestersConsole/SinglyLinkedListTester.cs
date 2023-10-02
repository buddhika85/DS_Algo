using DSQuestions.SinglyLinkedList;

using static System.Console;

namespace CustomDsTestersConsole
{
    public class SinglyLinkedListTester
    {
        public void Test()
        {
            try
            {
                SinglyLinkedList<string> sll = new();

                WriteLine(sll);
                //var first = sll.Get(0);                               // this should throw - ArgumentOutOfRangeException --> passes

                sll.AddAtHead("First");
                WriteLine($"{Environment.NewLine}{sll}");               //Head -> First <- Tail             --> passes

                //sll.Get(-1);                                          // ArgumentOutOfRangeException --> passes

                WriteLine($"{Environment.NewLine}{sll.Get(0)}");        // First --> passes

                //WriteLine($"{Environment.NewLine}{sll.Get(1)}");        // InvalidOperationException --> passes

                sll.AddAtHead("New first");
                WriteLine($"{Environment.NewLine}{sll}");               //Head -> New first --> First <- Tail             --> passes

                sll.AddAtTail("Last");
                WriteLine($"{Environment.NewLine}{sll}");               //Head -> New first --> First --> Last  <- Tail   --> passes

                //sll.AddAtIndex(-1, "invalid");                        // ArgumentOutOfRangeException


                sll.AddAtIndex(2, "Middle");
                WriteLine($"{Environment.NewLine}{sll}");               //Head -> New first --> First --> Middle --> Last  <- Tail   --> passes

                sll.AddAtIndex(0, "One");
                WriteLine($"{Environment.NewLine}{sll}");               //Head -> One --> New first --> First --> Middle --> Last  <- Tail   --> passes

                sll.AddAtIndex(5, "Five");
                WriteLine($"{Environment.NewLine}{sll}");               //Head -> One --> New first --> First --> Middle --> Last --> Five <- Tail   --> passes

                //sll.AddAtIndex(7, "Invalid");                         // ArgumentOutOfRangeException   --> passes

                //sll.DeleteIndex(-1);                                    // ArgumentOutOfRangeException   --> passes

                //sll.DeleteIndex(7);                                   // ArgumentOutOfRangeException   --> passes

                sll.DeleteIndex(0);
                WriteLine($"{Environment.NewLine}{sll}");               //Head -> New first --> First --> Middle --> Last --> Five <- Tail   --> passes

                sll.DeleteIndex(0);
                WriteLine($"{Environment.NewLine}{sll}");               //Head --> First --> Middle --> Last --> Five <- Tail   --> passes

                sll.AddAtIndex(2, "Middle 2");
                WriteLine($"{Environment.NewLine}{sll}");               //Head -> First --> Middle --> Middle 2 --> Last  <- Tail   --> passes

                sll.DeleteIndex(2);
                WriteLine($"{Environment.NewLine}{sll}");               //Head --> First --> Middle --> Last --> Five <- Tail   --> passes

                sll.DeleteIndex(3);
                WriteLine($"{Environment.NewLine}{sll}");               //Head --> First --> Middle --> Last <- Tail   --> passes
            }
            catch (Exception e)
            {
                WriteLine($"Exception: {e?.Message}");
            }
        }
    }
}
