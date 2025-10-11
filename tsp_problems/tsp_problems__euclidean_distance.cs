// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        double[] d1 = ReadLine().Split().Select( double.Parse ).ToArray();
        double[] d2 = ReadLine().Split().Select( double.Parse ).ToArray();
        WriteLine( Sqrt( Pow( d1[0] - d2[0], 2d ) + Pow( d1[1] - d2[1], 2d ) ) );
        return;
    }
}
