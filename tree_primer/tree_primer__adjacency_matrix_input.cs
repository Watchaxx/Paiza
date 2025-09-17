// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        byte[][] g = new byte[n][];

        foreach( int i in Range( 0, n ) ) {
            g[i] = new byte[n];
        }
        foreach( int _ in Range( 0, n - 1 ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]][a[1]] = 1;
            g[a[1]][a[0]] = 1;
        }
        foreach( int i in Range( 0, n ) ) {
            WriteLine( string.Join( " ", g[i] ) );
        }
        return;
    }
}
