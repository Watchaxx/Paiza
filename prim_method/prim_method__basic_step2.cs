// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[][] g = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            g[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }

        int[] v = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 0, n ) ) {
            int mc = 1 << 30;
            int mn = i + 1;

            foreach( int j in Range( 0, n ) ) {
                if( g[i][j] == 0 || v[j] == 1 ) {
                    continue;
                }
                if( g[i][j] < mc ) {
                    mc = g[i][j];
                    mn = j + 1;
                }
            }
            if( mn == i + 1 ) {
                mc = 0;
            }
            WriteLine( $"{mn} {mc}" );
        }
        return;
    }
}
