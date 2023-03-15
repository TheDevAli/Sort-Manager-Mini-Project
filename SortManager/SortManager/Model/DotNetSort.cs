using System.Diagnostics;

namespace Model;

public class DotNetSort : Sorter
{
<<<<<<< HEAD
    private Stopwatch stopWatch = Stopwatch.StartNew();

    public override long GetMilliseconds()
    {
        return stopWatch.ElapsedMilliseconds;
    }
    public override long GetTicks()
    {
        return stopWatch.ElapsedTicks;
=======
    Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

    private long _timelapse;//
    public override long Timelapse
    {
        get;
>>>>>>> fca3da2368a515584d4b5acf3124aa846f53afb8
    }

    public override int[] Sort(int[] input)
    {
        stopWatch.Start();

        Array.Sort(input);

        stopWatch.Stop();

<<<<<<< HEAD
=======
        _timelapse = stopWatch.ElapsedMilliseconds;

>>>>>>> fca3da2368a515584d4b5acf3124aa846f53afb8
        return input;
    }
}