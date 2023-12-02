using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int N = int.Parse( ReadLine() );
        int t = 0;
        int s = 0;
        int[] tl = new int[25];

        foreach( var i in Range( 0, 25 ) ) {
            tl[i] = 0;
        }
        foreach( var i in Range( 0, N ) ) {
            string[] rl = ReadLine().Split( ' ' );

            switch( rl[1] ) {
            case "in":
                tl[int.Parse( rl[0] )] = 5;
                break;
            case "out":
                tl[int.Parse( rl[0] )] = 3;
                break;
            }
        }
        t += tl[0];
        foreach( var i in Range( 1, 24 ) ) {
            if( t == 0 ) {
                s++;
            } else {
                t--;
                s += 2;
            }
            t += tl[i];
        }
        WriteLine( s );
        return;
    }
}
