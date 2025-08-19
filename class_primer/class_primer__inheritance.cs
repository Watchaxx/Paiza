using System.Linq;
using static System.Console;

internal class Program
{
    class Cus
    {
        internal uint Amo { get; set; } = 0;

        internal virtual void Order( string s, uint i )
        {
            if( StrComp( s, "food" ) || StrComp( s, "softdrink" ) ) {
                Amo += i;
            }
            return;
        }
    }

    class Adu : Cus
    {
        bool Dis { get; set; } = false;

        internal override void Order( string s, uint i )
        {
            if( StrComp( s, "food" ) == true ) {
                Amo += Dis ? i - 200 : i;
            } else if( StrComp( s, "softdrink" ) == true ) {
                Amo += i;
            } else if( StrComp( s, "alcohol" ) == true ) {
                Amo += i;
                Dis = true;
            }
            return;
        }
    }

    static bool StrComp( string a, string b )
    {
        return string.Compare( a, b, System.StringComparison.Ordinal ) == 0;
    }

    static void Main()
    {
        int[] nk = ReadLine().Split().Select( int.Parse ).ToArray();
        Cus[] a = new Cus[nk[0]];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Enumerable.Range( 0, nk[0] ) ) {
            a[i] = int.Parse( ReadLine() ) < 20 ? new Cus() : new Adu();
        }
        foreach( int i in Enumerable.Range( 0, nk[1] ) ) {
            string[] s = ReadLine().Split();

            a[int.Parse( s[0] ) - 1].Order( s[1], uint.Parse( s[2] ) );
        }
        foreach( Cus c in a ) {
            WriteLine( c.Amo );
        }
        Out.Flush();
        return;
    }
}
