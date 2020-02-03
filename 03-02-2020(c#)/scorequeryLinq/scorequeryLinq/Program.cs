using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scorequeryLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new[] { 100, 200, 39, 10, 202, 75, 99,10,09 };
            scoreindes(scores);
            Scorein100(scores);
            scoreCount(scores);

            Console.ReadKey();
        }
        static void Scorein100(int[] scores)
        {
            IEnumerable<int> scoreque = from score in scores where score < 100 && score > 10 select score;
            Console.WriteLine("score greter than 10 and less than 100");

            foreach (int i in scoreque)
            {
                Console.WriteLine(i);
            }  
        }
        static void scoreCount(int[] scores)
        {
            Console.WriteLine("the n.o of scores greater than 10 ");
            IEnumerable<int> querycount = from score in scores where score > 10  select score;
            int count = querycount.Count();
            Console.WriteLine("score greater than 10 count is::"+count+"\n");
            Console.WriteLine("the score greater than 10 is");
            foreach(int i in querycount)
            {
                Console.WriteLine(i);
                System.Diagnostics.Debug.WriteLine(i);
            }

        }
        static void scoreindes(int[] scores)
        {
            IEnumerable<int> decendingscore = from score in scores orderby score descending select score;
            Console.WriteLine("the scores in decending order");
            foreach(int i in decendingscore)
            {
                Console.WriteLine(i);
            }

        }

    }
}
