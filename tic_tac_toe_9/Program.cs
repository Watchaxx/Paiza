using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        string[] b = new string[5];
        string t = "";
        char o = 'D';

        foreach( int i in Range( 0, 5 ) ) {
            t = ReadLine();

            //ヨコ判定
            o = Judge( t );
            if( o != 'D' ) {
                WriteLine( o );
                return;
            }
            b[i] = t;
        }
        foreach( int i in Range( 0, 5 ) ) {
            t = "";
            foreach( string l in b ) {
                t += l[i];
            }
            //タテ判定
            o = Judge( t );
            if( o != 'D' ) {
                WriteLine( o );
                return;
            }
        }

        t = "";
        foreach( int i in Range( 0, 5 ) ) {
            t += b[i][i];
        }
        //ナナメ(＼)判定
        o = Judge( t );
        if( o != 'D' ) {
            WriteLine( o );
            return;
        }

        int idx = 4;

        t = "";
        foreach( int i in Range( 0, 5 ) ) {
            t += b[i][idx];
            idx--;
        }
        //ナナメ(／)判定
        WriteLine( Judge( t ) );
        return;
    }

    static char Judge( string s )
    {
        char o = 'D';

        if( s == "OOOOO" ) {
            o = 'O';
        } else if( s == "XXXXX" ) {
            o = 'X';
        }
        return o;
    }
}
