using System.Collections.Generic;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string s = ReadLine();
        var l = new List<int>( n );
        var t = new Stack<int>( n );

        for( int i = 0; i < n; i++ ) {
            if( s[i] == 'L' ) {
                t.Push( i + 1 );
            } else if( s[i] == 'R' ) {
                l.Add( i + 1 );
            }
        }
        WriteLine( $"{string.Join( " ", t )} {string.Join( " ", l )}".Trim() );
        return;
    }
}
