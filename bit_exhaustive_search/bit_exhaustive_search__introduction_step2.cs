// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] s = ReadLine().Split().Select( int.Parse ).ToArray();

        for( int i = 0; i < ( 1 << n[0] ); i++ ) {
            int u = 0;
            Lst b = new Lst();
            Lst t = new Lst();

            foreach( int j in Range( 0, n[0] ) ) {
                if( ( ( i >> j ) & 1 ) == 1 ) {
                    t.Add( s[j] );
                    u += s[j];
                }
                b.Add( ( i >> j ) & 1 );
            }
            if( n[1] <= u ) {
                b.Reverse();
                WriteLine( $"{string.Join( "", b )} {{{string.Join( " ", t )}}}" );
            }
        }
        return;
    }
}
