// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nkr = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] bt = new int[2 * nkr[0]];
        var lo = new System.Collections.Generic.SortedDictionary<int, int>();

        bt[0] = nkr[2];
        lo[nkr[2]] = 0;
        foreach( int _ in Range( 0, nkr[0] - 1 ) ) {
            string[] a = ReadLine().Split();
            int b = int.Parse( a[1] );

            if( a[2][0] == 'L' ) {
                lo[b] = 2 * lo[int.Parse( a[0] )] + 1;
            } else if( a[2][0] == 'R' ) {
                lo[b] = 2 * lo[int.Parse( a[0] )] + 2;
            }
            bt[lo[b]] = b;
        }
        foreach( int _ in Range( 0, nkr[1] ) ) {
            string[] v = ReadLine().Split();

            if( v[1][0] == 'L' ) {
                WriteLine( bt[2 * lo[int.Parse( v[0] )] + 1] );
            } else if( v[1][0] == 'R' ) {
                WriteLine( bt[2 * lo[int.Parse( v[0] )] + 2] );
            }
        }
        return;
    }
}
