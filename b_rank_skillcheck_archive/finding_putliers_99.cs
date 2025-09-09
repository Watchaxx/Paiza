// 実行時間 320ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        decimal[] x = new decimal[n];
        decimal[] y = new decimal[n];
        Lst l = new Lst( Repeat( 0, n ) );

        if( n == 2 ) {
            WriteLine( "none" );
            return;
        }
        foreach( int i in Range( 0, n ) ) {
            decimal[] p = ReadLine().Split().Select( decimal.Parse ).ToArray();

            x[i] = p[0];
            y[i] = p[1];
        }
        foreach( int i in Range( 0, n - 1 ) ) {
            foreach( int j in Range( i + 1, n - 1 - i ) ) {
                decimal a = y[j] - y[i];
                decimal b = -( x[j] - x[i] );
                decimal c = b * -y[i] - a * x[i];
                Lst t = new Lst( n - 2 );

                foreach( int k in Range( 0, n ) ) {
                    if( 2m <= Abs( a * x[k] + b * y[k] + c ) / (decimal)Sqrt( (double)( a * a + b * b ) ) ) {
                        t.Add( k + 1 );
                    }
                }
                if( t.Count == 0 ) {
                    WriteLine( "none" );
                    return;
                }
                if( t.Count < l.Count ) {
                    l = new Lst( t );
                }
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, l ) );
        return;
    }
}
