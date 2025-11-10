// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<char>;

internal class Program
{
    static void Main()
    {
        long[] n = ReadLine().Split().Select( long.Parse ).ToArray();
        string s = ReadLine();

        foreach( int i in Range( 0, 1 << ( (int)n[0] - 1 ) ) ) {
            Lst t = new Lst();

            foreach( int j in Range( 0, (int)n[0] ) ) {
                t.Add( s[j] );
                if( ( ( i >> j ) & 1 ) != 0 ) {
                    t.Add( '*' );
                }
            }

            long r = 1L;
            string u = string.Join( "", t );

            foreach( long j in u.Split( '*' ).Select( long.Parse ) ) {
                r *= j;
            }
            if( r == n[1] ) {
                WriteLine( u );
                break;
            }
        }
        return;
    }
}
