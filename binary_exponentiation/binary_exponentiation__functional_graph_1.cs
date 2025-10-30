// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
        int[] b = NextRow( n, a );

        WriteLine( string.Join( System.Environment.NewLine, b.Select( x => x + 1 ) ) );
        return;
    }

    static int[] NextRow( int n, int[] a )
    {
        int[] r = new int[n];

        foreach( int i in Range( 0, n ) ) {
            r[i] = a[a[i]];
        }
        return r;
    }
}
