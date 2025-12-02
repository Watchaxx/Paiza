// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[n[1]][];

        foreach( int i in Range( 0, n[1] ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int _ in Range( 0, n[2] ) ) {
            int di = 999;
            int tr = 0;
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            foreach( int i in Range( 0, 2 ) ) {
                if( t[i] == t[i + 1] ) {
                    continue;
                }

                int w = 999;

                foreach( int[] j in a.Where( x => x[0] == t[i] && x[1] == t[i + 1] ) ) {
                    w = j[2];
                    break;
                }
                if( w != 999 ) {
                    tr += w;
                } else {
                    tr = 999;
                    break;
                }
            }
            if( t[0] == t[2] ) {
                di = 0;
            } else {
                foreach( int[] i in a.Where( x => x[0] == t[0] && x[1] == t[2] ) ) {
                    di = i[2];
                }
            }
            WriteLine( tr < di ? "transit" : di < tr ? "direct" : "same" );
        }
        return;
    }
}
