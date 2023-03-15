namespace SortManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ary = ArrayBuilder.GenArray(10);
            
            foreach(var item in ary)
            {
                Console.WriteLine(item) ;
            }

        }
    }
}