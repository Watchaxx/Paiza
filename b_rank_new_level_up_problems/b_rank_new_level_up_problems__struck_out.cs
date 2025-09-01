// 実行時間 190ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int[]>;

internal class Program
{
    static void Main()
    {
        int[] p = new int[9];
        int[] s = new int[9];
        int[,] b = new int[9, 4];
        int a = 0;
        int o = 0;
        var l = new Lst();

        foreach( int i in Range( 0, 3 ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            foreach( int j in Range( 0, 3 ) ) {
                p[3 * i + j] = 3 * i + j;
                s[3 * i + j] = t[j];
                o += s[3 * i + j];
            }
        }
        foreach( int i in Range( 0, 9 ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            foreach( int j in Range( 0, t.Length ) ) {
                b[i, j] = t[j];
            }
        }
        Permute( l, p, 0 );
        foreach( int[] i in l ) {
            bool[] op = new bool[9];
            int t = 0;

            foreach( int j in Range( 0, 9 ) ) {
                int u = 0;

                switch( i[j] ) {
                case 0:
                    u += op[1] && op[2] ? 1 : 0;
                    u += op[3] && op[6] ? 1 : 0;
                    u += op[4] && op[8] ? 1 : 0;
                    break;
                case 1:
                    u += op[0] && op[2] ? 1 : 0;
                    u += op[4] && op[7] ? 1 : 0;
                    break;
                case 2:
                    u += op[0] && op[1] ? 1 : 0;
                    u += op[4] && op[6] ? 1 : 0;
                    u += op[5] && op[8] ? 1 : 0;
                    break;
                case 3:
                    u += op[0] && op[6] ? 1 : 0;
                    u += op[4] && op[5] ? 1 : 0;
                    break;
                case 4:
                    u += op[0] && op[8] ? 1 : 0;
                    u += op[1] && op[7] ? 1 : 0;
                    u += op[2] && op[6] ? 1 : 0;
                    u += op[3] && op[5] ? 1 : 0;
                    break;
                case 5:
                    u += op[2] && op[8] ? 1 : 0;
                    u += op[3] && op[4] ? 1 : 0;
                    break;
                case 6:
                    u += op[0] && op[3] ? 1 : 0;
                    u += op[2] && op[4] ? 1 : 0;
                    u += op[7] && op[8] ? 1 : 0;
                    break;
                case 7:
                    u += op[1] && op[4] ? 1 : 0;
                    u += op[6] && op[8] ? 1 : 0;
                    break;
                case 8:
                    u += op[0] && op[4] ? 1 : 0;
                    u += op[2] && op[5] ? 1 : 0;
                    u += op[6] && op[7] ? 1 : 0;
                    break;
                }
                if( 0 < u ) {
                    t += b[i[j], u - 1];
                }
                op[i[j]] = true;
            }
            a = System.Math.Max( a, t );
        }
        WriteLine( a + o );
        return;
    }

    static void Permute( Lst l1, int[] l2, int a )
    {
        for( int i = a; i < l2.Length; i++ ) {
            int t = l2[a];

            l2[a] = l2[i];
            l2[i] = t;
            Permute( l1, l2, a + 1 );
            t = l2[a];
            l2[a] = l2[i];
            l2[i] = t;
        }
        if( a == l2.Length - 1 ) {
            int[] n = new int[l2.Length];

            System.Array.ConstrainedCopy( l2, 0, n, 0, l2.Length );
            l1.Add( n );
        }
        return;
    }
}
