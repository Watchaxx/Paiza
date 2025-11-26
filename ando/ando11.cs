// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        bool[,] q = new bool[n, n];

        foreach( int i in Range( 0, n ) ) {
            string[] s = ReadLine().Split();

            foreach( int j in Range( 0, n ) ) {
                q[i, j] = s[j] == "1";
            }
        }

        int m = int.Parse( ReadLine() );
        bool[,] p = new bool[m, m];

        foreach( int i in Range( 0, m ) ) {
            string[] s = ReadLine().Split();

            foreach( int j in Range( 0, m ) ) {
                p[i, j] = s[j] != "0";
            }
        }
        foreach( int i in Range( 0, n - m + 1 ) ) {
            foreach( int j in Range( 0, n - m + 1 ) ) {
                bool b = false;

                foreach( int k in Range( 0, m ) ) {
                    foreach( int l in Range( 0, m ).Where( x => q[i + k, j + x] != p[k, x] ) ) {
                        b = true;
                    }
                    if( b == true ) {
                        break;
                    }
                }
                if( b != true ) {
                    WriteLine( $"{i} {j}" );
                    return;
                }
            }
        }
        return;
    }
}
