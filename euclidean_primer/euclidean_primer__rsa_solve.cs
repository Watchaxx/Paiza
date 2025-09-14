using System;
using static System.Console;

internal class Program
{
    static void Main()
    {
        long[] pqeE = Array.ConvertAll( ReadLine().Split(), long.Parse );
        long n = pqeE[0] * pqeE[1];
        long nd = ( pqeE[0] - 1 ) * ( pqeE[1] - 1 );
        long x = 1;
        long y = 1;

        ExtGcd( pqeE[2], nd, ref x, ref y );
        WriteLine( Convert.ToChar( ModPow( pqeE[3], ( nd + x ) % nd, n ) ) );
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
        ulong c = 1;

        while( 0 < lb ) {
            if( ( lb & 1 ) == 1 ) {
                c = c * la % lm;
            }
            la = la * la % lm;
            lb >>= 1;
        }
        return c;
    }
}
