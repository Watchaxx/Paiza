// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        decimal e = 0m;
        decimal o = 0m;
        decimal[] c = new decimal[n];

        foreach( int i in Range( 0, n ) ) {
            c[i] = decimal.Parse( ReadLine() );
            e += c[i];
        }
        e /= n;
        foreach( decimal d in c ) {
            o += System.Math.Max( d, e );
        }
        WriteLine( o / n );
        return;
    }
}
