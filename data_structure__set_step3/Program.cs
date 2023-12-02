using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int N = int.Parse( ReadLine() );
        string[] rl = ReadLine().Split( ' ' );

        foreach( var i in Range( 1, N - 1 ) ) {
            bool f = false;

            foreach( var j in Range( 0, i ) ) {
                if( System.Array.IndexOf( rl, rl[i] ) < i ) {
                    f = true;
                    WriteLine( "Yes" );
                    break;
                }
            }
            if( f != true ) {
                WriteLine( "No" );
            }
        }
        return;
    }
}
