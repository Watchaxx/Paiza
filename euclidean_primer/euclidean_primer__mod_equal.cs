// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] na = ReadLine().Split().Select( int.Parse ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 1, 100000 ) ) {
            if( na[1] % na[0] == i % na[0] ) {
                WriteLine( i );
            }
        }
        Out.Flush();
        return;
    }
}
