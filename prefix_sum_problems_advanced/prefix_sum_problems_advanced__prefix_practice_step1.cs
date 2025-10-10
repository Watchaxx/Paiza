// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int d = 0;
        int m = int.MinValue;
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = new int[n + 1];

        foreach( int i in Range( 0, n ) ) {
            b[i + 1] = b[i] + a[i];
        }
        foreach( int i in Range( 1, n ) ) {
            d += b[i];
            m = System.Math.Max( m, d );
        }
        WriteLine( m );
        return;
    }
}
