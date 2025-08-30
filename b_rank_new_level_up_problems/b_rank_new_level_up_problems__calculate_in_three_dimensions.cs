// 実行時間 50ms
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;
        int[] l = new int[4];
        int[,,] a = new int[n, n, n];
        var r = Enumerable.Range( 0, n );

        foreach( int i in r ) {
            foreach( int j in r ) {
                int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

                foreach( int k in r ) {
                    a[i, j, k] = t[k];
                }
            }
        }
        foreach( int i in r ) {
            foreach( int j in r ) {
                int t = 0;

                foreach( int k in r ) {
                    t += a[i, j, k];
                }
                o = Max( o, t );
            }
        }
        foreach( int i in r ) {
            foreach( int j in r ) {
                int t = 0;
                int u = 0;

                foreach( int k in r ) {
                    t += a[j, i, k];
                    u += a[k, i, j];
                }
                o = Max( o, t, u );
            }
        }
        foreach( int i in r ) {
            foreach( int j in r ) {
                int t = 0;
                int u = 0;

                foreach( int k in r ) {
                    t += a[j, k, i];
                    u += a[k, j, i];
                }
                o = Max( o, t, u );
            }
        }
        foreach( int i in r ) {
            int t = 0;
            int u = 0;

            foreach( int j in r ) {
                t += a[i, j, j];
                u += a[i, n - 1 - j, j];
            }
            o = Max( o, t, u );
        }
        foreach( int i in r ) {
            int t = 0;
            int u = 0;

            foreach( int j in r ) {
                t += a[j, i, j];
                u += a[n - 1 - j, i, j];
            }
            o = Max( o, t, u );
        }
        foreach( int i in r ) {
            int t = 0;
            int u = 0;

            foreach( int j in r ) {
                t += a[j, j, i];
                u += a[j, n - 1 - j, i];
            }
            o = Max( o, t, u );
        }
        foreach( int i in r ) {
            l[0] += a[i, i, i];
            l[1] += a[i, i, n - 1 - i];
            l[2] += a[i, n - 1 - i, i];
            l[3] += a[i, n - 1 - i, n - 1 - i];
        }
        WriteLine( Max( o, l.Max() ) );
        return;
    }

    static int Max( int a, int b )
    {
        return new int[] { a, b }.Max();
    }

    static int Max( int a, int b, int c )
    {
        return new int[] { a, b, c }.Max();
    }
}
