// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<(int, int)>;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var h = new Lst();

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            if( a[0] != n[2] ) {
                continue;
            }

            int c = h.Count;

            h.Add( (a[1], a[2]) );
            while( 0 < c ) {
                int p = ( c - 1 ) / 2;

                if( h[c].Item2 < h[p].Item2
                    || ( h[c].Item2 == h[p].Item2 && h[c].Item1 < h[p].Item1 ) ) {
                    var t = h[c];
                    h[c] = h[p];
                    h[p] = t;
                    c = p;
                } else {
                    break;
                }
            }
        }
        WriteLine( 0 < h.Count ? $"{h[0].Item1}" : "inf" );
        return;
    }
}
