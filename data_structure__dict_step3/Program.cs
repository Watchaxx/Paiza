using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    class Str
    {
        public string S = string.Empty;
        public int A = 1;
    }

    static void Main()
    {
        int N = int.Parse( ReadLine() );
        var l = new System.Collections.Generic.List<Str>( N );
        Str s = new Str() {
            A = 1,
            S = ReadLine()
        };

        l.Add( s );
        foreach( var i in Range( 1, N - 1 ) ) {
            bool f = false;
            string t = ReadLine();

            foreach( var j in Range( 0, l.Count ) ) {
                if( l[j].S == t ) {
                    l[j].A++;
                    f = true;
                    break;
                }
            }
            if( f != true ) {
                s = new Str() {
                    A = 1,
                    S = t
                };
                l.Add( s );
            }
        }
        l = l.OrderBy( x => x.S ).ToList();
        foreach( var i in Range( 0, l.Count ) ) {
            WriteLine( $"{l[i].S} {l[i].A}" );
        }
        return;
    }
}
