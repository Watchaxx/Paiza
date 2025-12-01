// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] d = new int[hw[0]][];
        bool[][] t = new bool[hw[0]][];
        var q = new System.Collections.Generic.Queue<(int, int)>();

        foreach( int i in Range( 0, hw[0] ) ) {
            d[i] = Repeat( -1, hw[1] ).ToArray();
            t[i] = ReadLine().Split().Select( ToBool ).ToArray();
        }
        d[0][0] = 1;
        q.Enqueue( (0, 0) );
        while( 0 < q.Count ) {
            var p = q.Dequeue();

            foreach( int i in Range( 0, 4 ) ) {
                int x = p.Item1 + dx[i];
                int y = p.Item2 + dy[i];

                if( 0 <= x && x < hw[0] && 0 <= y && y < hw[1] && t[x][y] == true && d[x][y] == -1 ) {
                    d[x][y] = d[p.Item1][p.Item2] + 1;
                    q.Enqueue( (x, y) );
                }
            }
        }
        WriteLine( d[hw[0] - 1][hw[1] - 1] );
        return;
    }

    static bool ToBool( string s )
    {
        return s == "0";
    }
}
