// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int c = 0;
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[] v = new bool[n[0]];
        var g = new System.ValueTuple<int, int, int>[n[1]];
        var l = new System.Collections.Generic.List<int>() { 0 };

        foreach( int i in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            g[i] = (--a[0], --a[1], a[2]);
        }
        v[0] = true;
        while( l.Count < n[0] ) {
            int m = 1 << 30;

            foreach( var i in g ) {
                if( v[i.Item1] && !v[i.Item2] && i.Item3 < m ) {
                    c = i.Item2;
                    m = i.Item3;
                } else if( v[i.Item2] && !v[i.Item1] && i.Item3 < m ) {
                    c = i.Item1;
                    m = i.Item3;
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
