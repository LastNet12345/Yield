using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = GetNumbers();
            IEnumerator<int> enumerator = numbers.GetEnumerator();

            while (enumerator.MoveNext())
            {
                int item = enumerator.Current;
                Console.WriteLine(item);
            }

            foreach (var item in GetNumbers())
            {
                Console.WriteLine(item);
            }

            foreach (var item in GetNumbersOrdinary().Take(10))
            {
                //if(item <= 10) 
                //{ 
                //    Console.WriteLine(item); 
                //}
                Console.WriteLine(item);
            } 
            
            foreach (var item in GetNumbersYield().Take(2))
            {
                
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<int> GetNumbersYield()
        {
            int i = 0;

            while (true)
            {
                yield return ++i;
            }
        }

        private static IEnumerable<int> GetNumbersOrdinary()
        {
            int i = 0;
            var res = new List<int>();

            while (i < 10000000)
            {
                res.Add(++i);
            }

            return res; 
        }

        private static IEnumerable<int> GetNumbers()
        {
            //return new List<int> { 1, 2, 3, 4, 5 };
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
        }
    }
}