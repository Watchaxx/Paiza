// 実行時間 160ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int cnt = 0;
        int crt = 0;
        int[][] a = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        System.Array.Sort( a, ( x, y ) => Compare( x, y ) );
        foreach( int i in Range( 0, n ).Where( x => crt < a[x][0] ) ) {
            cnt++;
            crt = a[i][1];
        }
        WriteLine( cnt );
        return;
    }

    static int Compare( int[] x, int[] y )
    {
        return y[1] < x[1] ? 1 : x[1] < y[1] ? -1 : y[0] < x[0] ? 1 : x[0] < y[0] ? -1 : 0;
    }
}
