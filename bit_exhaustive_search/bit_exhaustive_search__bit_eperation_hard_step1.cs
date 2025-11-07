// 実行時間 380ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const int len = 30;
        int n = int.Parse( ReadLine() );
        int[] p = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] s = new int[len][];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, len ) ) {
            s[i] = new int[n + 1];
            foreach( int j in Range( 0, n ) ) {
                s[i][j + 1] = ( p[j] >> i ) & 1;
            }
        }
        foreach( int i in Range( 0, len ) ) {
            foreach( int j in Range( 0, n ) ) {
                s[i][j + 1] += s[i][j];
            }
        }
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            int o = 0;
            int[] q = ReadLine().Split().Select( int.Parse ).ToArray();

            q[1]--;
            if( q[0] == 1 ) {
                foreach( int i in Range( 0, len ).Where( x => s[x][q[2]] - s[x][q[1]] == q[2] - q[1] ) ) {
                    o += 1 << i;
                }
            } else if( q[0] == 2 ) {
                foreach( int i in Range( 0, len ).Where( x => 1 <= s[x][q[2]] - s[x][q[1]] ) ) {
                    o += 1 << i;
                }
            } else if( q[0] == 3 ) {
                foreach( int i in Range( 0, len ).Where( x => 0 < ( ( s[x][q[2]] - s[x][q[1]] ) % 2 ) ) ) {
                    o += 1 << i;
                }
            }
            WriteLine( o );
        }
        Out.Flush();
        return;
    }
}
