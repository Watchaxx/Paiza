using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int s = 0;
        int[][] m = new int[n][];
        var l = new System.Collections.Generic.List<Tpl>( 2 );

        foreach( int i in Range( 0, n ) ) {
            m[i] = ReadLine().Split().Select( int.Parse ).ToArray();
            if( m[i].All( x => x != 0 ) ) {
                s = m[i].Sum();
            } else {
                foreach( int j in Range( 0, n ).Where( x => m[i][x] == 0 ) ) {
                    l.Add( new Tpl( i, j ) );
                }
            }
        }
        if( l[0].Item1 != l[1].Item1 ) {
            m[l[0].Item1][l[0].Item2] = s - m[l[0].Item1].Sum();
            m[l[1].Item1][l[1].Item2] = s - m[l[1].Item1].Sum();
        } else {
            foreach( Tpl p in l ) {
                int t = 0;

                foreach( int i in Range( 0, n ) ) {
                    t += m[i][p.Item2];
                }
                m[p.Item1][p.Item2] = s - t;
            }
        }
        WriteLine( string.Join(
            System.Environment.NewLine, Range( 0, n ).Select( x => string.Join( " ", m[x] ) ) ) );
        return;
    }
}
