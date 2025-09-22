// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] yx = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };
        char[][] g = new char[hw[0]][];

        foreach( int i in Range( 0, hw[0] ) ) {
            g[i] = Repeat( '.', hw[1] ).ToArray();
        }
        g[yx[0]][yx[1]] = '*';
        foreach( int i in Range( 0, 4 ) ) {
            int x = yx[1] + dx[i];
            int y = yx[0] + dy[i];

            if( 0 <= y && y < hw[0] && 0 <= x && x < hw[1] ) {
                g[y][x] = '*';
            }
        }
        foreach( char[] c in g ) {
            WriteLine( string.Join( "", c ) );
        }
        return;
    }
}
