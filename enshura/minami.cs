// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] xy = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[][] g = new bool[xy[1]][];

        foreach( int i in Range( 0, xy[1] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            g[i] = new bool[xy[0]];
            foreach( int j in Range( 0, xy[0] ) ) {
                if( t[j] == 1 ) {
                    g[i][j] = true;
                }
            }
        }
        foreach( int i in Range( 0, xy[0] ) ) {
            int t = xy[1] - 1;

            foreach( int j in Range( 0, xy[1] ).Reverse() ) {
                if( g[j][i] != false ) {
                    if( j != t ) {
                        g[t][i] = g[j][i];
                        g[j][i] = false;
                    }
                    t--;
                }
            }
        }
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, xy[1] ).Select( x => string.Join( " ", g[x].Select( System.Convert.ToInt32 ) ) ) ) );
        return;
    }
}
