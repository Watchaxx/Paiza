// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static int h = 0;
    static int w = 0;
    static char[][] s;

    static void Main()
    {
        int o = 0;
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();

        h = hw[0];
        w = hw[1];
        s = new char[h][];
        foreach( int i in Range( 0, h ) ) {
            s[i] = ReadLine().ToCharArray();
        }
        foreach( int i in Range( 0, h ) ) {
            foreach( int j in Range( 0, w ) ) {
                if( s[i][j] == '.' ) {
                    Dfs( i, j );
                    o++;
                }
            }
        }
        WriteLine( o );
        return;
    }

    static void Dfs( int y, int x )
    {
        s[y][x] = '#';
        for( int i = -1; i <= 1; i += 2 ) {
            if( 0 <= y + i && y + i < h && s[y + i][x] == '.' ) {
                Dfs( y + i, x );
            }
            if( 0 <= x + i && x + i < w && s[y][x + i] == '.' ) {
                Dfs( y, x + i );
            }
        }
        return;
    }
}
