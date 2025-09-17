// 実行時間 240ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            WriteLine( BinarySearch( a, int.Parse( ReadLine() ) ) ? "Yes" : "No" );
        }
        Out.Flush();
        return;
    }

    static bool BinarySearch( int[] a, int k )
    {
        int l = 0;
        int r = a.Length - 1;

        while( l <= r ) {
            int m = ( l + r ) / 2;

            if( a[m] == k ) {
                return true;
            } else if( a[m] < k ) {
                l = m + 1;
            } else {
                r = m - 1;
            }
        }
        return false;
    }
}
