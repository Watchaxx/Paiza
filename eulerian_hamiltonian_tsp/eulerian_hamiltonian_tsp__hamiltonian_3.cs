// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[][] g = new bool[n[0]][];

        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new bool[n[0]];
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]][a[1]] = true;
        }

        int[] v = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

        foreach( int _ in Range( 0, n[0] ).Where( x => g[v[x]][v[( x + 1 ) % n[0]]] != true ) ) {
            WriteLine( "No" );
            return;
        }
        WriteLine( "Yes" );
        return;
    }
}
