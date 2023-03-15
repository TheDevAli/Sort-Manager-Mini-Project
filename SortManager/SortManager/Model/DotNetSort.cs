using System.Diagnostics;

namespace Model;

public class DotNetSort : Sorter
{
    Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

    private long _timelapse;
    public override long Timelapse
    {
        get;
    }

    public override int[] Sort(int[] input)
    {
        stopWatch.Start();

        Array.Sort(input);

        stopWatch.Stop();

        _timelapse = stopWatch.ElapsedMilliseconds;

        return input;
    }
}