// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        if( n[1] == 0 ) {
            WriteLine( 0 );
            return;
        }

        int o = 0;

        foreach( int i in ReadLine().Split().Select( int.Parse ) ) {
            o += 1 << i;
        }
        WriteLine( o );
        return;
    }
}
