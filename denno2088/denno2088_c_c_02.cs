using System;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( Console.ReadLine() );
        var sb = new System.Text.StringBuilder();

        while( n != 0 ) {
            Tpl t = DivMod( n, 3 );

            n = t.Item1;
            sb.Insert( 0, t.Item2 );
            if( t.Item2 == 2 ) {
                n++;
            }
        }
        if( sb.Length == 0 ) {
            sb.AppendLine( "0" );
        }
        Console.WriteLine( sb );
        return;
    }

    static Tpl DivMod( int a, int b )
    {
        if( 0 <= a ) {
            return new Tpl( a / b, a % b );
        } else {
            decimal s = Math.Floor( (decimal)a / b );

            return new Tpl( (int)s, Math.Abs( b * (int)s - a ) );
        }
    }
}
