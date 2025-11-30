// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static int o = 0;
    static int[] n;
    static int[][] a;

    static void Main()
    {
        n = ReadLine().Split().Select( int.Parse ).ToArray();
        a = new int[n[0] + 1][];
        foreach( int i in Range( 1, n[0] ) ) {
            ReadLine();
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        Dfs( n[2], new Lst { n[1], n[2] } );
        WriteLine( o );
        return;
    }

    static void Dfs( int v, Lst t )
    {
        foreach( int i in a[v] ) {
            if( i == n[1] && 2 < t.Count ) {
                t.Add( i );
                o++;
                t.RemoveAt( t.Count - 1 );
            } else if( t.Contains( i ) != true ) {
                t.Add( i );
                Dfs( i, t );
                t.RemoveAt( t.Count - 1 );
            }
        }
        return;
    }
}
