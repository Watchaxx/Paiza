// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        decimal e = 0m;
        decimal[] c = new decimal[n[0]];

        foreach( int i in Range( 0, n[0] ) ) {
            c[i] = decimal.Parse( ReadLine() );
            e += c[i];
        }
        e /= n[0];
        foreach( int _ in Range( 0, n[1] - 1 ) ) {
            decimal t = 0m;

            foreach( decimal d in c ) {
                t += System.Math.Max( d, e );
            }
            e = t / n[0];
        }
        WriteLine( e );
        return;
    }
}
