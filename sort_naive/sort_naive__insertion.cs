// 実行時間 250ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 1, n - 1 ) ) {
            int x = a[i];
            int j = i - 1;

            while( 0 <= j && x < a[j] ) {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = x;
            WriteLine( string.Join( " ", a ) );
        }
        Out.Flush();
        return;
    }
}
