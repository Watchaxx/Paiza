// 実行時間 160ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int q = int.Parse( ReadLine() );
        long w = 0;
        Lst l = new Lst();
        Lst r = new Lst();

        for( int _ = 0; _ < q; _++ ) {
            string[] s = ReadLine().Split();

            switch( s[0] ) {
            case "ADD_LEFT":
                int x = int.Parse( s[1] );

                w += x;
                l.Add( x );
                break;
            case "ADD_RIGHT":
                x = int.Parse( s[1] );
                w += x;
                r.Add( x );
                break;
            case "REMOVE_LEFT":
                if( 0 < l.Count ) {
                    w -= l.Last();
                    l.RemoveAt( l.Count - 1 );
                } else {
                    w -= r[0];
                    r.RemoveAt( 0 );
                }
                break;
            case "REMOVE_RIGHT":
                if( 0 < r.Count ) {
                    w -= r.Last();
                    r.RemoveAt( r.Count - 1 );
                } else {
                    w -= l[0];
                    l.RemoveAt( 0 );
                }
                break;
            }
        }
        WriteLine( w );
        return;
    }
}
