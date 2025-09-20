// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nr = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] bt = Repeat( -1, 100100 ).ToArray();
        var lo = new System.Collections.Generic.SortedDictionary<int, int> { [nr[1]] = 0 };

        bt[0] = nr[1];
        foreach( int _ in Range( 0, nr[0] - 1 ) ) {
            string[] s = ReadLine().Split();
            int b = int.Parse( s[1] );

            if( s[2][0] == 'L' ) {
                lo[b] = 2 * lo[int.Parse( s[0] )] + 1;
            } else if( s[2][0] == 'R' ) {
                lo[b] = 2 * lo[int.Parse( s[0] )] + 2;
            }
            bt[lo[b]] = b;
        }

        int c = 0;
        int v = int.Parse( ReadLine() );

        while( bt[c] != -1 ) {
            c = v < bt[c] ? 2 * c + 1 : 2 * c + 2;
        }
        WriteLine( bt[( c - 1 ) / 2] );
        WriteLine( c % 2 != 0 ? 'L' : 'R' );
        return;
    }
}
