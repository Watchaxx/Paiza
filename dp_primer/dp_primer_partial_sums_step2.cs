// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const int b = 200;
        int[] nx = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] a = new int[nx[0]];
        int[] p = Repeat( b, nx[1] + 1 ).ToArray();

        foreach( int i in Range( 0, nx[0] ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        p[0] = 0;
        foreach( int i in Range( 0, nx[0] ) ) {
            for( int j = nx[1]; a[i] <= j; j-- ) {
                p[j] = System.Math.Min( p[j], p[j - a[i]] + 1 );
            }
        }
        WriteLine( p[nx[1]] != b ? p[nx[1]] : -1 );
        return;
    }
}
