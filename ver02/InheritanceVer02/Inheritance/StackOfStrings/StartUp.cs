using System;
namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfString = new StackOfStrings();
            Console.WriteLine(stackOfString.IsEmpty());
            stackOfString.Push("kircho");
            stackOfString.Push("pavel");
            stackOfString.Push("Emil");
            var result = stackOfString.AddRange();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stackOfString.IsEmpty());

        }
    }
}
