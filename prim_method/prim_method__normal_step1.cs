// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int c = 0;
        int o = 0;
        int n = int.Parse( ReadLine() );
        int[][] g = new int[n][];
        bool[] v = new bool[n];
        var l = new System.Collections.Generic.List<int>() { 0 };

        foreach( int i in Range( 0, n ) ) {
            g[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        v[0] = true;
        while( l.Count < n ) {
            int m = 1 << 30;

            foreach( int i in l ) {
                foreach( var t in g[i].Select( ( val, idx ) => new { val, idx } ) ) {
                    if( v[t.idx] != true && 0 < t.val && t.val < m ) {
                        m = t.val;
                        c = t.idx;
                    }
                }
            }
            o += m;
            v[c] = true;
            l.Add( c );
        }
        WriteLine( o );
        return;
    }
}
