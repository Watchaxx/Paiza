// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] t = new int[hw[0]][];
        var s = new HashSet<(int, int, int)>();
        var q = new Queue<(int, int, int)>();

        foreach( int i in Range( 0, hw[0] ) ) {
            t[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        q.Enqueue( (0, 0, t[0][0]) );
        while( 0 < q.Count ) {
            var p = q.Dequeue();

            if( p.Item1 == hw[1] - 1 && p.Item2 == hw[0] - 1 ) {
                WriteLine( new[] {
                    p.Item3,
                    q.Where( x => x.Item1 == hw[1] - 1 && x.Item2 == hw[0] - 1 ).OrderBy( x => x.Item3 ).First().Item3
                }.Min() );
                break;
            }
            if( s.Contains( p ) == true ) {
                continue;
            }
            s.Add( p );
            foreach( int i in Range( 0, 4 ) ) {
                int x = p.Item1 + dx[i];
                int y = p.Item2 + dy[i];

                if( 0 <= x && x < hw[1] && 0 <= y && y < hw[0] ) {
                    q.Enqueue( (x, y, p.Item3 + t[y][x]) );
                }
            }
        }
        return;
    }
}
