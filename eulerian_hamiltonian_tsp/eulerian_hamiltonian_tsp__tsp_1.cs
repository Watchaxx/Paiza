// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;
        int[][] a = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }

        int[] v = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

        foreach( int i in Range( 0, n ) ) {
            o += a[v[i]][v[( i + 1 ) % n]];
        }
        WriteLine( o );
        return;
    }
}
