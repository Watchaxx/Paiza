// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    const long b = 100000007L;
    const long mod = 1000000007L;

    static void Main()
    {
        int[] l = ReadLine().Split().Select( int.Parse ).ToArray();
        string s = ReadLine();
        long[] h = new long[l[0] + 1];
        long[] p = new long[l[0] + 1];

        foreach( int i in Range( 0, l[0] ) ) {
            h[i + 1] = ( h[i] * b + s[i] ) % mod;
        }
        p[0] = 1L;
        foreach( int i in Range( 1, l[0] - 1 ) ) {
            p[i] = p[i - 1] * b % mod;
        }
        foreach( int _ in Range( 0, l[1] ) ) {
            string t = ReadLine();
            long v = Hash( t );

            foreach( int i in Range( 0, l[0] - t.Length + 1 ) ) {
                if( ( h[t.Length + i] - h[i] * p[t.Length] % mod + mod ) % mod == v ) {
                    WriteLine( "Yes" );
                    goto Nx;
                }
            }
            WriteLine( "No" );
        Nx:
            ;
        }
        return;
    }

    static long Hash( string s )
    {
        long r = 0L;

        foreach( int i in Range( 0, s.Length ) ) {
            r = ( r * b + s[i] ) % mod;
        }
        return r;
    }
}
