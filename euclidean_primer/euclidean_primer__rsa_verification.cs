// 実行時間 20ms
using System;
using static System.Console;

internal class Program
{
    static void Main()
    {
        long[] neE = { 3995747143, 3007, 602607029 };
        long[] pr = CalcN( neE[0] );
        long nd = ( pr[0] - 1 ) * ( pr[1] - 1 );
        long x = 1;
        long y = 1;

        WriteLine( string.Join( " ", neE ) );
        ExtGcd( neE[1], nd, ref x, ref y );

        string b2 = Convert.ToString( ModPow( neE[2], ( nd + x ) % nd, neE[0] ), 2 );

        while( b2.Length % 7 != 0 ) {
            b2 = "0" + b2;
        }
        for( int i = 0; i < b2.Length; i += 7 ) {
            int b10 = Convert.ToInt32( b2.Substring( i, 7 ), 2 );

            if( b10 != 0 ) {
                Write( Convert.ToChar( b10 ) );
            }
        }
        WriteLine();
        return;
    }

    static long[] CalcN( long n )
    {
        var l = new System.Collections.Generic.List<long>();

        for( long i = 2; i * i <= n; i++ ) {
            while( n % i == 0 ) {
                l.Add( i );
                n /= i;
            }
        }
        if( n != 1 ) {
            l.Add( n );
        }
        return l.ToArray();
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

    static long ModPow( long a, long b, long m )
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
        return (long)c;
    }
}
