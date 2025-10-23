// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    const long mod = 1000000007L;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var d = new System.Collections.Generic.Dictionary<string, long>( n[0] );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            string[] s = ReadLine().Split();

            d[s[0]] = long.Parse( s[1] );
        }
        foreach( int i in Range( 0, n[1] ) ) {
            string[] s = ReadLine().Split();

            if( d.ContainsKey( s[0] ) == true ) {
                WriteLine( d[s[0]] == Hash( s[1] ) ? "Yes" : "No" );
            } else {
                WriteLine( "No" );
            }
        }
        Out.Flush();
        return;
    }

    static long Hash( string s )
    {
        long r = 0L;

        foreach( int i in Range( 0, s.Length ) ) {
            long t = s[i] * Pow( 100000007L, i + 1 ) % mod;

            r = ( r + t ) % mod;
        }
        return r;
    }

    static long Pow( long x, int y )
    {
        long b = x % mod;
        long r = 1L;

        while( 0 < y ) {
            if( ( y & 1 ) == 1 ) {
                r = r * b % mod;
            }
            b = b * b % mod;
            y >>= 1;
        }
        return r;
    }
}
