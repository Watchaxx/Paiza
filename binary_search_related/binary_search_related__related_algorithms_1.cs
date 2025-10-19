// 実行時間 180ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = new int[n[0] + 1];
        int[] l = new int[n[0]];
        int[] r = new int[n[0]];

        foreach( int i in Range( 0, n[0] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            l[i] = a[0];
            r[i] = a[1];
        }

        int m = int.Parse( ReadLine() );

        d[0] = l[0];
        foreach( int i in Range( 1, n[0] - 1 ) ) {
            d[i] = l[i] - l[i - 1];
        }
        d[n[0]] = m - l[n[0] - 1];

        double lo = Accumulate( r );
        double hi = 1e12;

        while( 1e-6 < hi - lo ) {
            double mi = ( lo + hi ) / 2;
            double s = 0d;
            double v = mi;

            foreach( int i in Range( 0, n[0] + 1 ) ) {
                s += d[i] / v;
                if( i < n[0] ) {
                    v -= r[i];
                    if( v <= 0 ) {
                        s = 1e6;
                        break;
                    }
                }
            }
            if( s <= n[1] ) {
                hi = mi;
            } else {
                lo = mi;
            }
        }
        WriteLine( lo );
        return;
    }

    static double Accumulate( int[] a )
    {
        double d = 0d;

        foreach( int i in a ) {
            d += i;
        }
        return d;
    }
}
