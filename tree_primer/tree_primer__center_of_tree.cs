// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int v = n;
        bool[] e = Repeat( true, n ).ToArray();
        bool[][] g = new bool[n][];
        var rng = Range( 0, n );

        foreach( int i in rng ) {
            g[i] = new bool[n];
        }
        foreach( int _ in Range( 0, n - 1 ) ) {
            int[] a = ReadLine().Trim().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]][a[1]] = true;
            g[a[1]][a[0]] = true;
        }
        while( 2 < v ) {
            foreach( int i in rng ) {
                int cnt = 0;

                foreach( int j in rng ) {
                    if( g[i][j] == true ) {
                        cnt++;
                    }
                }
                if( cnt == 1 ) {
                    v--;
                    e[i] = false;
                    g[i] = new bool[n];
                }
            }
            foreach( int i in rng ) {
                foreach( int j in rng ) {
                    if( e[j] != true && g[i][j] == true ) {
                        g[i][j] = false;
                    }
                }
            }
        }
        foreach( int i in rng.Where( i => e[i] == true ) ) {
            WriteLine( i + 1 );
        }
        return;
    }
}
