using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortManager.Model;

namespace SortManager
{
    public class Controller
    {
        public static void start()
        {
            int arraySize = View.AskArraySize();

            int[] ary = ArrayBuilder.GenArray(arraySize);

            View.PrintArray(ary);

            string choice = View.AskSortAlgor();


        }
    }
}
