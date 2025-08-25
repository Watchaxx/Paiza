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
        foreach( int _ in Enumerable.Range( 0, n[1] ) ) {
            WriteLine( a[int.Parse( ReadLine() )] );
        }
        Out.Flush();
        return;
    }
}
