// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;
        decimal[] x = new decimal[n];
        decimal[] y = new decimal[n];

        foreach( int i in Range( 0, n ) ) {
            decimal[] p = ReadLine().Split().Select( decimal.Parse ).ToArray();

            x[i] = p[0];
            y[i] = p[1];
        }

        decimal a = y[1] - y[0];
        decimal b = ( x[1] - x[0] ) * -1;
        decimal c = ( x[1] - x[0] ) * y[0] - a * x[0];

        foreach( int i in Range( 2, n - 2 ) ) {
            if( 2m <= Abs( a * x[i] + b * y[i] + c ) / (decimal)Sqrt( (double)( a * a + b * b ) ) ) {
                o++;
            }
        }
        WriteLine( o );
        return;
    }
}
