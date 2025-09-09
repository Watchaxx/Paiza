// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        decimal[] x = new decimal[n];
        decimal[] y = new decimal[n];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        for( int i = 0; i < n; i++ ) {
            decimal[] d = ReadLine().Split().Select( decimal.Parse ).ToArray();

            x[i] = d[0];
            y[i] = d[1];
        }
        foreach( int i in Range( 0, n - 1 ) ) {
            foreach( int j in Range( i + 1, n - 1 - i ) ) {
                WriteLine( $"{y[j] - y[i]} {( x[j] - x[i] ) * -1} {( x[j] - x[i] ) * y[i] - ( y[j] - y[i] ) * x[i]}" );
            }
        }
        Out.Flush();
        return;
    }
}
