// 実行時間 160ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int k = 0;
        char[] d = new char[1 << 16];

        foreach( int i in Range( 0, 1 << 16 ) ) {
            d[i] = Judge( i );
        }
        foreach( int i in Range( 0, 1 << 16 ).Reverse().Where( x => d[x] == '0' ) ) {
            int c = 0;
            var s = new System.Collections.Generic.HashSet<char>();

            foreach( int j in Range( 0, 16 ).Where( x => Is0( i, x ) == true ) ) {
                c++;
                s.Add( d[( 1 << j ) + i] );
            }
            d[i] = ( 16 - c ) % 2 == 0 ? s.Contains( 'A' ) ? 'A' : 'B' : s.Contains( 'B' ) ? 'B' : 'A';
        }
        foreach( int i in Range( 0, 4 ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            foreach( int j in Range( 0, 4 ) ) {
                k += t[j] * 1 << ( 15 - 4 * i - j );
            }
        }
        WriteLine( d[k] );
        return;
    }

    static bool Is0( int a, int b )
    {
        return ( a & ( 1 << b ) ) == 0;
    }

    static char Judge( int s )
    {
        bool b = false;
        int c = 0;

        foreach( int i in Range( 0, 16 ).Where( x => Is0( s, 15 - x ) != true ) ) {
            c++;
            foreach( int j in Range( i + 1, 16 - i - 1 ) ) {
                if( Is0( s, 15 - j ) == true ) {
                    continue;
                }
                if( ( i / 4 == j / 4 ) || ( j % 4 <= i % 4 ) ) {
                    continue;
                }
                if( Is0( s, 15 - i / 4 * 4 - j % 4 ) == true ) {
                    continue;
                }
                if( Is0( s, 15 - j / 4 * 4 - i % 4 ) == true ) {
                    continue;
                }
                b = true;
            }
        }
        return b ? c % 2 == 0 ? 'A' : 'B' : '0';
    }
}
