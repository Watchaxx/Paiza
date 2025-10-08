// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = new int[n - 2];
        int x = -200;

        foreach( int i in Range( 0, n - 2 ) ) {
            b[i] = a[i] + a[i + 1] + a[i + 2];
            x = System.Math.Max( x, b[i] );
        }
        WriteLine( System.Array.IndexOf( b, x ) + 1 );
        return;
    }
}
