// 実行時間 90ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] l = new int[n[1]];
        int[] r = new int[n[1]];
        int[] x = new int[n[1]];

        foreach( int i in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            l[i] = t[0] - 1;
            r[i] = t[1] - 1;
            x[i] = t[2];
        }
        foreach( int i in Range( 0, 1 << n[0] ) ) {
            bool b = true;
            int[] p = new int[n[0]];

            foreach( int j in Range( 0, n[0] ).Where( z => ( ( i >> z ) & 1 ) == 1 ) ) {
                p[j] = 1;
            }
            foreach( int j in Range( 0, n[1] ) ) {
                int c = 0;

                foreach( int k in Range( l[j], r[j] - l[j] + 1 ).Where( z => p[z] == 1 ) ) {
                    c++;
                }
                if( c != x[j] ) {
                    b = false;
                    break;
                }
            }
            if( b == true ) {
                o++;
            }
        }
        WriteLine( o );
        return;
    }
}
