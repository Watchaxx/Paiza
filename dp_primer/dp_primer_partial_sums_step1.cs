// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nx = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] a = new int[nx[0]];
        int[] p = new int[nx[1] + 1];

        foreach( int i in Range( 0, nx[0] ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        p[0] = 1;
        foreach( int i in Range( 0, nx[0] ) ) {
            for( int j = nx[1]; a[i] <= j; j-- ) {
                p[j] += p[j - a[i]];
                p[j] %= 1000000007;
            }
        }
        WriteLine( p[nx[1]] );
        return;
    }
}
