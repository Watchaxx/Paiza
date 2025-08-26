using static System.Console;
using static System.Math;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int sq = (int)Sqrt( n[0] );
        int[] s = new int[n[0]];
        int[] mn = new int[sq];
        int[] mx = new int[sq];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            s[i] = int.Parse( ReadLine() );
        }
        foreach( int i in Range( 0, sq ) ) {
            foreach( int j in Range( 0, sq ) ) {
                mn[i] = j == 0 ? s[sq * i] : Min( mn[i], s[sq * i + j] );
                mx[i] = j == 0 ? s[sq * i] : Max( mx[i], s[sq * i + j] );
            }
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] lr = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
            int i = lr[0];
            int amax = s[lr[0]];
            int amin = s[lr[0]];

            while( i <= lr[1] ) {
                if( i % sq == 0 && i + sq - 1 <= lr[1] ) {
                    amax = Max( amax, mx[i / sq] );
                    amin = Min( amin, mn[i / sq] );
                    i += sq;
                } else {
                    amax = Max( amax, s[i] );
                    amin = Min( amin, s[i] );
                    i++;
                }
            }
            i = lr[2];

            int bmax = s[lr[2]];
            int bmin = s[lr[2]];

            while( i <= lr[3] ) {
                if( i % sq == 0 && i + sq - 1 <= lr[3] ) {
                    bmax = Max( bmax, mx[i / sq] );
                    bmin = Min( bmin, mn[i / sq] );
                    i += sq;
                } else {
                    bmax = Max( bmax, s[i] );
                    bmin = Min( bmin, s[i] );
                    i++;
                }
            }
            WriteLine( bmax - bmin < amax - amin ? "A" : amax - amin < bmax - bmin ? "B" : "DRAW" );
        }
        Out.Flush();
        return;
    }
}
