using static System.Console;

internal class Program
{
    static void Main()
    {
        long[] pqeM = System.Array.ConvertAll( ReadLine().Split(), long.Parse );
        long n = pqeM[0] * pqeM[1];
        long c = ( pqeM[0] - 1 ) * ( pqeM[1] - 1 );
        long x = 1;
        long y = 1;

        ExtGcd( pqeM[2], c, ref x, ref y );

        long d = ( c + x ) % c;
        ulong e = ModPow( pqeM[3], pqeM[2], n );
        ulong f = ModPow( (long)e, d, n );

        WriteLine( d );
        WriteLine( e );
        WriteLine( f );
        return;
    }

    static long ExtGcd( long a, long b, ref long x, ref long y )
    {
        long c = a;

        if( b != 0 ) {
            c = ExtGcd( b, a % b, ref y, ref x );
            y -= a / b * x;
        } else {
            x = 1;
            y = 0;
        }
        return c;
    }

    static ulong ModPow( long a, long b, long m )
    {
        ulong la = (ulong)a;
        ulong lb = (ulong)b;
        ulong lm = (ulong)m;
        ulong o = 1;

        while( 0 < lb ) {
            if( ( lb & 1 ) == 1 ) {
                o = o * la % lm;
            }
            la = la * la % lm;
            lb >>= 1;
        }
        return o;
    }
}
