//namespace ToyProblem
//{
//    public class NthSeries
//    {
//        public static string seriesSum(int n)
//        {
//            // Happy Coding ^_^
//            #region
//            //            Task:
//            //            Your task is to write a function which returns the sum of following series upto nth term(parameter).

//            //Series: 1 + 1 / 4 + 1 / 7 + 1 / 10 + 1 / 13 + 1 / 16 +...
//            //Rules:
//            //You need to round the answer to 2 decimal places and return it as String.

//            //If the given value is 0 then it should return 0.00

//            //You will only be given Natural Numbers as arguments.

//            //Examples:
//            //SeriesSum(1) => 1 = "1.00"
//            //SeriesSum(2) => 1 + 1 / 4 = "1.25"
//            //SeriesSum(5) => 1 + 1 / 4 + 1 / 7 + 1 / 10 + 1 / 13 = "1.57"
//            #endregion

//            double x = 0;
//            if (n == 0)
//            {
//                return "0.00";
//            }
//            var array = new int[n];
//            for (int i = 0; i < n; i++)
//            {
//                x += i / 2 + 0.5;
//            }
//            return "";
//        }
//    }
//}
