// 実行時間 150ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        string[] s = ReadLine().Split();
        int n = int.Parse( s[0] );
        int o = -1;
        long x = long.Parse( s[1] );
        long[] a = ReadLine().Split().Select( long.Parse ).OrderByDescending( d => d ).ToArray();
        long[] b = new long[n + 1];

        foreach( int i in Range( 0, n ) ) {
            b[i + 1] = b[i] + a[i];
            if( x <= b[i + 1] ) {
                o = i + 1;
                break;
            }
        }
        WriteLine( o );
        return;
    }
}
