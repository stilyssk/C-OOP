using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList randomList = new RandomList();
            randomList.Add("gosho");
            randomList.Add("kircho");
            randomList.Add("pesho");
            Console.WriteLine(randomList.RandomString());
        }
    }
}
