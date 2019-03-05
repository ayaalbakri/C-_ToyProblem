using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;

namespace ToyProblem
{
    public class Program
    {
        private static List<object> ssdd;
        private static long numb = 456;
        private static List<int[]> numbersOfPeopeleInBus;

        //private static List<object> ssdd;

        public static void Main(string[] args)
        {
            Persist.Persistence(999);
            string[] walk = { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" };
            bool bo = Walk.IsValidWalk(walk);
            Console.WriteLine(bo);
            bool bo2 = Walk.IsValidWalk2(walk);
            Console.WriteLine(bo2);
            ssdd = new List<object>() { 1, 2, "a", "b", 0, 15 };

            Console.WriteLine(ssdd);
            var xxxxx = ListOfInteger.ListOfIntegers(ssdd);
            int[] num = { 1, 100, 50, -51, 1, 1 };
            FindEvenIndex.FindEvenIndexMethod(num);

            Divisors.Divisor(24);
            numbersOfPeopeleInBus = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
            PeopleInBus.Number(numbersOfPeopeleInBus);

            Brace.validBraces("[({})](]");

            DeleteNth.DeleteNthFromArray(new[] { 1, 2, 1, 3, 1, 2, 1, 1, 2, 1, 2, 1, 3 }, 3);
            //Number.
            Number.DigitalRoot(numb);
            //phone
            Phone.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });

            Vowel.GetVowelCount("cvxnb");

            DontGiveMeFive.DontGiveMeFiveMethod(4, 17);

            Narcissistic.NarcissisticNumber(153);

            SortArray.SortArrayOddAscending(new int[] { 1, 7, 4, 3, 5 });


            HighAndLow.HighAndLowNumber("12345");

            DuplicateEncode.DuplicateEncodeChar("Success");

            ReverseWords.ReverseWordsMethod("hi new");

            OddOccurance.FirstOddOccurance(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });

            High.HighestWord("Hi Aya");

            DescendingOrder.DescendingOrderNumber(21445);

            //NthSeries.seriesSum(5);

            Supermarket_Queue.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 1);

            SumOfNumbers.Sum(-1, 0);

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
