// 実行時間 100ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        long[] a = ReadLine().Split().Select( long.Parse ).ToArray();
        long l = a[0];
        long r = a.Sum() - a[0];
        long o = Abs( l - r );

        foreach( int i in Range( 1, n - 1 ) ) {
            l += a[i];
            r -= a[i];
            o = Min( o, Abs( l - r ) );
        }
        WriteLine( o );
        return;
    }
}
