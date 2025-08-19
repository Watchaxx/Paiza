using System.Linq;
using static System.Console;
using Tpl = System.Tuple<char, int, int>;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var l = new System.Collections.Generic.List<char>( n[1] + 1 );
        var a = new Tpl[n[0]];

        foreach( int i in Enumerable.Range( 0, n[0] ) ) {
            string[] t = ReadLine().Split();

            a[i] = new Tpl( t[0][0], int.Parse( t[1] ) - 1, int.Parse( t[2] ) - 1 );
        }
        l.Add( a[--n[2]].Item1 );
        foreach( int _ in Enumerable.Range( 0, n[1] ) ) {
            int m = int.Parse( ReadLine() );

            if( m == 1 ) {
                n[2] = a[n[2]].Item2;
            } else if( m == 2 ) {
                n[2] = a[n[2]].Item3;
            }
            l.Add( a[n[2]].Item1 );
        }
        WriteLine( string.Join( "", l ) );
        return;
    }
}
