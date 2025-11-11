using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        string s = ReadLine();
        int t = int.Parse( ReadLine() );

        foreach( char c in s.Where( x => x == '1' ) ) {
            t--;
            if( t <= 0 ) {
                WriteLine( "No" );
                return;
            }
        }
        WriteLine( t );
        return;
    }
}
