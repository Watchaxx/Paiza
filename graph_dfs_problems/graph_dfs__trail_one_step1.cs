// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var l = new List<int>() { n[1] };
        var e = new List<(int, int)>();
        var r = new System.Random();

        foreach( int _ in Range( 0, n[2] ) ) {
            int m = 0;
            var f = (0, 0);
            var g = new HashSet<int>();

            while( true ) {
                while( true ) {
                    m = r.Next( 1, n[0] + 1 );
                    if( Range( 1, n[0] ).Except( new[] { n[1] } ).Except( g ).Contains( m ) == true ) {
                        break;
                    }
                }
                f = (new[] { n[1], m }.Min(), new[] { n[1], m }.Max());
                if( e.Contains( f ) != true ) {
                    break;
                }
                g.Add( m );
            }
            n[1] = m;
            e.Add( f );
            l.Add( m );
        }
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
