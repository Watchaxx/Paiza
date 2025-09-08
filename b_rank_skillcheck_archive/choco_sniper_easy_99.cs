// 実行時間 300ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        if( n[0] != 0 ) {
            foreach( int _ in Range( 0, n[1] ) ) {
                o += new int[] { ReadLine().Split().Select( int.Parse ).Sum(), 0 }.Max();
            }
        }
        WriteLine( o );
        return;
    }
}
