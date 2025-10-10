// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;
using Q = System.Collections.Generic.Queue<char>;

internal class Program
{
    static void Main()
    {
        int v = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        Q[] q = new Q[2];

        q[0] = new Q( n[0] );
        q[1] = new Q( n[0] );
        foreach( int _ in Range( 0, n[0] ) ) {
            string[] s = ReadLine().Split();

            q[0].Enqueue( s[0][0] );
            q[1].Enqueue( s[1][0] );
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            char[] p = { q[0].Dequeue(), q[1].Dequeue() };
            string[] s = ReadLine().Split();

            if( ( p[0] == 'R' && p[1] == 'S' ) || ( p[0] == 'S' && p[1] == 'P' ) || ( p[0] == 'P' && p[1] == 'R' ) ) {
                v++;
            } else if( ( p[0] == 'R' && p[1] == 'P' ) || ( p[0] == 'S' && p[1] == 'R' ) || ( p[0] == 'P' && p[1] == 'S' ) ) {
                v--;
            }
            foreach( int i in Range( 0, 2 ).Where( x => string.Compare( s[x], "push", System.StringComparison.Ordinal ) == 0 ) ) {
                q[i].Enqueue( p[i] );
            }
        }
        WriteLine( 0 < v ? "paiza" : v < 0 ? "kyoko" : "draw" );
        return;
    }
}
