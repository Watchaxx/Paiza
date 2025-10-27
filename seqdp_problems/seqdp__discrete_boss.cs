// 実行時間 340ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).Prepend( 0 ).ToArray();
        bool[] dl = new bool[n + 2];
        bool[] dr = new bool[n + 2];

        dl[0] = true;
        dr[n + 1] = true;
        foreach( int i in Range( 0, n ).Where( x => dl[x] && ( x + a[x + 1] <= n ) ) ) {
            dl[i + a[i + 1]] = dl[i];
        }
        foreach( int i in Range( 2, n ).Reverse().Where( x => dr[x] && ( 1 <= x - a[x - 1] ) ) ) {
            dr[i - a[i - 1]] = dr[i];
        }
        WriteLine( Range( 0, n + 1 ).Where( x => dl[x] && dr[x + 1] ).Count() );
        return;
    }
}
