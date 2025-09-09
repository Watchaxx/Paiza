// 実行時間 70ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        ReadLine();
        int mi = 0;
        int mx = 0;
        int[] b = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 0, b.Length ).Where( i => mx < b[i] ) ) {
            mi = i + 1;
            mx = b[i];
        }
        WriteLine( mi );
        return;
    }
}
