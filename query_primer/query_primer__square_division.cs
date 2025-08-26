using System.Linq;
using static System.Console;
using static System.Math;

internal class Program
{
    static void Main()
    {
        const int num = 10000;
        int k = int.Parse( ReadLine() );
        int sq = (int)Sqrt( num );
        int[] a = new int[num];
        int[] am = new int[sq];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Enumerable.Range( 0, num ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        foreach( int i in Enumerable.Range( 0, sq ) ) {
            foreach( int j in Enumerable.Range( 0, sq ) ) {
                am[i] = j == 0 ? a[sq * i] : Max( am[i], a[sq * i + j] );
            }
        }
        foreach( int _ in Enumerable.Range( 0, k ) ) {
            int i = 0;
            int o = 0;
            int[] lr = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            i = lr[0];
            o = a[lr[0]];
            while( i <= lr[1] ) {
                if( i % sq == 0 && i + sq - 1 <= lr[1] ) {
                    o = Max( o, am[i / sq] );
                    i += sq;
                } else {
                    o = Max( o, a[i] );
                    i++;
                }
            }
            WriteLine( o );
        }
        Out.Flush();
        return;
    }
}
