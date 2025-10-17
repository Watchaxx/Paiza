// 実行時間 410ms
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static int n = 0;
    static int m = 0;

    static void Main()
    {
        int o = int.MaxValue;
        int[] nm = ReadLine().Split().Select( int.Parse ).ToArray();
        n = nm[0];
        m = nm[1];
        string[] s = new string[n];

        foreach( int i in Range( 0, n ) ) {
            s[i] = ReadLine();
        }
        foreach( char c in "RGB" ) {
            int cnt = 0;
            int[][] t = new int[n][];

            foreach( int i in Range( 0, n ) ) {
                t[i] = Repeat( -1, m ).ToArray();
            }
            foreach( int i in Range( 0, n ) ) {
                foreach( int j in Range( 0, m ) ) {
                    if( s[i][j] != c ) {
                        t[i][j] = 0;
                    }
                }
            }
            foreach( int i in Range( 0, n ) ) {
                foreach( int j in Range( 0, m ) ) {
                    if( t[i][j] != 1 ) {
                        cnt++;
                        Bfs( t[i][j], i, j, t );
                    }
                }
            }
            o = System.Math.Min( o, cnt );
        }
        WriteLine( o );
        return;
    }

    static void Bfs( int c, int x, int y, int[][] s )
    {
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        var q = new System.Collections.Generic.Queue<Tpl>();

        s[x][y] = 1;
        q.Enqueue( new Tpl( x, y ) );
        while( 0 < q.Count ) {
            Tpl t = q.Dequeue();

            foreach( int i in Range( 0, 4 ) ) {
                int nx = t.Item1 + dx[i];
                int ny = t.Item2 + dy[i];

                if( nx < 0 || n <= nx || ny < 0 || m <= ny ) {
                    continue;
                }
                if( s[nx][ny] != c ) {
                    continue;
                }
                s[nx][ny] = 1;
                q.Enqueue( new Tpl( nx, ny ) );
            }
        }
        return;
    }
}
