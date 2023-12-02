using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        bool r = false;
        int N = int.Parse( ReadLine() );
        string[] K = new string[N];
        var l = new System.Collections.Generic.List<string>( 1000 );

        foreach( var i in Range( 0, N ) ) {
            K[i] = ReadLine();
        }
        foreach( var i in Range( 0, N ) ) {
            foreach( var j in Range( 0, N ) ) {
                if( K[i] + K[j] == "令和" ) {
                    r = true;
                }
                if( l.Count < 1000 ) {
                    l.Add( K[i] + K[j] );
                }
            }
        }
        foreach( var i in Range( 0, l.Count ) ) {
            WriteLine( $"{l[i]}" );
        }
        if( r == true ) {
            WriteLine( "Nice" );
        } else {
            WriteLine( "Bad" );
        }
        return;
    }
}
