using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int r = 0;
        string S = ReadLine();

        foreach( var i in Range( 0, S.Length - 1 ) ) {
            if( S.Substring( i, 2 ) == "令和" ) {
                r++;
            }
        }
        WriteLine( r );
        return;
    }
}
