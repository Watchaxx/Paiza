// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] g = new int[n[0]][];

        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }

        int[] h = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[] v = new bool[n[0]];

        h[n[1] - 1] = 0;
        foreach( int _ in Range( 0, n[0] ) ) {
            int mc = 1 << 30;
            int mn = -1;

            foreach( int i in Range( 0, n[0] ) ) {
                if( v[i] != true && h[i] < mc ) {
                    mc = h[i];
                    mn = i;
                }
            }
            if( mn == -1 ) {
                break;
            }
            v[mn] = true;
            foreach( int i in Range( 0, n[0] ) ) {
                if( v[i] != true && g[mn][i] != 0 ) {
                    h[i] = System.Math.Min( h[i], h[mn] + g[mn][i] );
                }
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, h ) );
        return;
    }
}
