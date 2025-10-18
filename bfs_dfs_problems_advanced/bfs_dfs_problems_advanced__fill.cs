// 実行時間 100ms
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    enum Color
    {
        White,
        Black,
        Blue
    }

    static void Main()
    {
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        int[] nmxy = ReadLine().Split().Select( int.Parse ).ToArray();
        var q = new System.Collections.Generic.Queue<Tpl>();
        var g = new Color[nmxy[0]][];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, nmxy[0] ) ) {
            string s = ReadLine();

            g[i] = new Color[nmxy[1]];
            foreach( int j in Range( 0, nmxy[1] ) ) {
                if( s[j] == '.' ) {
                    g[i][j] = Color.White;
                } else if( s[j] == '#' ) {
                    g[i][j] = Color.Black;
                }
            }
        }
        g[nmxy[2] - 1][nmxy[3] - 1] = Color.Blue;
        q.Enqueue( new Tpl( nmxy[2] - 1, nmxy[3] - 1 ) );
        while( 0 < q.Count ) {
            Tpl t = q.Dequeue();

            foreach( int i in Range( 0, 4 ) ) {
                int x = t.Item1 + dx[i];
                int y = t.Item2 + dy[i];

                if( x < 0 || nmxy[0] <= x || y < 0 || nmxy[1] <= y ) {
                    continue;
                }
                if( g[x][y] == Color.White ) {
                    g[x][y] = Color.Blue;
                    q.Enqueue( new Tpl( x, y ) );
                }
            }
        }
        foreach( int i in Range( 0, nmxy[0] ) ) {
            foreach( int j in Range( 0, nmxy[1] ) ) {
                switch( g[i][j] ) {
                case Color.White:
                    Write( '.' );
                    break;
                case Color.Black:
                    Write( '#' );
                    break;
                case Color.Blue:
                    Write( '+' );
                    break;
                }
            }
            WriteLine();
        }
        Out.Flush();
        return;
    }
}
