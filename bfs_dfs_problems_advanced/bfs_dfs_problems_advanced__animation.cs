// 実行時間 70ms
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static void Main()
    {
        int[] nmxyk = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        int[][] d = new int[nmxyk[0]][];
        string[] s = new string[nmxyk[0]];
        var q = new System.Collections.Generic.Queue<Tpl>();

        foreach( int i in Range( 0, nmxyk[0] ) ) {
            d[i] = Repeat( -1, nmxyk[1] ).ToArray();
            s[i] = ReadLine();
        }
        d[nmxyk[2] - 1][nmxyk[3] - 1] = 0;
        q.Enqueue( new Tpl( nmxyk[2] - 1, nmxyk[3] - 1 ) );
        while( 0 < q.Count ) {
            Tpl t = q.Dequeue();

            foreach( int i in Range( 0, 4 ) ) {
                int x = t.Item1 + dx[i];
                int y = t.Item2 + dy[i];

                if( x < 0 || nmxyk[0] <= x || y < 0 || nmxyk[1] <= y ) {
                    continue;
                }
                if( d[x][y] != -1 || s[x][y] == '#' ) {
                    continue;
                }
                d[x][y] = d[t.Item1][t.Item2] + 1;
                q.Enqueue( new Tpl( x, y ) );
            }
        }
        foreach( int i in Range( 0, nmxyk[4] ) ) {
            foreach( int j in Range( 0, nmxyk[0] ) ) {
                char[] c = s[j].ToCharArray();

                foreach( int k in Range( 0, nmxyk[1] ).Where( x => d[j][x] == i ) ) {
                    c[k] = '+';
                }
                s[j] = string.Join( "", c );
                WriteLine( s[j] );
            }
        }
        return;
    }
}
