// 実行時間 150ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] npqr = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[,,] d = new bool[npqr[1] + 1, npqr[2] + 1, npqr[3] + 1];
        var s = new (int, int, int)[npqr[0]];

        foreach( int i in Range( 0, npqr[0] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            s[i] = (t[0], t[1], t[2]);
        }
        foreach( int i in Range( 0, npqr[1] + 1 ).Reverse() ) {
            foreach( int j in Range( 0, npqr[2] + 1 ).Reverse() ) {
                foreach( int k in Range( 0, npqr[3] + 1 ).Reverse() ) {
                    var t = new System.Collections.Generic.HashSet<bool>();

                    foreach( var l in s ) {
                        if( npqr[1] < i + l.Item1 || npqr[2] < j + l.Item2 || npqr[3] < k + l.Item3 ) {
                            t.Add( true );
                        } else {
                            t.Add( d[i + l.Item1, j + l.Item2, k + l.Item3] );
                        }
                    }
                    d[i, j, k] = t.Contains( false );
                }
            }
        }
        WriteLine( d[0, 0, 0] ? 'A' : 'B' );
        return;
    }
}
