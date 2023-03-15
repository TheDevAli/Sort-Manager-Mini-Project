using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SortManager.Model
{
    public class QuickSort : Sorter
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

        private int[] QuickSorter(int[] array, int leftBound,int rightBound)
        {
               if(leftBound<rightBound) 
            {
                int temp;
            int leftIndex = leftBound;
            int rightIndex = rightBound;
            (int value, int index) pivot = (array[rightIndex], rightIndex);
      
            for( int i = leftBound; i < rightBound; i++) // partiton array
            {
                if (array[i] < pivot.value)
                {
                    temp = array[leftIndex];
                    array[leftIndex] = array[i];
                    array[i] = temp;
                    leftIndex++;
                }

            }
            temp = array[rightIndex]; //put pivot back to its place
            array[rightIndex] = array[leftIndex];
            array[leftIndex] = temp;
         
                pivot.index = leftIndex; 
                QuickSorter(array, leftBound, pivot.index-1);
                QuickSorter(array,pivot.index+1, rightBound);

            }
            return array;

  
        }
        public override int[] Sort(int[] input)
        {
            int[] result = new int[input.Length];
            stopWatch.Restart();
            result=QuickSorter(input, 0, input.Length-1);
            stopWatch.Stop();
            return result;  
        }
    }
}
