using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var d = new Dictionary<int, List<string>>( n );

        foreach( int _ in Range( 0, n ) ) {
            string[] s = ReadLine().Split();
            int i = int.Parse( s[0] );

            if( d.ContainsKey( i ) != true ) {
                d[i] = new List<string>() { s[1] };
            } else {
                d[i].Add( s[1] );
            }
        }
        foreach( var p in d.OrderBy( x => x.Key ) ) {
            WriteLine( $"{p.Key} {string.Join( "", p.Value )}" );
        }
        return;
    }
}
