using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    class Com
    {
        public string A = string.Empty;
        public int B = 0;
    }

    static void Main()
    {
        string[] rl = ReadLine().Split( ' ' );
        int N = int.Parse( rl[0] );
        int M = int.Parse( rl[1] );
        var l = new System.Collections.Generic.List<Com>( N );

        foreach( var i in Range( 0, N ) ) {
            rl = ReadLine().Split( ' ' );

            var c = new Com() {
                A = rl[0],
                B = int.Parse( rl[1] )
            };

            l.Add( c );
        }
        foreach( var i in Range( 0, M ) ) {
            bool f = false;
            string t = ReadLine();

            foreach( var j in Range( 0, N ) ) {
                if( l[j].A == t ) {
                    f = true;
                    WriteLine( l[j].B );
                    break;
                }
            }
            if( f != true ) {
                WriteLine( -1 );
            }
        }
        return;
    }
}
