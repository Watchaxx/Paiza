// 実行時間 310ms
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static int n = 0;
    static int m = 0;
    static int[][] g;
    static string[] s;

    static void Main()
    {
        int e = 1;
        int[] nmk = ReadLine().Split().Select( int.Parse ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        n = nmk[0];
        m = nmk[1];
        g = new int[n][];
        s = new string[n];
        foreach( int i in Range( 0, n ) ) {
            g[i] = new int[m];
            s[i] = ReadLine();
        }
        foreach( int i in Range( 0, n ) ) {
            foreach( int j in Range( 0, m ) ) {
                if( g[i][j] == 0 ) {
                    Bfs( e++, i, j );
                }
            }
        }
        foreach( int i in Range( 0, nmk[2] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            WriteLine( g[a[0]][a[1]] == g[a[2]][a[3]] ? "Yes" : "No" );
        }
        Out.Flush();
        return;
    }

    static void Bfs( int e, int x, int y )
    {
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        var q = new System.Collections.Generic.Queue<Tpl>();

        g[x][y] = e;
        q.Enqueue( new Tpl( x, y ) );
        while( 0 < q.Count ) {
            Tpl t = q.Dequeue();

            foreach( int i in Range( 0, 4 ) ) {
                int nx = t.Item1 + dx[i];
                int ny = t.Item2 + dy[i];

                if( nx < 0 || n <= nx || ny < 0 || m <= ny ) {
                    continue;
                }
                if( g[nx][ny] != 0 || s[nx][ny] != s[x][y] ) {
                    continue;
                }
                g[nx][ny] = e;
                q.Enqueue( new Tpl( nx, ny ) );
            }
        }
        return;
    }
}
