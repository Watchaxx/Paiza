// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static void Main()
    {
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] syx = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] gyx = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };
        int[][] d = new int[hw[0]][];
        char[][] g = new char[hw[0]][];
        var q = new System.Collections.Generic.Queue<Tpl>();

        foreach( int i in Range( 0, hw[0] ) ) {
            g[i] = ReadLine().ToCharArray();
        }
        foreach( int i in Range( 0, hw[0] ) ) {
            d[i] = Repeat( -1, hw[1] ).ToArray();
        }
        d[syx[0]][syx[1]] = 0;
        q.Enqueue( new Tpl( syx[0], syx[1] ) );
        while( 0 < q.Count ) {
            Tpl t = q.Dequeue();

            foreach( int i in Range( 0, 4 ) ) {
                int x = t.Item2 + dx[i];
                int y = t.Item1 + dy[i];

                if( 0 <= x && x < hw[1] && 0 <= y && y < hw[0] && g[y][x] == '.' && d[y][x] < 0 ) {
                    d[y][x] = d[t.Item1][t.Item2] + 1;
                    q.Enqueue( new Tpl( y, x ) );
                }
            }
        }
        // C# 9 以降は $"" 不要
        WriteLine( 0 <= d[gyx[0]][gyx[1]] ? $"{d[gyx[0]][gyx[1]]}" : "No" );
        return;
    }
}
