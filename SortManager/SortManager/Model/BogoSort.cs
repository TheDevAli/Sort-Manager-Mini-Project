using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace SortManager.Model
{
    internal class BogoSort : Sorter
    {
        private Stopwatch stopWatch = Stopwatch.StartNew();


        public override long GetMilliseconds()
        {
            return stopWatch.ElapsedMilliseconds;
        }
        public override long GetTicks()
        {
            return stopWatch.ElapsedTicks;
        }


        public override int[] Sort(int[] input)
        {
            bool sorted = false;
            int temp;
            while(!sorted)
            {
                sorted = true;
                for(int i = 0; i < input.Length-1; i++)  //check if array is sorted
                    if (input[i] > input[i + 1])
                        sorted = false;
                if (sorted) break;
                for (int i = input.Length - 1; i > 0; i--) //shuffle the array
                {
                    Random random = new Random();
                    int randomIndex = random.Next(0, i + 1);
                     temp = input[i];
                    input[i] = input[randomIndex];
                    input[randomIndex] = temp;
                }
            }
            return input;
        }
    }
}
