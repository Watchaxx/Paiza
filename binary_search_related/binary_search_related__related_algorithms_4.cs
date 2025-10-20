// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<long, long>;

internal class Program
{
    static int n;
    static int m;
    static int[] x;
    static int[] y;

    static void Main()
    {
        int[] t = ReadLine().Split().Select( int.Parse ).ToArray();
        Tpl l = new Tpl( 0L, 1L );
        Tpl r = new Tpl( 1L, 0L );

        n = t[0];
        m = t[1];
        x = new int[n];
        y = new int[n];
        foreach( int i in Range( 0, n ) ) {
            t = ReadLine().Split().Select( int.Parse ).ToArray();
            x[i] = t[0];
            y[i] = t[1];
        }
        while( true ) {
            Tpl m = new Tpl( l.Item1 + r.Item1, l.Item2 + r.Item2 );
            int i = Func( m );

            if( i == 0 ) {
                WriteLine( $"{m.Item1} {m.Item2}" );
                break;
            } else if( i < 0 ) {
                l = m;
            } else if( 0 < i ) {
                r = m;
            }
        }
        return;
    }

    static int Func( Tpl t )
    {
        long s = 0L;
        long[] v = new long[n];

        foreach( int i in Range( 0, n ) ) {
            v[i] = t.Item2 * y[i] - t.Item1 * x[i];
        }
        foreach( long l in v.OrderByDescending( x => x ).Take( m ) ) {
            s += l;
        }
        return 0 < s ? -1 : s < 0 ? 1 : 0;
    }
}
