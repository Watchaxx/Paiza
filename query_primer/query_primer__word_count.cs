using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0] + 1];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Enumerable.Range( 1, n[0] ) ) {
            a[i] = a[i - 1] + int.Parse( ReadLine() );
        }
        foreach( int i in Enumerable.Range( 0, n[1] ) ) {
            int[] lr = ReadLine().Split().Select( int.Parse ).ToArray();
            int pa = lr[1] - lr[0] + 1;
            int pb = lr[3] - lr[2] + 1;

            if( n[0] / 3m <= pa ) {
                WriteLine( n[0] / 3m <= pb ? "DRAW" : "B" );
                continue;
            } else if( n[0] / 3m <= pb ) {
                WriteLine( 'A' );
                continue;
            }

            int ia = a[lr[1]] - a[lr[0] - 1];
            int ib = a[lr[3]] - a[lr[2] - 1];

            WriteLine( ib < ia ? "A" : ia < ib ? "B" : "DRAW" );
        }
        Out.Flush();
        return;
    }
}
