// 実行時間 1270ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] npqr = ReadLine().Split().Select( int.Parse ).ToArray();
        decimal[,,] d = new decimal[npqr[1] + 1, npqr[2] + 1, npqr[3] + 1];
        var s = new (int, int, int, int)[npqr[0]];

        foreach( int i in Range( 0, npqr[0] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            s[i] = (t[0], t[1], t[2], t[3]);
        }
        foreach( int i in Range( 0, npqr[1] + 1 ).Reverse() ) {
            foreach( int j in Range( 0, npqr[2] + 1 ).Reverse() ) {
                foreach( int k in Range( 0, npqr[3] + 1 ).Reverse() ) {
                    var t = new System.Collections.Generic.HashSet<decimal>();

                    foreach( var l in s ) {
                        decimal u = 100m;

                        if( npqr[1] < i + l.Item1 || npqr[2] < j + l.Item2 || npqr[3] < k + l.Item3 ) {
                        } else {
                            u = d[i + l.Item1, j + l.Item2, k + l.Item3];
                        }
                        t.Add( ( 10000m - l.Item4 * u ) / ( 200m - l.Item4 ) );
                    }
                    d[i, j, k] = t.Max();
                }
            }
        }
        WriteLine( d[0, 0, 0] );
        return;
    }
}
