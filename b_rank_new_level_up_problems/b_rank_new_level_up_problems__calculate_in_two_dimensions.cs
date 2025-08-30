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
        int t = 0;
        int[][] a = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            int[] r = ReadLine().Split().Select( int.Parse ).ToArray();

            a[i] = new int[n];
            foreach( int j in Range( 0, n ) ) {
                a[i][j] = r[j];
            }
            o = Max( o, r.Sum() );
        }
        foreach( int i in Range( 0, n ) ) {
            t = 0;

            foreach( int j in Range( 0, n ) ) {
                t += a[j][i];
            }
            o = Max( o, t );
        }
        t = 0;
        foreach( int i in Range( 0, n ) ) {
            t += a[i][i];
        }
        o = Max( o, t );
        t = 0;
        foreach( int i in Range( 0, n ) ) {
            t += a[n - 1 - i][i];
        }
        WriteLine( Max( o, t ) );
        return;
    }
}
