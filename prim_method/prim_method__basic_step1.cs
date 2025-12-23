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
        foreach( int i in Range( 0, n ) ) {
            int mc = 1 << 30;
            int mn = -1;

            foreach( int j in Range( 0, n ) ) {
                if( 0 < g[i][j] && g[i][j] < mc ) {
                    mc = g[i][j];
                    mn = j + 1;
                }
            }
            WriteLine( $"{mn} {mc}" );
        }
        return;
    }
}
