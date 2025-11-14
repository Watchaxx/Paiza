// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        long[] a = ReadLine().Split().Select( long.Parse ).ToArray();
        long[] b = new long[n + 1];
        long o = long.MaxValue;
        long s = a.Sum();

        foreach( int i in Range( 0, n ) ) {
            b[i + 1] = a[i] + b[i];
        }
        foreach( int i in Range( 1, n ) ) {
            o = Min( o, Abs( s - b[i] - b[i] ) );
        }
        WriteLine( o );
        return;
    }
}
