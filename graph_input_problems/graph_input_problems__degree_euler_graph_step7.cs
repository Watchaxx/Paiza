// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] li = new int[n[0]];
        int[] lo = new int[n[0]];

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            li[t[1]]++;
            lo[t[0]]++;
        }
        foreach( int i in Range( 0, n[0] ).Where( x => li[x] != lo[x] ) ) {
            WriteLine( 0 );
            return;
        }
        WriteLine( 1 );
        return;
    }
}
