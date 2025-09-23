// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<System.Tuple<int, int>>;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static void Main()
    {
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] yx = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };
        char[][] g = new char[hw[0]][];
        Lst[] l = new Lst[4];

        foreach( int i in Range( 0, hw[0] ) ) {
            g[i] = Repeat( '.', hw[1] ).ToArray();
        }
        g[yx[0]][yx[1]] = '*';
        l[0] = new Lst() { new Tpl( yx[0], yx[1] ) };
        foreach( int i in Range( 1, 3 ) ) {
            l[i] = new Lst( 4 * i );
        }
        foreach( int i in Range( 0, 3 ) ) {
            foreach( Tpl t in l[i] ) {
                foreach( int j in Range( 0, 4 ) ) {
                    int x = t.Item2 + dx[j];
                    int y = t.Item1 + dy[j];

                    if( 0 <= y && y < hw[0] && 0 <= x && x < hw[1] ) {
                        g[y][x] = '*';
                        l[i + 1].Add( new Tpl( y, x ) );
                    }
                }
            }
        }
        foreach( char[] c in g ) {
            WriteLine( string.Join( "", c ) );
        }
        return;
    }
}
