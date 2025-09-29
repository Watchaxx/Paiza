// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] g = new int[nm[0]][];
        int q = int.Parse( ReadLine() );
        int z = 0;

        foreach( int i in Range( 0, nm[0] ) ) {
            g[i] = new int[nm[1]];
        }
        foreach( int _ in Range( 0, q ) ) {
            string[] s = ReadLine().Split();
            int x = int.Parse( s[1] ) - 1;
            int y = int.Parse( s[2] ) - 1;

            if( 2 <= g[x][y] || g[x][y] <= -2 ) {
                continue;
            } else if( s[0][0] == 'A' ) {
                g[x][y]++;
            } else if( s[0][0] == 'B' ) {
                g[x][y]--;
            }
        }
        foreach( int[] i in g ) {
            foreach( int j in i ) {
                if( 1 <= j ) {
                    z++;
                } else if( j <= -1 ) {
                    z--;
                }
            }
        }
        WriteLine( 0 < z ? "A" : z < 0 ? "B" : "Draw" );
        return;
    }
}
