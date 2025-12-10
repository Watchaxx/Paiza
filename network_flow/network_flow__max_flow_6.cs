// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static bool[] visited;
    static int[][] capacity;

    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        capacity = new int[n[0]][];
        foreach( int i in Range( 0, n[0] ) ) {
            capacity[i] = new int[n[0]];
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            capacity[a[0]][a[1]] = 1;
            capacity[a[1]][a[0]] = 1;
        }
        while( true ) {
            visited = new bool[n[0]];

            int i = PushFlow( n[0], n[2] - 1, n[3] - 1, 100 );

            if( i == 0 ) {
                break;
            }
            o += i;
        }
        WriteLine( 1 < o ? "Yes" : "No" );
        return;
    }

    static int PushFlow( int n, int v, int t, int f )
    {
        if( v == t ) {
            return f;
        }
        visited[v] = true;
        foreach( int i in Range( 0, n ).Where( x => visited[x] == false && 0 < capacity[v][x] ) ) {
            int f2 = PushFlow( n, i, t, new[] { f, capacity[v][i] }.Min() );

            if( 0 < f2 ) {
                capacity[v][i] -= f2;
                capacity[i][v] += f2;
                return f2;
            }
        }
        return 0;
    }
}
