// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nr = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] bt = Repeat( -1, 100100 ).ToArray();
        var lo = new System.Collections.Generic.SortedDictionary<int, int>() { [nr[1]] = 0 };

        bt[0] = nr[1];
        foreach( int _ in Range( 0, nr[0] - 1 ) ) {
            string[] s = ReadLine().Split();
            int a = int.Parse( s[0] );
            int b = int.Parse( s[1] );

            if( s[2][0] == 'L' ) {
                if( a <= b ) {
                    WriteLine( "NO" );
                    return;
                }
                lo[b] = 2 * lo[a] + 1;
            } else if( s[2][0] == 'R' ) {
                if( b <= a ) {
                    WriteLine( "NO" );
                    return;
                }
                lo[b] = 2 * lo[a] + 2;
            }
            if( bt[lo[b]] != -1 ) {
                WriteLine( "NO" );
                return;
            } else {
                bt[lo[b]] = b;
            }
        }
        WriteLine( "YES" );
        return;
    }
}
